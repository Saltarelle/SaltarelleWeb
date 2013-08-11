using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LABEL'"), ScriptName("Element")]
	public partial class LabelElement : Element {
		internal LabelElement() {
		}

		[IntrinsicProperty]
		public Element Control {
			get { return default(Element); }
		}

		[IntrinsicProperty]
		public FormElement Form {
			get { return default(FormElement); }
		}

		[IntrinsicProperty]
		public string HtmlFor {
			get { return null; }
			set { }
		}
	}
}
