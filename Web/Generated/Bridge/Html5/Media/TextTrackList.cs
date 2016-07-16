using System.Collections.Generic;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrackList : EventTarget
	{
		internal extern TextTrackList();

		[IndexerName("__Item"), FieldProperty]
		public TextTrack this[int index]
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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<TextTrack> GetEnumerator();

		public extern TextTrack GetTrackById(string id);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty, Name("onaddtrack")]
		public extern HtmlEventHandler OnAddtrack
		{
			get;
			set;
		}

		[FieldProperty, Name("onchange")]
		public extern HtmlEventHandler OnChange
		{
			get;
			set;
		}

		[FieldProperty, Name("onremovetrack")]
		public extern HtmlEventHandler OnRemovetrack
		{
			get;
			set;
		}

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
