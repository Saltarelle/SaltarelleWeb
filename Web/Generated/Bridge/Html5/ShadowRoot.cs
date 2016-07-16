using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ShadowRoot : XmlDocumentFragment
	{
		internal ShadowRoot()
		{
		}

		public void AddEventListener(ShadowRootEvents type, Action listener)
		{
		}

		public void AddEventListener(ShadowRootEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ShadowRootEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ShadowRootEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener)
		{
		}

		public void AddEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture)
		{
		}

		public void AddEventListener(ShadowRootEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ShadowRootEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool ApplyAuthorStyles
		{
			get {
				return false;
			}
			set {
			}
		}

		public Element GetElementById(string elementId)
		{
			return default(Element);
		}

		public ElementCollection GetElementsByClassName(string classNames)
		{
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagName(string localName)
		{
			return default(ElementCollection);
		}

		public ElementCollection GetElementsByTagNameNS(string @namespace, string localName)
		{
			return default(ElementCollection);
		}

		[FieldProperty]
		public string InnerHTML
		{
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(ShadowRootEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ShadowRootEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ShadowRoot> listener, bool capture)
		{
		}

		[FieldProperty]
		public StyleSheetList StyleSheets
		{
			get {
				return default(StyleSheetList);
			}
		}
	}
}
