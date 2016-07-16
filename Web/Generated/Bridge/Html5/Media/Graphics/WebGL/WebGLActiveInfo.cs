namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WebGLActiveInfo
	{
		internal extern WebGLActiveInfo();

		[FieldProperty]
		public extern string Name
		{
			get;
		}

		[FieldProperty]
		public extern int Size
		{
			get;
		}

		[FieldProperty]
		public extern int Type
		{
			get;
		}
	}
}
