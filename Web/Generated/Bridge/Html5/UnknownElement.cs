namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLUnknownElement")]
	public partial class UnknownElement : Element
	{
		internal extern UnknownElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture);

		public extern void AddEventListener(UnknownElementEvents type, Action listener);

		public extern void AddEventListener(UnknownElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(UnknownElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(UnknownElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(UnknownElementEvents type, HtmlEventHandlerWithTarget<UnknownElement> listener);

		public extern void AddEventListener(UnknownElementEvents type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture);

		public extern void AddEventListener(UnknownElementEvents type, IEventListener listener);

		public extern void AddEventListener(UnknownElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture);

		public extern void RemoveEventListener(UnknownElementEvents type, Action listener);

		public extern void RemoveEventListener(UnknownElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(UnknownElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(UnknownElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(UnknownElementEvents type, HtmlEventHandlerWithTarget<UnknownElement> listener);

		public extern void RemoveEventListener(UnknownElementEvents type, HtmlEventHandlerWithTarget<UnknownElement> listener, bool capture);

		public extern void RemoveEventListener(UnknownElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(UnknownElementEvents type, IEventListener listener, bool capture);
	}
}
