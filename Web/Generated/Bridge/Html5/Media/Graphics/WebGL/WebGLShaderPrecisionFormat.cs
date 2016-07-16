namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WebGLShaderPrecisionFormat
	{
		internal extern WebGLShaderPrecisionFormat();

		[FieldProperty]
		public extern int Precision
		{
			get;
		}

		[FieldProperty]
		public extern int RangeMax
		{
			get;
		}

		[FieldProperty]
		public extern int RangeMin
		{
			get;
		}
	}
}
