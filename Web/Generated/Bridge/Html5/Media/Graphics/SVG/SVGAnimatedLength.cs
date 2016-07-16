namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedLength
	{
		internal extern SVGAnimatedLength();

		[FieldProperty]
		public extern SVGLength AnimVal
		{
			get;
		}

		[FieldProperty]
		public extern SVGLength BaseVal
		{
			get;
		}
	}
}
