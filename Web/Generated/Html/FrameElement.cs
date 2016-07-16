using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FRAME'"), ScriptName("Element")]
	public partial class FrameElement : Element {
		internal FrameElement() {
		}

		public void AddEventListener(FrameElementEvents type, Action listener) {
		}

		public void AddEventListener(FrameElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener) {
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture) {
		}

		public void AddEventListener(FrameElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(FrameElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public DocumentBase ContentDocument {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public WindowInstance ContentWindow {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public string FrameBorder {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string LongDesc {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string MarginHeight {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string MarginWidth {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool NoResize {
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(FrameElementEvents type, Action listener) {
		}

		public void RemoveEventListener(FrameElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener) {
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture) {
		}

		public void RemoveEventListener(FrameElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(FrameElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Scrolling {
			get {
				return null;
			}
			set {
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
	}
}
