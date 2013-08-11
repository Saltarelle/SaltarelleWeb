// WebGLExtensionDebugRendererInfo.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class WebGLExtensionDebugRendererInfo {
		internal WebGLExtensionDebugRendererInfo() {
		}

		[IntrinsicProperty, ScriptName("UNMASKED_RENDERER_WEBGL")]
		public uint UNMASKED_RENDERER_WEBGL {
			get { return 0; }
		}

		[IntrinsicProperty, ScriptName("UNMASKED_VENDOR_WEBGL")]
		public uint UNMASKED_VENDOR_WEBGL {
			get { return 0; }
		}
	}
}
