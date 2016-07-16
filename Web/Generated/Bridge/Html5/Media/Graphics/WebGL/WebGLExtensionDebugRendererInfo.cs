namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionDebugRendererInfo
	{
		internal extern WebGLExtensionDebugRendererInfo();

		[FieldProperty, Name("UNMASKED_RENDERER_WEBGL")]
		public extern int UNMASKED_RENDERER_WEBGL
		{
			get;
		}

		[FieldProperty, Name("UNMASKED_VENDOR_WEBGL")]
		public extern int UNMASKED_VENDOR_WEBGL
		{
			get;
		}
	}
}
