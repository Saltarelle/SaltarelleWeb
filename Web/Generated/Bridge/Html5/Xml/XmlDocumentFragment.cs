namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("DocumentFragment")]
	public partial class XmlDocumentFragment : XmlNode
	{
		public extern XmlDocumentFragment();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, Action listener);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, IEventListener listener);

		public extern void AddEventListener(XmlDocumentFragmentEvents type, IEventListener listener, bool capture);

		public readonly int ChildElementCount;

		public readonly XmlElementCollection Children;

		public readonly XmlElement FirstElementChild;

		public extern XmlElement GetElementById(string elementId);

		public readonly XmlElement LastElementChild;

		public extern XmlElement QuerySelector(string selectors);

		public extern XmlNodeList QuerySelectorAll(string selectors);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, Action listener);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, HtmlEventHandlerWithTarget<XmlDocumentFragment> listener, bool capture);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlDocumentFragmentEvents type, IEventListener listener, bool capture);
	}
}
