using Bridge.Html5.Media;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLTrackElement : HTMLElement
	{
		internal extern HTMLTrackElement();

		public extern void AddEventListener(HTMLTrackElementEvents type, Action listener);

		public extern void AddEventListener(HTMLTrackElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLTrackElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLTrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLTrackElementEvents type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener);

		public extern void AddEventListener(HTMLTrackElementEvents type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener, bool capture);

		public extern void AddEventListener(HTMLTrackElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLTrackElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener, bool capture);

		public bool Default;

		public const ushort ERROR = 3;

		public string Kind;

		public string Label;

		public const ushort LOADED = 2;

		public const ushort LOADING = 1;

		public const ushort NONE = 0;

		public readonly ushort ReadyState;

		public extern void RemoveEventListener(HTMLTrackElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLTrackElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLTrackElement> listener, bool capture);

		public string Src;

		public string Srclang;

		public readonly TextTrack Track;
	}
}
