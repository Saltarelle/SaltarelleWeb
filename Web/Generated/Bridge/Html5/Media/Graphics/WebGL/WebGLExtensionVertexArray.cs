namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionVertexArray
	{
		internal WebGLExtensionVertexArray()
		{
		}

		public void BindVertexArrayOES(WebGLVertexArray arrayObject)
		{
		}

		public WebGLVertexArray CreateVertexArrayOES()
		{
			return default(WebGLVertexArray);
		}

		public void DeleteVertexArrayOES(WebGLVertexArray arrayObject)
		{
		}

		public bool IsVertexArrayOES(WebGLVertexArray arrayObject)
		{
			return false;
		}

		[FieldProperty, Name("VERTEX_ARRAY_BINDING_OES")]
		public int VERTEX_ARRAY_BINDING_OES
		{
			get {
				return 0;
			}
		}
	}
}
