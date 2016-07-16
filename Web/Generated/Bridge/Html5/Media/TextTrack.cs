namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrack : EventTarget
	{
		internal extern TextTrack();

		[FieldProperty]
		public extern TextTrackCueList ActiveCues
		{
			get;
		}

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

		[FieldProperty]
		public extern TextTrackCueList Cues
		{
			get;
		}

		[FieldProperty]
		public extern string Id
		{
			get;
		}

		[FieldProperty]
		public extern string InBandMetadataTrackDispatchType
		{
			get;
		}

		[FieldProperty]
		public extern TextTrackKind Kind
		{
			get;
		}

		[FieldProperty]
		public extern string Label
		{
			get;
		}

		[FieldProperty]
		public extern string Language
		{
			get;
		}

		[FieldProperty]
		public extern TextTrackMode Mode
		{
			get;
			set;
		}

		[FieldProperty, Name("oncuechange")]
		public extern HtmlEventHandler OnCuechange
		{
			get;
			set;
		}

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
