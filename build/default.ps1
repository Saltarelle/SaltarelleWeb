Framework "4.0x86"

properties {
	$baseDir = Resolve-Path ".."
	$buildtoolsDir = Resolve-Path "."
	$outDir = "$(Resolve-Path "".."")\bin"
	$configuration = "Debug"
	$releaseTagPattern = "release-(.*)"
	$autoVersion = $true
	$webIDLSymbols = "MOZ_AUDIO_CHANNEL_MANAGER,MOZ_WEBGL,RELEASE_BUILD,MOZ_WEBRTC,MOZ_WEBSPEECH,MOZ_GAMEPAD,MOZ_MEDIA_NAVIGATOR,MOZ_TIME_MANAGER,MOZ_DISABLE_CRYPTOLEGACY"
}

Function Get-DotNetVersion($RawVersion) {
	Return New-Object System.Version(($RawVersion -Replace "-.*$","")) # Remove any pre-release information
}

Function Get-DependencyVersion($RawVersion) {
	$netVersion = Get-DotNetVersion -RawVersion $RawVersion
	Return New-Object System.Version($netVersion.Major, $netVersion.Minor)
}

Task default -Depends Build

Task Clean {
	if (Test-Path $outDir) {
		rm -Recurse -Force "$outDir" >$null
	}
	md "$outDir" >$null
}

Task Build-Solution -Depends Clean, Generate-VersionInfo {
	Exec { msbuild "$baseDir\Web.sln" /verbosity:minimal /p:"Configuration=$configuration" }
}

Task Build-NuGetPackages -Depends Determine-Version, Build-Solution {
	$config = [xml](Get-Content $baseDir\Web\packages.config)
	$runtimeVersion = $config.SelectSingleNode("//package[@id='Saltarelle.Runtime']/@version").Value
@"
<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">
	<metadata>
		<id>Saltarelle.Web</id>
		<version>$script:Version</version>
		<title>Metadata required to create HTML5 applications using the Saltarelle C# to JavaScript compiler</title>
		<description>This package contains the required metadata to develop web applications with the Saltarelle C# to JavaScript compiler. It is a slightly modified version of the web library from the Script# project by Nikhil Kothari (https://github.com/nikhilk/scriptsharp).</description>
		<licenseUrl>http://www.apache.org/licenses/LICENSE-2.0.txt</licenseUrl>
		<authors>Nikhil Kothari</authors>
		<projectUrl>http://www.saltarelle-compiler.com</projectUrl>
		<tags>compiler c# javascript web</tags>
		<dependencies>
			<dependency id="Saltarelle.Runtime" version="$(Get-DependencyVersion $runtimeVersion)"/>
		</dependencies>
	</metadata>
	<files>
		<file src="$baseDir\License.txt" target=""/>
		<file src="$baseDir\history.txt" target=""/>
		<file src="$baseDir\Web\bin\Saltarelle.Web.dll" target="lib"/>
		<file src="$baseDir\Web\bin\Saltarelle.Web.xml" target="lib"/>
	</files>
</package>
"@ | Out-File -Encoding UTF8 "$outDir\Web.nuspec"

	Exec { & "$buildtoolsDir\nuget.exe" pack "$outDir\Web.nuspec" -NoPackageAnalysis -OutputDirectory "$outDir" }
}

Task Build -Depends Build-NuGetPackages {
}

Task Configure -Depends Generate-VersionInfo {
}

Function Determine-PathVersion($RefCommit, $RefVersion, $Path) {
	if ($autoVersion) {
		$RefVersion = New-Object System.Version(($RefVersion -Replace "-.*$",""))
		if ($RefVersion.Build -lt 0) {
			$RefVersion = New-Object System.Version($RefVersion.Major, $RefVersion.Minor, 0)
		}
	
		$revision = ((git log "$RefCommit..HEAD" --pretty=format:"%H" -- (@($Path) | % { """$_""" })) | Measure-Object).Count # Number of commits since our reference commit
		if ($revision -gt 0) {
			Return New-Object System.Version($RefVersion.Major, $RefVersion.Minor, $RefVersion.Build, $revision)
		}
	}

	$RefVersion
}

Function Determine-Ref {
	$refcommit = % {
	(git log --decorate=full --simplify-by-decoration --pretty=oneline HEAD |           # Append items from the log
		Select-String '\(' |                                                            # Only include entries with names
		% { ($_ -replace "^[^(]*\(([^)]*)\).*$","`$1" -replace " ", "").Split(',') } |  # Select only the names, one line per name, delete spaces
		Select-String "^tag:$releaseTagPattern`$" |                                     # Only tags of interest
		% { $_ -replace "^tag:","" }                                                    # Remove the tag: prefix
	) } { git log --reverse --pretty=format:%H | Select-Object -First 1 } |             # Add the oldest commit as a fallback
	Select-Object -First 1
	
	If ($refcommit | Select-String "^$releaseTagPattern`$") {
		$refVersion = $refcommit -replace "^$releaseTagPattern`$","`$1"
	}
	else {
		$refVersion = "0.0.0"
	}

	($refcommit, $refVersion)
}

