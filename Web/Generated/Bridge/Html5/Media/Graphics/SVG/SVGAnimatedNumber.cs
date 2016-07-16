namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedNumber
	{
		internal extern SVGAnimatedNumber();

		[FieldProperty]
		public extern double AnimVal
		{
			get;
		}

		[FieldProperty]
		public extern double BaseVal
		{
			get;
			set;
		}
	}
}
