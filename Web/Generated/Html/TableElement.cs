using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TABLE'"), ScriptName("Element")]
	public partial class TableElement : Element {
		internal TableElement() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture) {
		}

		public void AddEventListener(TableElementEvents type, Action listener) {
		}

		public void AddEventListener(TableElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(TableElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(TableElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener) {
		}

		public void AddEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture) {
		}

		public void AddEventListener(TableElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(TableElementEvents type, IEventListener listener, bool capture) {
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
		public string Border {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TableCaptionElement Caption {
			get {
				return default(TableCaptionElement);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CellPadding {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CellSpacing {
			get {
				return null;
			}
			set {
			}
		}

		public Element CreateCaption() {
			return default(Element);
		}

		public Element CreateTBody() {
			return default(Element);
		}

		public Element CreateTFoot() {
			return default(Element);
		}

		public Element CreateTHead() {
			return default(Element);
		}

		public void DeleteCaption() {
		}

		public void DeleteRow(int index) {
		}

		public void DeleteTFoot() {
		}

		public void DeleteTHead() {
		}

		[IntrinsicProperty]
		public string Frame {
			get {
				return null;
			}
			set {
			}
		}

		public Element InsertRow() {
			return default(Element);
		}

		public Element InsertRow(int index) {
			return default(Element);
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture) {
		}

		public void RemoveEventListener(TableElementEvents type, Action listener) {
		}

		public void RemoveEventListener(TableElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(TableElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(TableElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener) {
		}

		public void RemoveEventListener(TableElementEvents type, HtmlEventHandlerWithTarget<TableElement> listener, bool capture) {
		}

		public void RemoveEventListener(TableElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(TableElementEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public ElementCollection Rows {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public string Rules {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Summary {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public ElementCollection TBodies {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public TableSectionElement TFoot {
			get {
				return default(TableSectionElement);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public TableSectionElement THead {
			get {
				return default(TableSectionElement);
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
