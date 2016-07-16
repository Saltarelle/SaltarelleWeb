namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegLinetoRel : SVGPathSeg
	{
		internal extern SVGPathSegLinetoRel();

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Y
		{
			get;
			set;
		}
	}
}
