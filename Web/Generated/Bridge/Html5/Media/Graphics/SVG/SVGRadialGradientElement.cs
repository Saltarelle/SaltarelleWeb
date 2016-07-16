namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGRadialGradientElement : SVGGradientElement
	{
		internal extern SVGRadialGradientElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, Action listener);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener, bool capture);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGRadialGradientElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Cx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Cy
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Fx
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Fy
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength R
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, HtmlEventHandlerWithTarget<SVGRadialGradientElement> listener, bool capture);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGRadialGradientElementEvents type, IEventListener listener, bool capture);
	}
}
