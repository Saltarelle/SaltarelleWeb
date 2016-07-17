namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FONT'"), Name("Element")]
	public partial class FontElement : Element
	{
		internal extern FontElement();

		public extern void AddEventListener(FontElementEvents type, Action listener);

		public extern void AddEventListener(FontElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FontElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FontElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FontElementEvents type, HtmlEventHandlerWithTarget<FontElement> listener);

		public extern void AddEventListener(FontElementEvents type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture);

		public extern void AddEventListener(FontElementEvents type, IEventListener listener);

		public extern void AddEventListener(FontElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture);

		public string Color;

		public string Face;

		public extern void RemoveEventListener(FontElementEvents type, Action listener);

		public extern void RemoveEventListener(FontElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FontElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FontElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FontElementEvents type, HtmlEventHandlerWithTarget<FontElement> listener);

		public extern void RemoveEventListener(FontElementEvents type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture);

		public extern void RemoveEventListener(FontElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FontElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FontElement> listener, bool capture);

		public string Size;
	}
}
