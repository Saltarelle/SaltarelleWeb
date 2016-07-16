namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPathSegLinetoVerticalAbs : SVGPathSeg
	{
		internal extern SVGPathSegLinetoVerticalAbs();

		[FieldProperty]
		public extern double Y
		{
			get;
			set;
		}
	}
}
