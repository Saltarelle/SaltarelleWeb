namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGSVGElement : SVGGraphicsElement
	{
		internal SVGSVGElement()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, Action listener)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(SVGSVGElementEvents type, IEventListener listener, bool capture)
		{
		}

		public bool AnimationsPaused()
		{
			return false;
		}

		public SVGAngle CreateSVGAngle()
		{
			return default(SVGAngle);
		}

		public SVGLength CreateSVGLength()
		{
			return default(SVGLength);
		}

		public SVGMatrix CreateSVGMatrix()
		{
			return default(SVGMatrix);
		}

		public SVGNumber CreateSVGNumber()
		{
			return default(SVGNumber);
		}

		public SVGPoint CreateSVGPoint()
		{
			return default(SVGPoint);
		}

		public SVGRect CreateSVGRect()
		{
			return default(SVGRect);
		}

		public SVGTransform CreateSVGTransform()
		{
			return default(SVGTransform);
		}

		public SVGTransform CreateSVGTransformFromMatrix(SVGMatrix matrix)
		{
			return default(SVGTransform);
		}

		[FieldProperty]
		public double CurrentScale
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public SVGPoint CurrentTranslate
		{
			get {
				return default(SVGPoint);
			}
		}

		public void DeselectAll()
		{
		}

		public void ForceRedraw()
		{
		}

		public double GetCurrentTime()
		{
			return 0;
		}

		public Element GetElementById(string elementId)
		{
			return default(Element);
		}

		[FieldProperty]
		public SVGAnimatedLength Height
		{
			get {
				return default(SVGAnimatedLength);
			}
		}

		public void PauseAnimations()
		{
		}

		[FieldProperty]
		public double PixelUnitToMillimeterX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double PixelUnitToMillimeterY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public SVGAnimatedPreserveAspectRatio PreserveAspectRatio
		{
			get {
				return default(SVGAnimatedPreserveAspectRatio);
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, HtmlEventHandlerWithTarget<SVGSVGElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(SVGSVGElementEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public double ScreenPixelToMillimeterX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public double ScreenPixelToMillimeterY
		{
			get {
				return 0;
			}
		}

		public void SetCurrentTime(double seconds)
		{
		}

		public int SuspendRedraw(int maxWaitMilliseconds)
		{
			return 0;
		}

		[Name("SVG_ZOOMANDPAN_DISABLE")]
		public const ushort SVG_ZOOMANDPAN_DISABLE = 1;

		[Name("SVG_ZOOMANDPAN_MAGNIFY")]
		public const ushort SVG_ZOOMANDPAN_MAGNIFY = 2;

		[Name("SVG_ZOOMANDPAN_UNKNOWN")]
		public const ushort SVG_ZOOMANDPAN_UNKNOWN = 0;

		public void UnpauseAnimations()
		{
		}

		public void UnsuspendRedraw(int suspendHandleID)
		{
		}

		public void UnsuspendRedrawAll()
		{
		}

		[FieldProperty]
		public bool UseCurrentView
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public SVGAnimatedRect ViewBox
		{
			get {
				return default(SVGAnimatedRect);
			}
		}

		[FieldProperty]
		public SVGAnimatedLength Width
		{
			get {
				return default(SVGAnimatedLength);
			}
		}

		[FieldProperty]
		public SVGAnimatedLength X
		{
			get {
				return default(SVGAnimatedLength);
			}
		}

		[FieldProperty]
		public SVGAnimatedLength Y
		{
			get {
				return default(SVGAnimatedLength);
			}
		}

		[FieldProperty]
		public SVGZoomAndPanType ZoomAndPan
		{
			get {
				return default(SVGZoomAndPanType);
			}
			set {
			}
		}
	}
}
