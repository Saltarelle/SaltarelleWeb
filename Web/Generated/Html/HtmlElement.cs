using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HTML'"), ScriptName("Element")]
	public partial class HtmlElement : Element {
		internal HtmlElement() {
		}

		[IntrinsicProperty]
		public string Version {
			get {
				return null;
			}
			set {
			}
		}
	}
}
