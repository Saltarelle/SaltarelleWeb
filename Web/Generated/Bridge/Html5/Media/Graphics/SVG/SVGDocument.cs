using Bridge.Html5.Xml;

namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGDocument : DocumentBase
	{
		internal extern SVGDocument();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture);

		public extern void AddEventListener(SVGDocumentEvents type, Action listener);

		public extern void AddEventListener(SVGDocumentEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGDocumentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGDocumentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGDocumentEvents type, HtmlEventHandlerWithTarget<SVGDocument> listener);

		public extern void AddEventListener(SVGDocumentEvents type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture);

		public extern void AddEventListener(SVGDocumentEvents type, IEventListener listener);

		public extern void AddEventListener(SVGDocumentEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Domain
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture);

		public extern void RemoveEventListener(SVGDocumentEvents type, Action listener);

		public extern void RemoveEventListener(SVGDocumentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGDocumentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGDocumentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGDocumentEvents type, HtmlEventHandlerWithTarget<SVGDocument> listener);

		public extern void RemoveEventListener(SVGDocumentEvents type, HtmlEventHandlerWithTarget<SVGDocument> listener, bool capture);

		public extern void RemoveEventListener(SVGDocumentEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGDocumentEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGElement RootElement
		{
			get;
		}
	}
}
