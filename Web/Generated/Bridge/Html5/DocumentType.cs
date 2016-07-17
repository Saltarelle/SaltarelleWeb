using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DocumentType : XmlNode
	{
		internal extern DocumentType();

		public extern void AddEventListener(DocumentTypeEvents type, Action listener);

		public extern void AddEventListener(DocumentTypeEvents type, Action listener, bool capture);

		public extern void AddEventListener(DocumentTypeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DocumentTypeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener);

		public extern void AddEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture);

		public extern void AddEventListener(DocumentTypeEvents type, IEventListener listener);

		public extern void AddEventListener(DocumentTypeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture);

		public readonly string InternalSubset;

		public readonly string Name;

		public readonly string PublicId;

		public extern void Remove();

		public extern void RemoveEventListener(DocumentTypeEvents type, Action listener);

		public extern void RemoveEventListener(DocumentTypeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener);

		public extern void RemoveEventListener(DocumentTypeEvents type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture);

		public extern void RemoveEventListener(DocumentTypeEvents type, IEventListener listener);

		public extern void RemoveEventListener(DocumentTypeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentType> listener, bool capture);

		public readonly string SystemId;
	}
}
