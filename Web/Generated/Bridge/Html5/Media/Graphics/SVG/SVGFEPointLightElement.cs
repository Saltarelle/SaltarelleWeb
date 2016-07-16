namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEPointLightElement : SVGElement
	{
		internal extern SVGFEPointLightElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener, bool capture);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener, bool capture);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEPointLightElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, HtmlEventHandlerWithTarget<SVGFEPointLightElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEPointLightElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Y
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Z
		{
			get;
		}
	}
}
