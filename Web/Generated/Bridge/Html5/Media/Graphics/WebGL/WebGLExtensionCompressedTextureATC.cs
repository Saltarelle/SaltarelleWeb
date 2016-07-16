namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionCompressedTextureATC
	{
		internal extern WebGLExtensionCompressedTextureATC();

		[FieldProperty, Name("COMPRESSED_RGB_ATC_WEBGL")]
		public extern int COMPRESSED_RGB_ATC_WEBGL
		{
			get;
		}

		[FieldProperty, Name("COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL")]
		public extern int COMPRESSED_RGBA_ATC_EXPLICIT_ALPHA_WEBGL
		{
			get;
		}

		[FieldProperty, Name("COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL")]
		public extern int COMPRESSED_RGBA_ATC_INTERPOLATED_ALPHA_WEBGL
		{
			get;
		}
	}
}
