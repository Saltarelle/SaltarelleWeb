using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLFormControlsCollection")]
	public partial class FormControlsCollection : ElementCollection {
		internal FormControlsCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TypeOption<ElementNodeList, Element> this[string name] {
			get {
				return default(TypeOption<ElementNodeList, Element>);
			}
		}

		public TypeOption<ElementNodeList, Element> NamedItem(string name) {
			return default(TypeOption<ElementNodeList, Element>);
		}
	}
}
