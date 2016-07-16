namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionInstancedArrays
	{
		internal WebGLExtensionInstancedArrays()
		{
		}

		public void DrawArraysInstancedANGLE(int mode, int first, int count, int primcount)
		{
		}

		public void DrawElementsInstancedANGLE(int mode, int count, int type, long offset, int primcount)
		{
		}

		[FieldProperty, Name("VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		public int VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE
		{
			get {
				return 0;
			}
		}

		public void VertexAttribDivisorANGLE(int index, int divisor)
		{
		}
	}
}
