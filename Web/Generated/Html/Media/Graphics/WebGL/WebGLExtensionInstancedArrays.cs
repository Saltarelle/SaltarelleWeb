using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class WebGLExtensionInstancedArrays {
		internal WebGLExtensionInstancedArrays() {
		}

		public void DrawArraysInstancedANGLE(int mode, int first, int count, int primcount) {
		}

		public void DrawElementsInstancedANGLE(int mode, int count, int type, long offset, int primcount) {
		}

		[IntrinsicProperty, ScriptName("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		public int VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE {
			get {
				return 0;
			}
		}

		public void VertexAttribDivisorANGLE(int index, int divisor) {
		}
	}
}
