namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTimeElement : HTMLElement
	{
		internal extern HTMLTimeElement();

		public extern void AddEventListener(HTMLTimeElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTimeElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTimeElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTimeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTimeElementEvents type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener);

		public extern void AddEventListener(HTMLTimeElementEvents type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener, bool capture);

		public extern void AddEventListener(HTMLTimeElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTimeElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener, bool capture);

		public string DateTime;

		public extern void RemoveEventListener(HTMLTimeElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTimeElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTimeElement> listener, bool capture);
	}
}
