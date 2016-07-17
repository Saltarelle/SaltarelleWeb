namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External]
	public partial class SourceBufferList : EventTarget
	{
		internal extern SourceBufferList();

		public extern SourceBuffer this[int index]
		{
			get;
		}

		public extern void AddEventListener(SourceBufferListEvents type, Action listener);

		public extern void AddEventListener(SourceBufferListEvents type, Action listener, bool capture);

		public extern void AddEventListener(SourceBufferListEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SourceBufferListEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener);

		public extern void AddEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture);

		public extern void AddEventListener(SourceBufferListEvents type, IEventListener listener);

		public extern void AddEventListener(SourceBufferListEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture);

		public readonly int Length;

		public extern void RemoveEventListener(SourceBufferListEvents type, Action listener);

		public extern void RemoveEventListener(SourceBufferListEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener);

		public extern void RemoveEventListener(SourceBufferListEvents type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture);

		public extern void RemoveEventListener(SourceBufferListEvents type, IEventListener listener);

		public extern void RemoveEventListener(SourceBufferListEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBufferList> listener, bool capture);
	}
}
