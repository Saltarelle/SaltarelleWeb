namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLFontElement : HTMLElement
	{
		internal extern HTMLFontElement();

		public extern void AddEventListener(HTMLFontElementEvents type, Action listener);

		public extern void AddEventListener(HTMLFontElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLFontElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLFontElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLFontElementEvents type, HtmlEventHandlerWithTarget<HTMLFontElement> listener);

		public extern void AddEventListener(HTMLFontElementEvents type, HtmlEventHandlerWithTarget<HTMLFontElement> listener, bool capture);

		public extern void AddEventListener(HTMLFontElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLFontElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFontElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFontElement> listener, bool capture);

		public string Color;

		public string Face;

		public extern void RemoveEventListener(HTMLFontElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLFontElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLFontElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLFontElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLFontElementEvents type, HtmlEventHandlerWithTarget<HTMLFontElement> listener);

		public extern void RemoveEventListener(HTMLFontElementEvents type, HtmlEventHandlerWithTarget<HTMLFontElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLFontElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLFontElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFontElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFontElement> listener, bool capture);

		public string Size;
	}
}
