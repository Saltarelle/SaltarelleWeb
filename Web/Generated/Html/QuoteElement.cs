using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'Q'"), ScriptName("Element")]
	public partial class QuoteElement : Element {
		internal QuoteElement() {
		}

		[IntrinsicProperty]
		public string Cite {
			get { return null; }
			set { }
		}
	}
}
