using System.Html;
using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Media.Recording {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaRecorder : EventTarget {
		internal MediaRecorder() {
		}

		public MediaRecorder(MediaStream stream) {
		}

		public MediaRecorder(MediaStream stream, MediaRecorderOptions options) {
		}

		public void AddEventListener(MediaRecorderEvents type, Action listener) {
		}

		public void AddEventListener(MediaRecorderEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(MediaRecorderEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(MediaRecorderEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener) {
		}

		public void AddEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture) {
		}

		public void AddEventListener(MediaRecorderEvents type, IEventListener listener) {
		}

		public void AddEventListener(MediaRecorderEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string MimeType {
			get {
				return null;
			}
		}

		[IntrinsicProperty, ScriptName("ondataavailable")]
		public HtmlEventHandler OnDataavailable {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstop")]
		public HtmlEventHandler OnStop {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwarning")]
		public HtmlEventHandler OnWarning {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void Pause() {
		}

		public void RemoveEventListener(MediaRecorderEvents type, Action listener) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(MediaRecorderEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MediaRecorder> listener, bool capture) {
		}

		public void RequestData() {
		}

		public void Resume() {
		}

		public void Start() {
		}

		public void Start(int timeSlice) {
		}

		[IntrinsicProperty]
		public RecordingState State {
			get {
				return default(RecordingState);
			}
		}

		public void Stop() {
		}

		[IntrinsicProperty]
		public MediaStream Stream {
			get {
				return default(MediaStream);
			}
		}
	}
}
