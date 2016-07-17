namespace Bridge.Html5.Media
{
	[Namespace("false"), External]
	public partial class TextTrack : EventTarget
	{
		internal extern TextTrack();

		public readonly TextTrackCueList ActiveCues;

		public extern void AddCue(VTTCue cue);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture);

		public extern void AddEventListener(TextTrackEvents type, Action listener);

		public extern void AddEventListener(TextTrackEvents type, Action listener, bool capture);

		public extern void AddEventListener(TextTrackEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener);

		public extern void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture);

		public extern void AddEventListener(TextTrackEvents type, IEventListener listener);

		public extern void AddEventListener(TextTrackEvents type, IEventListener listener, bool capture);

		public readonly TextTrackCueList Cues;

		public readonly string Id;

		public readonly string InBandMetadataTrackDispatchType;

		public readonly TextTrackKind Kind;

		public readonly string Label;

		public readonly string Language;

		public TextTrackMode Mode;

		[Name("oncuechange")]
		public HtmlEventHandler OnCuechange;

		public extern void RemoveCue(VTTCue cue);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture);

		public extern void RemoveEventListener(TextTrackEvents type, Action listener);

		public extern void RemoveEventListener(TextTrackEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener);

		public extern void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture);

		public extern void RemoveEventListener(TextTrackEvents type, IEventListener listener);

		public extern void RemoveEventListener(TextTrackEvents type, IEventListener listener, bool capture);
	}
}