Task Determine-Version {
	if (-not $autoVersion) {
		if ((git log -1 --decorate=full --simplify-by-decoration --pretty=oneline HEAD |
			 Select-String '\(' |
			 % { ($_ -replace "^[^(]*\(([^)]*)\).*$","`$1" -replace " ", "").Split(',') } |
			 Select-String "^tag:$releaseTagPattern`$" |
			 % { $_ -replace "^tag:","" } |
			 Measure-Object
			).Count -eq 0) {
			
			Throw "The most recent commit must be tagged when not using auto-versioning"
		}
	}

	$refs = Determine-Ref
	$script:Version = Determine-PathVersion -RefCommit $refs[0] -RefVersion $refs[1] -Path "$baseDir"

	"Version: $script:Version"
}

Function Generate-VersionFile($Path, $Version) {
	$Version = Get-DotNetVersion -RawVersion $Version
@"
[assembly: System.Reflection.AssemblyVersion("$($Version.Major).0.0.0")]
[assembly: System.Reflection.AssemblyFileVersion("$Version")]
"@ | Out-File $Path -Encoding "UTF8"
}

Task Generate-VersionInfo -Depends Determine-Version {
	Generate-VersionFile -Path "$baseDir\Web\Properties\Version.cs" -Version $script:Version
}

function Parse-Line($line) {
	if ($_.IndexOf("#") -gt -1) {
		$line = $_.Substring(0, $_.IndexOf("#"))
	}

	$spaces = 0
	while (($spaces -lt $line.Length) -and ($line[$spaces] -eq " ")) {
		$spaces++
	}

	return @{ Indent = $spaces / 4; Text = $line.Substring($spaces) }
}

function Process($lines, $currentIndent, $symbols, $take, $sources, [ref]$currentLine) {
	while (($currentLine.value -lt $lines.Length) -and ($lines[$currentLine.value].Indent -eq $currentIndent)) {
		$line = $lines[$currentLine.value]
		if ($line.Text -match "^(\S+)\s(\+?=)\s(.+)$") {
			if ($Matches[1] -ne "MODULE") {
				if ($matches[3] -ne "[") {
					throw "Expected '[' on line $($line.Text)"
				}
				$target = $Matches[1]
				$type = $Matches[2]
				
				$list = @()
				$currentLine.value++
				while (($currentLine.value -lt $lines.Length) -and ($lines[$currentLine.value].Indent -eq ($currentIndent + 1))) {
					$line = $lines[$currentLine.value]
					if (-not ($line.Text -match "^'([^']+)',?$")) {
						throw "Expected 'identifier' on line $($line.Text)"
					}
					$list += $Matches[1]
					$currentLine.value++
				}
				if (($currentLine.value -ge $lines.Length) -or ($lines[$currentLine.value].Indent -ne $currentIndent) -or ($lines[$currentLine.value].Text -ne "]")) {
					throw "Expected ']' on line $($currentLines[$currentLine.value].Text)"
				}

				if ($take) {
					if ($type -eq "+=") {
						$sources[$target] += $list
					}
					else {
						$sources[$target] = $list
					}
				}
			}
			$currentLine.value++
		}
		elseif ($line.Text -match "^if CONFIG\['([^']+)'\]:$") {
			$newTake = $take -and $symbols -contains $Matches[1]
			$currentLine.value++
			Process $lines ($currentIndent + 1) $symbols $newTake $sources $currentLine
		}
		else {
			throw "Unknown line $($line.Text)"
		}
	}
}

function Get-Sources($makefile, $symbols) {
	$sources = @{}
	$content = [System.IO.File]::ReadAllText($makefile) -replace "`r`n", "`n" -replace "\\`n",""
	$lines = $content.Split("`n") | % { Parse-Line($_) } | ? { $_.Text -ne "" }
	Process $lines 0 $symbols $true $sources ([ref]0)
	$sources["webidl_files"] += $sources["generated_events_webidl_files"]
	$sources.Remove("generated_events_webidl_files")
	return $sources
}

