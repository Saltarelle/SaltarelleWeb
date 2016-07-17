namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGZoomEvent : UIEvent
	{
		internal extern SVGZoomEvent();

		public readonly double NewScale;

		public readonly SVGPoint NewTranslate;

		public readonly double PreviousScale;

		public readonly SVGPoint PreviousTranslate;
	}
}
