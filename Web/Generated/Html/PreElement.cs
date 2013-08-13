using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PRE'"), ScriptName("Element")]
	public partial class PreElement : Element {
		internal PreElement() {
		}

		[IntrinsicProperty]
		public int Width {
			get {
				return 0;
			}
			set {
			}
		}
	}
}
