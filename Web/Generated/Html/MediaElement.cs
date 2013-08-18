using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MEDIA'"), ScriptName("Element")]
	public partial class MediaElement : Element {
		internal MediaElement() {
		}

		public void AddEventListener(MediaElementEvents type, Action listener) {
		}

		public void AddEventListener(MediaElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener) {
		}

		public void AddEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture) {
		}

		public void AddEventListener(MediaElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(MediaElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture) {
		}

		public TextTrack AddTextTrack(TextTrackKind kind) {
			return default(TextTrack);
		}

		public TextTrack AddTextTrack(TextTrackKind kind, string label) {
			return default(TextTrack);
		}

		public TextTrack AddTextTrack(TextTrackKind kind, string label, string language) {
			return default(TextTrack);
		}

		[IntrinsicProperty]
		public bool Autoplay {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TimeRanges Buffered {
			get {
				return default(TimeRanges);
			}
		}

		public MediaPlayability CanPlayType(string type) {
			return default(MediaPlayability);
		}

		[IntrinsicProperty]
		public bool Controls {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public MediaCrossOriginPolicy CrossOrigin {
			get {
				return default(MediaCrossOriginPolicy);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CurrentSrc {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public double CurrentTime {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool DefaultMuted {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double DefaultPlaybackRate {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double Duration {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public bool Ended {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public MediaError Error {
			get {
				return default(MediaError);
			}
		}

		[ScriptName("HAVE_CURRENT_DATA")]
		public const ushort HAVE_CURRENT_DATA = 2;

		[ScriptName("HAVE_ENOUGH_DATA")]
		public const ushort HAVE_ENOUGH_DATA = 4;

		[ScriptName("HAVE_FUTURE_DATA")]
		public const ushort HAVE_FUTURE_DATA = 3;

		[ScriptName("HAVE_METADATA")]
		public const ushort HAVE_METADATA = 1;

		[ScriptName("HAVE_NOTHING")]
		public const ushort HAVE_NOTHING = 0;

		public void Load() {
		}

		[IntrinsicProperty]
		public bool Loop {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Muted {
			get {
				return false;
			}
			set {
			}
		}

		[ScriptName("NETWORK_EMPTY")]
		public const ushort NETWORK_EMPTY = 0;

		[ScriptName("NETWORK_IDLE")]
		public const ushort NETWORK_IDLE = 1;

		[ScriptName("NETWORK_LOADING")]
		public const ushort NETWORK_LOADING = 2;

		[ScriptName("NETWORK_NO_SOURCE")]
		public const ushort NETWORK_NO_SOURCE = 3;

		[IntrinsicProperty]
		public MediaElementNetworkState NetworkState {
			get {
				return default(MediaElementNetworkState);
			}
		}

		public void Pause() {
		}

		[IntrinsicProperty]
		public bool Paused {
			get {
				return false;
			}
		}

		public void Play() {
		}

		[IntrinsicProperty]
		public double PlaybackRate {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TimeRanges Played {
			get {
				return default(TimeRanges);
			}
		}

		[IntrinsicProperty]
		public MediaPreload Preload {
			get {
				return default(MediaPreload);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public MediaElementReadyState ReadyState {
			get {
				return default(MediaElementReadyState);
			}
		}

		public void RemoveEventListener(MediaElementEvents type, Action listener) {
		}

		public void RemoveEventListener(MediaElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener) {
		}

		public void RemoveEventListener(MediaElementEvents type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture) {
		}

		public void RemoveEventListener(MediaElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(MediaElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public TimeRanges Seekable {
			get {
				return default(TimeRanges);
			}
		}

		[IntrinsicProperty]
		public bool Seeking {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Src {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TextTrackList TextTracks {
			get {
				return default(TextTrackList);
			}
		}

		[IntrinsicProperty]
		public double Volume {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
