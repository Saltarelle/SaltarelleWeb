namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionColorBufferFloat
	{
		internal extern WebGLExtensionColorBufferFloat();

		[FieldProperty, Name("FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
		public extern int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT
		{
			get;
		}

		[FieldProperty, Name("RGB32F_EXT")]
		public extern int RGB32F_EXT
		{
			get;
		}

		[FieldProperty, Name("RGBA32F_EXT")]
		public extern int RGBA32F_EXT
		{
			get;
		}

		[FieldProperty, Name("UNSIGNED_NORMALIZED_EXT")]
		public extern int UNSIGNED_NORMALIZED_EXT
		{
			get;
		}
	}
}
