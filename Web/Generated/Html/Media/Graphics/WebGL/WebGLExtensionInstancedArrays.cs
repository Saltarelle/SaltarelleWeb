using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class WebGLExtensionInstancedArrays {
		internal WebGLExtensionInstancedArrays() {
		}

		public void DrawArraysInstancedANGLE(uint mode, int first, int count, int primcount) {
		}

		public void DrawElementsInstancedANGLE(uint mode, int count, uint type, long offset, int primcount) {
		}

		[IntrinsicProperty, ScriptName("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		public uint VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE {
			get {
				return 0;
			}
		}

		public void VertexAttribDivisorANGLE(uint index, uint divisor) {
		}
	}
}
