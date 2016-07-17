namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External]
	public partial class SVGPathElement : SVGGraphicsElement
	{
		internal extern SVGPathElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPathElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPathElement> listener, bool capture);

		public extern void AddEventListener(SVGPathElementEvents type, Action listener);

		public extern void AddEventListener(SVGPathElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGPathElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGPathElementEvents type, HtmlEventHandlerWithTarget<SVGPathElement> listener);

		public extern void AddEventListener(SVGPathElementEvents type, HtmlEventHandlerWithTarget<SVGPathElement> listener, bool capture);

		public extern void AddEventListener(SVGPathElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGPathElementEvents type, IEventListener listener, bool capture);

		public readonly SVGPathSegList AnimatedPathSegList;

		public extern SVGPathSegArcAbs CreateSVGPathSegArcAbs(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag);

		public extern SVGPathSegArcRel CreateSVGPathSegArcRel(double x, double y, double r1, double r2, double angle, bool largeArcFlag, bool sweepFlag);

		public extern SVGPathSegClosePath CreateSVGPathSegClosePath();

		public extern SVGPathSegCurvetoCubicAbs CreateSVGPathSegCurvetoCubicAbs(double x, double y, double x1, double y1, double x2, double y2);

		public extern SVGPathSegCurvetoCubicRel CreateSVGPathSegCurvetoCubicRel(double x, double y, double x1, double y1, double x2, double y2);

		public extern SVGPathSegCurvetoCubicSmoothAbs CreateSVGPathSegCurvetoCubicSmoothAbs(double x, double y, double x2, double y2);

		public extern SVGPathSegCurvetoCubicSmoothRel CreateSVGPathSegCurvetoCubicSmoothRel(double x, double y, double x2, double y2);

		public extern SVGPathSegCurvetoQuadraticAbs CreateSVGPathSegCurvetoQuadraticAbs(double x, double y, double x1, double y1);

		public extern SVGPathSegCurvetoQuadraticRel CreateSVGPathSegCurvetoQuadraticRel(double x, double y, double x1, double y1);

		public extern SVGPathSegCurvetoQuadraticSmoothAbs CreateSVGPathSegCurvetoQuadraticSmoothAbs(double x, double y);

		public extern SVGPathSegCurvetoQuadraticSmoothRel CreateSVGPathSegCurvetoQuadraticSmoothRel(double x, double y);

		public extern SVGPathSegLinetoAbs CreateSVGPathSegLinetoAbs(double x, double y);

		public extern SVGPathSegLinetoHorizontalAbs CreateSVGPathSegLinetoHorizontalAbs(double x);

		public extern SVGPathSegLinetoHorizontalRel CreateSVGPathSegLinetoHorizontalRel(double x);

		public extern SVGPathSegLinetoRel CreateSVGPathSegLinetoRel(double x, double y);

		public extern SVGPathSegLinetoVerticalAbs CreateSVGPathSegLinetoVerticalAbs(double y);

		public extern SVGPathSegLinetoVerticalRel CreateSVGPathSegLinetoVerticalRel(double y);

		public extern SVGPathSegMovetoAbs CreateSVGPathSegMovetoAbs(double x, double y);

		public extern SVGPathSegMovetoRel CreateSVGPathSegMovetoRel(double x, double y);

		public extern int GetPathSegAtLength(double distance);

		public extern SVGPoint GetPointAtLength(double distance);

		public extern double GetTotalLength();

		public readonly SVGAnimatedNumber PathLength;

		public readonly SVGPathSegList PathSegList;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPathElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPathElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGPathElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGPathElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGPathElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGPathElementEvents type, HtmlEventHandlerWithTarget<SVGPathElement> listener);

		public extern void RemoveEventListener(SVGPathElementEvents type, HtmlEventHandlerWithTarget<SVGPathElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPathElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGPathElementEvents type, IEventListener listener, bool capture);
	}
}
