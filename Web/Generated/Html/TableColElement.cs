using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'COL' || {this}.tagName === 'COLGROUP')"), ScriptName("Element")]
	public partial class TableColElement : Element {
		internal TableColElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Ch {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string ChOff {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableColElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public uint Span {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string VAlign {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Width {
			get {
				return null;
			}
			set {
			}
		}
	}
}
