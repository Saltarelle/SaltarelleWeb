using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TR'"), ScriptName("Element")]
	public partial class TableRowElement : Element {
		internal TableRowElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture) {
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
		public string BgColor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public ElementCollection Cells {
			get {
				return default(ElementCollection);
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

		public void DeleteCell(int index) {
		}

		public Element InsertCell() {
			return default(Element);
		}

		public Element InsertCell(int index) {
			return default(Element);
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableRowElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int RowIndex {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int SectionRowIndex {
			get {
				return 0;
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
	}
}
