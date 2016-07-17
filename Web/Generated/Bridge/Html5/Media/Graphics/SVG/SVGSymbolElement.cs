namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace(false), External]
	public partial class SVGSymbolElement : SVGElement
	{
		internal extern SVGSymbolElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture);

		public extern void AddEventListener(SVGSymbolElementEvents type, Action listener);

		public extern void AddEventListener(SVGSymbolElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGSymbolElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGSymbolElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGSymbolElementEvents type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener);

		public extern void AddEventListener(SVGSymbolElementEvents type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture);

		public extern void AddEventListener(SVGSymbolElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGSymbolElementEvents type, IEventListener listener, bool capture);

		public extern bool HasExtension(string extension);

		public readonly SVGAnimatedPreserveAspectRatio PreserveAspectRatio;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, HtmlEventHandlerWithTarget<SVGSymbolElement> listener, bool capture);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGSymbolElementEvents type, IEventListener listener, bool capture);

		public readonly SVGStringList RequiredExtensions;

		public readonly SVGStringList RequiredFeatures;

		public readonly SVGStringList SystemLanguage;

		public readonly SVGAnimatedRect ViewBox;
	}
}
