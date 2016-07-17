namespace Bridge.Html5.Media
{
	[Namespace("false"), External]
	public partial class TextTrackList : EventTarget
	{
		internal extern TextTrackList();

		public extern TextTrack this[int index]
		{
			get;
		}

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture);

		public extern void AddEventListener(TextTrackListEvents type, Action listener);

		public extern void AddEventListener(TextTrackListEvents type, Action listener, bool capture);

		public extern void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener);

		public extern void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture);

		public extern void AddEventListener(TextTrackListEvents type, IEventListener listener);

		public extern void AddEventListener(TextTrackListEvents type, IEventListener listener, bool capture);

		public extern TextTrack GetTrackById(string id);

		public readonly int Length;

		[Name("onaddtrack")]
		public HtmlEventHandler OnAddtrack;

		[Name("onchange")]
		public HtmlEventHandler OnChange;

		[Name("onremovetrack")]
		public HtmlEventHandler OnRemovetrack;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture);

		public extern void RemoveEventListener(TextTrackListEvents type, Action listener);

		public extern void RemoveEventListener(TextTrackListEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener);

		public extern void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture);

		public extern void RemoveEventListener(TextTrackListEvents type, IEventListener listener);

		public extern void RemoveEventListener(TextTrackListEvents type, IEventListener listener, bool capture);
	}
}
