using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Attr")]
	public partial class XmlAttribute : XmlNode {
		internal XmlAttribute() {
		}

		[IntrinsicProperty]
		public string LocalName {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Name {
			get { return null; }
		}

		[IntrinsicProperty]
		public string NamespaceURI {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlElement OwnerElement {
			get { return default(XmlElement); }
		}

		[IntrinsicProperty]
		public string Prefix {
			get { return null; }
		}

		[IntrinsicProperty]
		public bool Specified {
			get { return false; }
		}

		[IntrinsicProperty]
		public string Value {
			get { return null; }
			set { }
		}
	}
}
