using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LEGEND'"), ScriptName("Element")]
	public partial class LegendElement : Element {
		internal LegendElement() {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public FormElement Form {
			get { return default(FormElement); }
		}
	}
}
