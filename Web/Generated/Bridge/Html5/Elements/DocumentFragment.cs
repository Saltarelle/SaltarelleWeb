using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External]
	public partial class DocumentFragment : Node
	{
		public extern DocumentFragment();

		public extern void AddEventListener(DocumentFragmentEvents type, Action listener);

		public extern void AddEventListener(DocumentFragmentEvents type, Action listener, bool capture);

		public extern void AddEventListener(DocumentFragmentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DocumentFragmentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DocumentFragmentEvents type, HtmlEventHandlerWithTarget<DocumentFragment> listener);

		public extern void AddEventListener(DocumentFragmentEvents type, HtmlEventHandlerWithTarget<DocumentFragment> listener, bool capture);

		public extern void AddEventListener(DocumentFragmentEvents type, IEventListener listener);

		public extern void AddEventListener(DocumentFragmentEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentFragment> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentFragment> listener, bool capture);

		public readonly int ChildElementCount;

		public readonly ElementCollection Children;

		public readonly Element FirstElementChild;

		public extern Element GetElementById(string elementId);

		public readonly Element LastElementChild;

		public extern Element QuerySelector(string selectors);

		public extern NodeList QuerySelectorAll(string selectors);

		public extern void RemoveEventListener(DocumentFragmentEvents type, Action listener);

		public extern void RemoveEventListener(DocumentFragmentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DocumentFragmentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DocumentFragmentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DocumentFragmentEvents type, HtmlEventHandlerWithTarget<DocumentFragment> listener);

		public extern void RemoveEventListener(DocumentFragmentEvents type, HtmlEventHandlerWithTarget<DocumentFragment> listener, bool capture);

		public extern void RemoveEventListener(DocumentFragmentEvents type, IEventListener listener);

		public extern void RemoveEventListener(DocumentFragmentEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentFragment> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentFragment> listener, bool capture);
	}
}
