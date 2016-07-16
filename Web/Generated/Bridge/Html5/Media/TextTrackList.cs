using System.Collections.Generic;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrackList : EventTarget
	{
		internal TextTrackList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public TextTrack this[int index]
		{
			get {
				return default(TextTrack);
			}
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackListEvents type, Action listener)
		{
		}

		public void AddEventListener(TextTrackListEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener)
		{
		}

		public void AddEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackListEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(TextTrackListEvents type, IEventListener listener, bool capture)
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<TextTrack> GetEnumerator()
		{
			return null;
		}

		public TextTrack GetTrackById(string id)
		{
			return default(TextTrack);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty, Name("onaddtrack")]
		public HtmlEventHandler OnAddtrack
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchange")]
		public HtmlEventHandler OnChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onremovetrack")]
		public HtmlEventHandler OnRemovetrack
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, Action listener)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, HtmlEventHandlerWithTarget<TextTrackList> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(TextTrackListEvents type, IEventListener listener, bool capture)
		{
		}
	}
}
