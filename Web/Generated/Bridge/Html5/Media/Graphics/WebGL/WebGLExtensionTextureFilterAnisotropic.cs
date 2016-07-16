namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionTextureFilterAnisotropic
	{
		internal extern WebGLExtensionTextureFilterAnisotropic();

		[FieldProperty, Name("MAX_TEXTURE_MAX_ANISOTROPY_EXT")]
		public extern int MAX_TEXTURE_MAX_ANISOTROPY_EXT
		{
			get;
		}

		[FieldProperty, Name("TEXTURE_MAX_ANISOTROPY_EXT")]
		public extern int TEXTURE_MAX_ANISOTROPY_EXT
		{
			get;
		}
	}
}
