using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DOMImplementation
	{
		internal extern DOMImplementation();

		public extern DocumentBase CreateDocument(string @namespace, string qualifiedName);

		public extern DocumentBase CreateDocument(string @namespace, string qualifiedName, DocumentType doctype);

		public extern DocumentType CreateDocumentType(string qualifiedName, string publicId, string systemId);

		public extern DocumentBase CreateHTMLDocument();

		public extern DocumentBase CreateHTMLDocument(string title);

		public extern bool HasFeature(string feature, string version);
	}
}
