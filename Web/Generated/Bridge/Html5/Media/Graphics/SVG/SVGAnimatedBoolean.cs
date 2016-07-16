namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedBoolean
	{
		internal extern SVGAnimatedBoolean();

		[FieldProperty]
		public extern bool AnimVal
		{
			get;
		}

		[FieldProperty]
		public extern bool BaseVal
		{
			get;
			set;
		}
	}
}
