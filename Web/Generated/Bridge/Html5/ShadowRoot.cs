using Bridge.Html5.CSS;
using Bridge.Html5.Elements;
using Bridge.Html5.Nodes;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class ShadowRoot : DocumentFragment
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

		public bool ApplyAuthorStyles;

		public extern Element GetElementById(string elementId);

		public extern HTMLCollection GetElementsByClassName(string classNames);

		public extern HTMLCollection GetElementsByTagName(string localName);

		public extern HTMLCollection GetElementsByTagNameNS(string @namespace, string localName);

		public string InnerHTML;

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

		public readonly StyleSheetList StyleSheets;
	}
}
