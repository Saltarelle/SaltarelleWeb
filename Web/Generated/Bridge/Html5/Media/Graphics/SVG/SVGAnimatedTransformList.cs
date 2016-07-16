namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimatedTransformList
	{
		internal SVGAnimatedTransformList()
		{
		}

		[FieldProperty]
		public SVGTransformList AnimVal
		{
			get {
				return default(SVGTransformList);
			}
		}

		[FieldProperty]
		public SVGTransformList BaseVal
		{
			get {
				return default(SVGTransformList);
			}
		}
	}
}
