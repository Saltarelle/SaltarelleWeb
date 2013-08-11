// MediaStreamAudioSourceNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This interface represents an audio source from a MediaStream. The first AudioMediaStreamTrack 
	/// from the MediaStream will be used as a source of audio.
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#MediaStreamAudioSourceNode</reference>
	[IgnoreNamespace, Imported]
	public class MediaStreamAudioSourceNode : AudioSourceNode {
		private MediaStreamAudioSourceNode() {
		}
	}
}