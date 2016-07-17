namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace(false), External, Name("Object")]
	public partial class WebGLExtensionInstancedArrays
	{
		internal extern WebGLExtensionInstancedArrays();

		public extern void DrawArraysInstancedANGLE(int mode, int first, int count, int primcount);

		public extern void DrawElementsInstancedANGLE(int mode, int count, int type, long offset, int primcount);

		[Name("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		public readonly int VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE;

		public extern void VertexAttribDivisorANGLE(int index, int divisor);
	}
}
