using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BR'"), ScriptName("Element")]
	public partial class BRElement : Element {
		internal BRElement() {
		}

		[IntrinsicProperty]
		public string Clear {
			get { return null; }
			set { }
		}
	}
}
