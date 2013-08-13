using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TITLE'"), ScriptName("Element")]
	public partial class TitleElement : Element {
		internal TitleElement() {
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}
	}
}