function Generate-CSS2Properties($root, $workDir, $targetFile) {
	(New-Object System.Net.WebClient).DownloadFile("$($root)/layout/style/nsCSSPropList.h?raw=1", "$workDir\nsCSSPropList.h")
	(New-Object System.Net.WebClient).DownloadFile("$($root)/layout/style/nsCSSPropAliasList.h?raw=1", "$workDir\nsCSSPropAliasList.h")
	(New-Object System.Net.WebClient).DownloadFile("$($root)/dom/webidl/CSS2Properties.webidl.in?raw=1", "$workDir\CSS2Properties.webidl.in")
	(New-Object System.Net.WebClient).DownloadFile("$($root)/dom/webidl/CSS2PropertiesProps.h?raw=1", "$workDir\CSS2PropertiesProps.h")

	# This logic is from the file http://dxr.mozilla.org/mozilla-central/source/dom/bindings/GenerateCSS2PropertiesWebIDL.py

	$content = & "$buildtoolsDir\mcpp.exe" -e utf8 -P "$workDir\CSS2PropertiesProps.h"
	$out = New-Object System.Text.StringBuilder
	$content -split "`n" | % {
		$match = Select-String -Pattern "^\s*\[\s*`"([^`"]*)`"\s*,\s*`"([^`"]*)`"\s*\]\s*,\s*$" -InputObject $_
		if ($match -ne $null) {
			$extendedAttrs = @("Throws", "TreatNullAs=EmptyString")
			$prop = $match.Matches[0].Groups[1].Value
			$pref = $match.Matches[0].Groups[2].Value
			if ($pref) {
				$extendedAttrs += "Pref=`"$pref`""
			}
			if (-not $prop.StartsWith("Moz")) {
				$prop = $prop.Substring(0, 1).ToLower() + $prop.Substring(1)
			}

			$out.AppendFormat("  [{0}] attribute DOMString {1};", ($extendedAttrs -join ", "), $prop).AppendLine() > $null
		}
	}
	
	$template = [System.IO.File]::ReadAllText("$workDir\CSS2Properties.webidl.in")
	"/* THIS IS AN AUTOGENERATED FILE.  DO NOT EDIT */`n`n" + $template.Replace('${props}',$out.ToString()) | Out-File -FilePath "$webidlDir\CSS2Properties.webidl" -Encoding UTF8
}

Task Download-WebIDL {
	$root = "http://mxr.mozilla.org/mozilla-central/source/"
	$webidlRoot = "$($root)dom/webidl/"

	$webidlDir = "$baseDir\webidl"
	$genDir = "$webidlDir\generate"
	if (Test-Path $webidlDir) {
		rm -Recurse -Force $webidlDir >$null
	}

	md $webidlDir >$null
	md $genDir >$null

	(New-Object System.Net.WebClient).DownloadFile($webidlRoot + "moz.build?raw=1", "$webidlDir\moz.build")
	$symbols = $webIDLSymbols -split ","

	$sources = Get-Sources "$webidlDir\moz.build" $symbols

	$total = $sources["webidl_files"].Count + $sources["preprocessed_webidl_files"].Count
	$current = 0

	#simple downloads
	$sources["webidl_files"] | % {
		$current++
		Write-Host "Downloading $_ ($current of $total)"
		(New-Object System.Net.WebClient).DownloadFile("$webidlRoot$($_)?raw=1", "$webidlDir\$_")
	}

	#downloads for preprcessing
	$sources["preprocessed_webidl_files"] | % {
		$current++
		Write-Host "Downloading $_.raw ($current of $total)"
		(New-Object System.Net.WebClient).DownloadFile("$webidlRoot$($_)?raw=1", "$webidlDir\$_.raw")
	}

	#preprocessing
	$total = $sources["preprocessed_webidl_files"].Count
	$current = 0
	$sources["preprocessed_webidl_files"] | % {
		$current++
		Write-Host "Preprocessing $_ ($current of $total)"
		$defines = ($symbols | % { "-D $_" }) -join " "
		$content = iex "$buildtoolsDir\mcpp.exe -e utf8 $defines -P -C -o `"$webidlDir\$_`" `"$webidlDir\$_.raw`""
	}

	#generation
	$total = $sources["generated_webidl_files"].Count
	$current = 0
	$sources["generated_webidl_files"] | % {
		$current++
		if ($_ -eq "CSS2Properties.webidl") {
			Write-Host "Generating $_ ($current of $total)"
			Generate-CSS2Properties $root $genDir "$webidlDir\$_"
		}
		else {
			Write-Error "Don't know how to generate the file $_"
		}
	}
}

Task Generate-Source {
	$webidlDir = "$baseDir\webidl"
	$symbols = $webIDLSymbols -split ","
	$sources = Get-Sources "$webidlDir\moz.build" $symbols
	$sourceList = @("$buildtoolsDir\custom.webidl") + $sources["webidl_files"] + $sources["generated_webidl_files"] + $sources["preprocessed_webidl_files"]

	try {
		$oldLocation = pwd
		cd $webidlDir
		Exec { msbuild "$baseDir\Generator\Generator.sln" /verbosity:minimal /p:"Configuration=$configuration" }
		rmdir -Force -Recurse -ErrorAction SilentlyContinue "$baseDir\Web\Generated" | Out-Null
		try {
			"$($sourceList -join ' ')" | Out-File "$webidlDir\sources.in"
			Exec { & "$baseDir\Generator\Generator\bin\Generator.exe" -o "$baseDir\Web\Generated" -r System -m "$buildtoolsDir\types.meta" "@sources.in" }
		}
		finally {
			del "$webidlDir\sources.in" -ErrorAction Ignore
		}
	}
	finally {
		cd $oldLocation
	}
}