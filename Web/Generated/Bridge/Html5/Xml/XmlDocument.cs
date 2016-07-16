namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("XMLDocument")]
	public partial class XmlDocument : DocumentBase
	{
		internal extern XmlDocument();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture);

		public extern void AddEventListener(XmlDocumentEvents type, Action listener);

		public extern void AddEventListener(XmlDocumentEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlDocumentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlDocumentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlDocumentEvents type, HtmlEventHandlerWithTarget<XmlDocument> listener);

		public extern void AddEventListener(XmlDocumentEvents type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture);

		public extern void AddEventListener(XmlDocumentEvents type, IEventListener listener);

		public extern void AddEventListener(XmlDocumentEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern bool Async
		{
			get;
			set;
		}

		public extern bool Load(string url);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentEvents type, Action listener);

		public extern void RemoveEventListener(XmlDocumentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlDocumentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentEvents type, HtmlEventHandlerWithTarget<XmlDocument> listener);

		public extern void RemoveEventListener(XmlDocumentEvents type, HtmlEventHandlerWithTarget<XmlDocument> listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlDocumentEvents type, IEventListener listener, bool capture);
	}
}
