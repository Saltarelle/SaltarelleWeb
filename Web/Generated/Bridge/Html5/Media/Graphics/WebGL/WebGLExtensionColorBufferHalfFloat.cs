namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionColorBufferHalfFloat
	{
		internal extern WebGLExtensionColorBufferHalfFloat();

		[FieldProperty, Name("FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT")]
		public extern int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT
		{
			get;
		}

		[FieldProperty, Name("RGB16F_EXT")]
		public extern int RGB16F_EXT
		{
			get;
		}

		[FieldProperty, Name("RGBA16F_EXT")]
		public extern int RGBA16F_EXT
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
