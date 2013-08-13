using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DocumentType : XmlNode {
		internal DocumentType() {
		}

		[IntrinsicProperty]
		public string InternalSubset {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public XmlElement NextElementSibling {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlElement PreviousElementSibling {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public string PublicId {
			get {
				return null;
			}
		}

		public void Remove() {
		}

		[IntrinsicProperty]
		public string SystemId {
			get {
				return null;
			}
		}
	}
}
