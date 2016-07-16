namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedString
	{
		internal extern SVGAnimatedString();

		[FieldProperty]
		public extern string AnimVal
		{
			get;
		}

		[FieldProperty]
		public extern string BaseVal
		{
			get;
			set;
		}
	}
}
