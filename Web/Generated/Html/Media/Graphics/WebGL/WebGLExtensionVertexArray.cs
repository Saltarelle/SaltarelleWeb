using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class WebGLExtensionVertexArray {
		internal WebGLExtensionVertexArray() {
		}

		public void BindVertexArrayOES(WebGLVertexArray arrayObject) {
		}

		public WebGLVertexArray CreateVertexArrayOES() {
			return default(WebGLVertexArray);
		}

		public void DeleteVertexArrayOES(WebGLVertexArray arrayObject) {
		}

		public bool IsVertexArrayOES(WebGLVertexArray arrayObject) {
			return false;
		}

		[IntrinsicProperty, ScriptName("VERTEX_ARRAY_BINDING_OES")]
		public int VERTEX_ARRAY_BINDING_OES {
			get {
				return 0;
			}
		}
	}
}
