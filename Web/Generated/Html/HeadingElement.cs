using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'H1' || {this}.tagName === 'H2' || {this}.tagName === 'H3' || {this}.tagName === 'H4' || {this}.tagName === 'H5' || {this}.tagName === 'H6')"), ScriptName("Element")]
	public partial class HeadingElement : Element {
		internal HeadingElement() {
		}

		[IntrinsicProperty]
		public string Align {
			get { return null; }
			set { }
		}
	}
}
