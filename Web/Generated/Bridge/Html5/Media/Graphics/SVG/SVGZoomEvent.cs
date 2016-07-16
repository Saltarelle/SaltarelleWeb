namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGZoomEvent : UIEvent
	{
		internal extern SVGZoomEvent();

		[FieldProperty]
		public extern double NewScale
		{
			get;
		}

		[FieldProperty]
		public extern SVGPoint NewTranslate
		{
			get;
		}

		[FieldProperty]
		public extern double PreviousScale
		{
			get;
		}

		[FieldProperty]
		public extern SVGPoint PreviousTranslate
		{
			get;
		}
	}
}
