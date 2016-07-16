namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionInstancedArrays
	{
		internal extern WebGLExtensionInstancedArrays();

		public extern void DrawArraysInstancedANGLE(int mode, int first, int count, int primcount);

		public extern void DrawElementsInstancedANGLE(int mode, int count, int type, long offset, int primcount);

		[FieldProperty, Name("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		public extern int VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE
		{
			get;
		}

		public extern void VertexAttribDivisorANGLE(int index, int divisor);
	}
}
