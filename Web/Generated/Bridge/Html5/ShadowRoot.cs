using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ShadowRoot : XmlDocumentFragment
	{
		internal extern ShadowRoot();

		public extern void AddEventListener(ShadowRootEvents type, Action listener);

		public extern void AddEventListener(ShadowRootEvents type, Action listener, bool capture);

		public extern void AddEventListener(ShadowRootEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ShadowRootEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener);

		public extern void AddEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture);

		public extern void AddEventListener(ShadowRootEvents type, IEventListener listener);

		public extern void AddEventListener(ShadowRootEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture);

		[FieldProperty]
		public extern bool ApplyAuthorStyles
		{
			get;
			set;
		}

		public extern Element GetElementById(string elementId);

		public extern ElementCollection GetElementsByClassName(string classNames);

		public extern ElementCollection GetElementsByTagName(string localName);

		public extern ElementCollection GetElementsByTagNameNS(string @namespace, string localName);

		[FieldProperty]
		public extern string InnerHTML
		{
			get;
			set;
		}

		public extern void RemoveEventListener(ShadowRootEvents type, Action listener);

		public extern void RemoveEventListener(ShadowRootEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ShadowRootEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ShadowRootEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener);

		public extern void RemoveEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture);

		public extern void RemoveEventListener(ShadowRootEvents type, IEventListener listener);

		public extern void RemoveEventListener(ShadowRootEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture);

		[FieldProperty]
		public extern StyleSheetList StyleSheets
		{
			get;
		}
	}
}
