using Bridge.Html5.Media;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MEDIA'"), Name("Element")]
	public partial class MediaElement : Element
	{
		internal MediaElement()
		{
		}

		public void AddEventListener(MediaElementEvents type, Action listener)
		{
		}

		public void AddEventListener(MediaElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener)
		{
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture)
		{
		}

		public void AddEventListener(MediaElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(MediaElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture)
		{
		}

		public TextTrack AddTextTrack(TextTrackKind kind)
		{
			return default(TextTrack);
		}

		public TextTrack AddTextTrack(TextTrackKind kind, string label)
		{
			return default(TextTrack);
		}

		public TextTrack AddTextTrack(TextTrackKind kind, string label, string language)
		{
			return default(TextTrack);
		}

		[FieldProperty]
		public bool Autoplay
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public TimeRanges Buffered
		{
			get {
				return default(TimeRanges);
			}
		}

		public MediaPlayability CanPlayType(string type)
		{
			return default(MediaPlayability);
		}

		[FieldProperty]
		public bool Controls
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public MediaCrossOriginPolicy CrossOrigin
		{
			get {
				return default(MediaCrossOriginPolicy);
			}
			set {
			}
		}

		[FieldProperty]
		public string CurrentSrc
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public double CurrentTime
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool DefaultMuted
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public double DefaultPlaybackRate
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public double Duration
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public bool Ended
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public MediaError Error
		{
			get {
				return default(MediaError);
			}
		}

		[Name("HAVE_CURRENT_DATA")]
		public const ushort HAVE_CURRENT_DATA = 2;

		[Name("HAVE_ENOUGH_DATA")]
		public const ushort HAVE_ENOUGH_DATA = 4;

		[Name("HAVE_FUTURE_DATA")]
		public const ushort HAVE_FUTURE_DATA = 3;

		[Name("HAVE_METADATA")]
		public const ushort HAVE_METADATA = 1;

		[Name("HAVE_NOTHING")]
		public const ushort HAVE_NOTHING = 0;

		public void Load()
		{
		}

		[FieldProperty]
		public bool Loop
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Muted
		{
			get {
				return false;
			}
			set {
			}
		}

		[Name("NETWORK_EMPTY")]
		public const ushort NETWORK_EMPTY = 0;

		[Name("NETWORK_IDLE")]
		public const ushort NETWORK_IDLE = 1;

		[Name("NETWORK_LOADING")]
		public const ushort NETWORK_LOADING = 2;

		[Name("NETWORK_NO_SOURCE")]
		public const ushort NETWORK_NO_SOURCE = 3;

		[FieldProperty]
		public MediaElementNetworkState NetworkState
		{
			get {
				return default(MediaElementNetworkState);
			}
		}

		public void Pause()
		{
		}

		[FieldProperty]
		public bool Paused
		{
			get {
				return false;
			}
		}

		public void Play()
		{
		}

		[FieldProperty]
		public double PlaybackRate
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public TimeRanges Played
		{
			get {
				return default(TimeRanges);
			}
		}

		[FieldProperty]
		public MediaPreload Preload
		{
			get {
				return default(MediaPreload);
			}
			set {
			}
		}

		[FieldProperty]
		public MediaElementReadyState ReadyState
		{
			get {
				return default(MediaElementReadyState);
			}
		}

		public void RemoveEventListener(MediaElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(MediaElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public TimeRanges Seekable
		{
			get {
				return default(TimeRanges);
			}
		}

		[FieldProperty]
		public bool Seeking
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string Src
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public TextTrackList TextTracks
		{
			get {
				return default(TextTrackList);
			}
		}

		[FieldProperty]
		public double Volume
		{
			get {
				return 0;
			}
			set {
			}
		}
	}
}
