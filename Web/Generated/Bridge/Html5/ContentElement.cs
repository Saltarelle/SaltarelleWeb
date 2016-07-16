using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLContentElement")]
	public partial class ContentElement : Element
	{
		internal extern ContentElement();

		public extern void AddEventListener(ContentElementEvents type, Action listener);

		public extern void AddEventListener(ContentElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ContentElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ContentElementEvents type, HtmlEventHandlerWithTarget<ContentElement> listener);

		public extern void AddEventListener(ContentElementEvents type, HtmlEventHandlerWithTarget<ContentElement> listener, bool capture);

		public extern void AddEventListener(ContentElementEvents type, IEventListener listener);

		public extern void AddEventListener(ContentElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ContentElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ContentElement> listener, bool capture);

		public extern XmlNodeList GetDistributedNodes();

		public extern void RemoveEventListener(ContentElementEvents type, Action listener);

		public extern void RemoveEventListener(ContentElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ContentElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ContentElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ContentElementEvents type, HtmlEventHandlerWithTarget<ContentElement> listener);

		public extern void RemoveEventListener(ContentElementEvents type, HtmlEventHandlerWithTarget<ContentElement> listener, bool capture);

		public extern void RemoveEventListener(ContentElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ContentElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ContentElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ContentElement> listener, bool capture);

		[FieldProperty]
		public extern string Select
		{
			get;
			set;
		}
	}
}
