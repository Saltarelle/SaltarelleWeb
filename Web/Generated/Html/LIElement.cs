using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LI'"), ScriptName("Element")]
	public partial class LIElement : Element {
		internal LIElement() {
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int Value {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
