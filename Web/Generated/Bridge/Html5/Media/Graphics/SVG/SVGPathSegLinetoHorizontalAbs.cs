namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegLinetoHorizontalAbs : SVGPathSeg
	{
		internal extern SVGPathSegLinetoHorizontalAbs();

		[FieldProperty]
		public extern double X
		{
			get;
			set;
		}
	}
}
