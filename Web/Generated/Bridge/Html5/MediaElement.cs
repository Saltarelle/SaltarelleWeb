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

		public bool Autoplay;

		public readonly TimeRanges Buffered;

		public extern MediaPlayability CanPlayType(string type);

		public bool Controls;

		public MediaCrossOriginPolicy CrossOrigin;

		public readonly string CurrentSrc;

		public double CurrentTime;

		public bool DefaultMuted;

		public double DefaultPlaybackRate;

		public readonly double Duration;

		public readonly bool Ended;

		public readonly MediaError Error;

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

		public bool Loop;

		public bool Muted;

		[Name("NETWORK_EMPTY")]
		public const ushort NETWORK_EMPTY = 0;

		[Name("NETWORK_IDLE")]
		public const ushort NETWORK_IDLE = 1;

		[Name("NETWORK_LOADING")]
		public const ushort NETWORK_LOADING = 2;

		[Name("NETWORK_NO_SOURCE")]
		public const ushort NETWORK_NO_SOURCE = 3;

		public readonly MediaElementNetworkState NetworkState;

		public extern void Pause();

		public readonly bool Paused;

		public extern void Play();

		public double PlaybackRate;

		public readonly TimeRanges Played;

		public MediaPreload Preload;

		public readonly MediaElementReadyState ReadyState;

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

		public readonly TimeRanges Seekable;

		public readonly bool Seeking;

		public string Src;

		public readonly TextTrackList TextTracks;

		public double Volume;
	}
}
