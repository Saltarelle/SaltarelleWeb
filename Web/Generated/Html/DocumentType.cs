using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DocumentType : XmlNode {
		internal DocumentType() {
		}

		public void AddEventListener(DocumentTypeEvents type, Action listener) {
		}

		public void AddEventListener(DocumentTypeEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(DocumentTypeEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(DocumentTypeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener) {
		}

		public void AddEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture) {
		}

		public void AddEventListener(DocumentTypeEvents type, IEventListener listener) {
		}

		public void AddEventListener(DocumentTypeEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture) {
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

		public void RemoveEventListener(DocumentTypeEvents type, Action listener) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(DocumentTypeEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string SystemId {
			get {
				return null;
			}
		}
	}
}
