namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace(false), External, Name("IDBOpenDBRequest")]
	public partial class OpenDBRequest : Request
	{
		internal extern OpenDBRequest();

		public extern void AddEventListener(OpenDBRequestEvents type, Action listener);

		public extern void AddEventListener(OpenDBRequestEvents type, Action listener, bool capture);

		public extern void AddEventListener(OpenDBRequestEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OpenDBRequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OpenDBRequestEvents type, HtmlEventHandlerWithTarget<OpenDBRequest> listener);

		public extern void AddEventListener(OpenDBRequestEvents type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture);

		public extern void AddEventListener(OpenDBRequestEvents type, IEventListener listener);

		public extern void AddEventListener(OpenDBRequestEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture);

		[Name("onblocked")]
		public HtmlEventHandler OnBlocked;

		[Name("onupgradeneeded")]
		public HtmlEventHandler OnUpgradeneeded;

		public extern void RemoveEventListener(OpenDBRequestEvents type, Action listener);

		public extern void RemoveEventListener(OpenDBRequestEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OpenDBRequestEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OpenDBRequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OpenDBRequestEvents type, HtmlEventHandlerWithTarget<OpenDBRequest> listener);

		public extern void RemoveEventListener(OpenDBRequestEvents type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture);

		public extern void RemoveEventListener(OpenDBRequestEvents type, IEventListener listener);

		public extern void RemoveEventListener(OpenDBRequestEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OpenDBRequest> listener, bool capture);
	}
}
