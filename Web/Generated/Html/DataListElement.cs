using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DATALIST'"), ScriptName("Element")]
	public partial class DataListElement : Element {
		internal DataListElement() {
		}

		[IntrinsicProperty]
		public ElementCollection Options {
			get { return default(ElementCollection); }
		}
	}
}
