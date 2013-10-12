using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLFormControlsCollection")]
	public partial class FormControlsCollection : ElementCollection {
		internal FormControlsCollection() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public TypeOption<XmlNodeList, XmlElement> this[string name] {
			get {
				return default(TypeOption<XmlNodeList, XmlElement>);
			}
		}

		public TypeOption<XmlNodeList, XmlElement> NamedItem(string name) {
			return default(TypeOption<XmlNodeList, XmlElement>);
		}
	}
}
