namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrack : EventTarget
	{
		internal TextTrack()
		{
		}

		[FieldProperty]
		public TextTrackCueList ActiveCues
		{
			get {
				return default(TextTrackCueList);
			}
		}

		public void AddCue(VTTCue cue)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackEvents type, Action listener)
		{
		}

		public void AddEventListener(TextTrackEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener)
		{
		}

		public void AddEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture)
		{
		}

		public void AddEventListener(TextTrackEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(TextTrackEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public TextTrackCueList Cues
		{
			get {
				return default(TextTrackCueList);
			}
		}

		[FieldProperty]
		public string Id
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string InBandMetadataTrackDispatchType
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public TextTrackKind Kind
		{
			get {
				return default(TextTrackKind);
			}
		}

		[FieldProperty]
		public string Label
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Language
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public TextTrackMode Mode
		{
			get {
				return default(TextTrackMode);
			}
			set {
			}
		}

		[FieldProperty, Name("oncuechange")]
		public HtmlEventHandler OnCuechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveCue(VTTCue cue)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, Action listener)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, HtmlEventHandlerWithTarget<TextTrack> listener, bool capture)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(TextTrackEvents type, IEventListener listener, bool capture)
		{
		}
	}
}
