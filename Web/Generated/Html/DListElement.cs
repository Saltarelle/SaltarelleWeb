using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DL'"), ScriptName("Element")]
	public partial class DListElement : Element {
		internal DListElement() {
		}

		[IntrinsicProperty]
		public bool Compact {
			get { return false; }
			set { }
		}
	}
}
