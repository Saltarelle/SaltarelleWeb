using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMImplementation {
		internal DOMImplementation() {
		}

		public DocumentBase CreateDocument(string @namespace, string qualifiedName, DocumentType doctype) {
			return default(DocumentBase);
		}

		public DocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId) {
			return default(DocumentType);
		}

		public DocumentBase CreateHTMLDocument() {
			return default(DocumentBase);
		}

		public DocumentBase CreateHTMLDocument(string title) {
			return default(DocumentBase);
		}

		public bool HasFeature(string feature, string version) {
			return false;
		}
	}
}
