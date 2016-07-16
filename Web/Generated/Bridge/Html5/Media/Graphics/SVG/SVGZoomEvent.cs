namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGZoomEvent : UIEvent
	{
		internal SVGZoomEvent()
		{
		}

		[FieldProperty]
		public double NewScale
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public SVGPoint NewTranslate
		{
			get {
				return default(SVGPoint);
			}
		}

		[FieldProperty]
		public double PreviousScale
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public SVGPoint PreviousTranslate
		{
			get {
				return default(SVGPoint);
			}
		}
	}
}
