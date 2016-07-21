namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLEmbedElement : HTMLElement
	{
		internal extern HTMLEmbedElement();

		public extern void AddEventListener(HTMLEmbedElementEvents type, Action listener);

		public extern void AddEventListener(HTMLEmbedElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLEmbedElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLEmbedElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLEmbedElementEvents type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener);

		public extern void AddEventListener(HTMLEmbedElementEvents type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener, bool capture);

		public extern void AddEventListener(HTMLEmbedElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLEmbedElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener, bool capture);

		public string Align;

		[Template("{this}({*arguments})")]
		public extern object Call(params object[] arguments);

		public extern DocumentBase GetSVGDocument();

		public string Height;

		public string Name;

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLEmbedElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLEmbedElement> listener, bool capture);

		public string Src;

		public string Type;

		public string Width;
	}
}
