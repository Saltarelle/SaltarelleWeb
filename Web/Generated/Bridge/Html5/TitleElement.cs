namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class TitleElement : Element
	{
		internal extern TitleElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture);

		public extern void AddEventListener(TitleElementEvents type, Action listener);

		public extern void AddEventListener(TitleElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TitleElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TitleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TitleElementEvents type, HtmlEventHandlerWithTarget<TitleElement> listener);

		public extern void AddEventListener(TitleElementEvents type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture);

		public extern void AddEventListener(TitleElementEvents type, IEventListener listener);

		public extern void AddEventListener(TitleElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture);

		public extern void RemoveEventListener(TitleElementEvents type, Action listener);

		public extern void RemoveEventListener(TitleElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TitleElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TitleElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TitleElementEvents type, HtmlEventHandlerWithTarget<TitleElement> listener);

		public extern void RemoveEventListener(TitleElementEvents type, HtmlEventHandlerWithTarget<TitleElement> listener, bool capture);

		public extern void RemoveEventListener(TitleElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TitleElementEvents type, IEventListener listener, bool capture);

		public string Text;
	}
}
