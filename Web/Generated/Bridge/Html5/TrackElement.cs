using Bridge.Html5.Media;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class TrackElement : Element
	{
		internal extern TrackElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, Action listener);

		public extern void AddEventListener(TrackElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, IEventListener listener);

		public extern void AddEventListener(TrackElementEvents type, IEventListener listener, bool capture);

		public bool Default;

		public const ushort ERROR = 3;

		public string Kind;

		public string Label;

		public const ushort LOADED = 2;

		public const ushort LOADING = 1;

		public const ushort NONE = 0;

		public readonly ushort ReadyState;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, Action listener);

		public extern void RemoveEventListener(TrackElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TrackElementEvents type, IEventListener listener, bool capture);

		public string Src;

		public string Srclang;

		public readonly TextTrack Track;
	}
}
