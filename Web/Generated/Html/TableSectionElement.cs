using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'THEAD' || {this}.tagName === 'TFOOT' || {this}.tagName === 'TBODY')"), ScriptName("Element")]
	public partial class TableSectionElement : Element {
		internal TableSectionElement() {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Ch {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string ChOff {
			get { return null; }
			set { }
		}

		public void DeleteRow(int index) {
		}

		public Element InsertRow() {
			return default(Element);
		}

		public Element InsertRow(int index) {
			return default(Element);
		}

		[IntrinsicProperty]
		public ElementCollection Rows {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public string VAlign {
			get { return null; }
			set { }
		}
	}
}
