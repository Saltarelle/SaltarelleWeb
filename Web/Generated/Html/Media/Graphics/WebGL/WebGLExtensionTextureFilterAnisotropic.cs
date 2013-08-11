// WebGLExtensionTextureFilterAnisotropic.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class WebGLExtensionTextureFilterAnisotropic {
		internal WebGLExtensionTextureFilterAnisotropic() {
		}

		[IntrinsicProperty, ScriptName("MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
		public uint MAX_TEXTURE_MAX_ANISOTROPY_EXT {
			get { return 0; }
		}

		[IntrinsicProperty, ScriptName("TEXTURE_MAX_ANISOTROPY_EXT")]
		public uint TEXTURE_MAX_ANISOTROPY_EXT {
			get { return 0; }
		}
	}
}
