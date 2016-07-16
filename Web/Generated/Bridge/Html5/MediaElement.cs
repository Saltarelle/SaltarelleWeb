using Bridge.Html5.Media;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MEDIA'"), Name("Element")]
	public partial class MediaElement : Element
	{
		internal extern MediaElement();

		public extern void AddEventListener(MediaElementEvents type, Action listener);

		public extern void AddEventListener(MediaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MediaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener);

		public extern void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture);

		public extern void AddEventListener(MediaElementEvents type, IEventListener listener);

		public extern void AddEventListener(MediaElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture);

		public extern TextTrack AddTextTrack(TextTrackKind kind);

		public extern TextTrack AddTextTrack(TextTrackKind kind, string label);

		public extern TextTrack AddTextTrack(TextTrackKind kind, string label, string language);

		[FieldProperty]
		public extern bool Autoplay
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TimeRanges Buffered
		{
			get;
		}

		public extern MediaPlayability CanPlayType(string type);

		[FieldProperty]
		public extern bool Controls
		{
			get;
			set;
		}

		[FieldProperty]
		public extern MediaCrossOriginPolicy CrossOrigin
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CurrentSrc
		{
			get;
		}

		[FieldProperty]
		public extern double CurrentTime
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool DefaultMuted
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double DefaultPlaybackRate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Duration
		{
			get;
		}

		[FieldProperty]
		public extern bool Ended
		{
			get;
		}

		[FieldProperty]
		public extern MediaError Error
		{
			get;
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

		public extern void Load();

		[FieldProperty]
		public extern bool Loop
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Muted
		{
			get;
			set;
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
		public extern MediaElementNetworkState NetworkState
		{
			get;
		}

		public extern void Pause();

		[FieldProperty]
		public extern bool Paused
		{
			get;
		}

		public extern void Play();

		[FieldProperty]
		public extern double PlaybackRate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TimeRanges Played
		{
			get;
		}

		[FieldProperty]
		public extern MediaPreload Preload
		{
			get;
			set;
		}

		[FieldProperty]
		public extern MediaElementReadyState ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(MediaElementEvents type, Action listener);

		public extern void RemoveEventListener(MediaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener);

		public extern void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture);

		public extern void RemoveEventListener(MediaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MediaElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture);

		[FieldProperty]
		public extern TimeRanges Seekable
		{
			get;
		}

		[FieldProperty]
		public extern bool Seeking
		{
			get;
		}

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TextTrackList TextTracks
		{
			get;
		}

		[FieldProperty]
		public extern double Volume
		{
			get;
			set;
		}
	}
}
