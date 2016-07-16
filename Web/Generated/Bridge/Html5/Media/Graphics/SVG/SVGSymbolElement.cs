namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
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

		[FieldProperty]
		public extern SVGAnimatedPreserveAspectRatio PreserveAspectRatio
		{
			get;
		}

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

		[FieldProperty]
		public extern SVGStringList RequiredExtensions
		{
			get;
		}

		[FieldProperty]
		public extern SVGStringList RequiredFeatures
		{
			get;
		}

		[FieldProperty]
		public extern SVGStringList SystemLanguage
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedRect ViewBox
		{
			get;
		}
	}
}
