namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedInteger
	{
		internal extern SVGAnimatedInteger();

		[FieldProperty]
		public extern int AnimVal
		{
			get;
		}

		[FieldProperty]
		public extern int BaseVal
		{
			get;
			set;
		}
	}
}
