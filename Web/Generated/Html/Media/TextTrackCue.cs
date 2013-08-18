using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html.Media {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TextTrackCue : EventTarget {
		internal TextTrackCue() {
		}

		public TextTrackCue(double startTime, double endTime, string text) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackCue> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TextTrackCue> listener, bool capture) {
		}

		public void AddEventListener(TextTrackCueEvents type, Action listener) {
		}

		public void AddEventListener(TextTrackCueEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(TextTrackCueEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(TextTrackCueEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(TextTrackCueEvents type, HtmlEventHandlerWithTarget<TextTrackCue> listener) {
		}

		public void AddEventListener(TextTrackCueEvents type, HtmlEventHandlerWithTarget<TextTrackCue> listener, bool capture) {
		}

		public void AddEventListener(TextTrackCueEvents type, IEventListener listener) {
		}

		public void AddEventListener(TextTrackCueEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public TextTrackCueAlign Align {
			get {
				return default(TextTrackCueAlign);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double EndTime {
			get {
				return 0;
			}
			set {
			}
		}

		public XmlDocumentFragment GetCueAsHTML() {
			return default(XmlDocumentFragment);
		}

		[IntrinsicProperty]
		public string Id {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onenter")]
		public HtmlEventHandler OnEnter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onexit")]
		public HtmlEventHandler OnExit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool PauseOnExit {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int Position {
			get {
				return 0;
			}
			set {
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackCue> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextTrackCue> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, Action listener) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, HtmlEventHandlerWithTarget<TextTrackCue> listener) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, HtmlEventHandlerWithTarget<TextTrackCue> listener, bool capture) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(TextTrackCueEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public int Size {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool SnapToLines {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double StartTime {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TextTrack Track {
			get {
				return default(TextTrack);
			}
		}

		[IntrinsicProperty]
		public string Vertical {
			get {
				return null;
			}
			set {
			}
		}
	}
}
