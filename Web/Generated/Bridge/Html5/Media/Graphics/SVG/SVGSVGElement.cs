namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGSVGElement : SVGGraphicsElement
	{
		internal extern SVGSVGElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture);

		public extern void AddEventListener(SVGSVGElementEvents type, Action listener);

		public extern void AddEventListener(SVGSVGElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGSVGElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGSVGElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener);

		public extern void AddEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture);

		public extern void AddEventListener(SVGSVGElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGSVGElementEvents type, IEventListener listener, bool capture);

		public extern bool AnimationsPaused();

		public extern SVGAngle CreateSVGAngle();

		public extern SVGLength CreateSVGLength();

		public extern SVGMatrix CreateSVGMatrix();

		public extern SVGNumber CreateSVGNumber();

		public extern SVGPoint CreateSVGPoint();

		public extern SVGRect CreateSVGRect();

		public extern SVGTransform CreateSVGTransform();

		public extern SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix);

		[FieldProperty]
		public extern double CurrentScale
		{
			get;
			set;
		}

		[FieldProperty]
		public extern SVGPoint CurrentTranslate
		{
			get;
		}

		public extern void DeselectAll();

		public extern void ForceRedraw();

		public extern double GetCurrentTime();

		public extern Element GetElementById(string elementId);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		public extern void PauseAnimations();

		[FieldProperty]
		public extern double PixelUnitToMillimeterX
		{
			get;
		}

		[FieldProperty]
		public extern double PixelUnitToMillimeterY
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedPreserveAspectRatio PreserveAspectRatio
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSVGElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGSVGElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener);

		public extern void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSVGElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGSVGElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern double ScreenPixelToMillimeterX
		{
			get;
		}

		[FieldProperty]
		public extern double ScreenPixelToMillimeterY
		{
			get;
		}

		public extern void SetCurrentTime(double seconds);

		public extern int SuspendRedraw(int maxWaitMilliseconds);

		[Name("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[Name("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[Name("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		public extern void UnpauseAnimations();

		public extern void UnsuspendRedraw(int suspendHandleID);

		public extern void UnsuspendRedrawAll();

		[FieldProperty]
		public extern bool UseCurrentView
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedRect ViewBox
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Width
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y
		{
			get;
		}

		[FieldProperty]
		public extern SVGZoomAndPanType ZoomAndPan
		{
			get;
			set;
		}
	}
}
