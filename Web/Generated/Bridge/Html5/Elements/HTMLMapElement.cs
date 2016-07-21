using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLMapElement : HTMLElement
	{
		internal extern HTMLMapElement();

		public extern void AddEventListener(HTMLMapElementEvents type, Action listener);

		public extern void AddEventListener(HTMLMapElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLMapElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLMapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLMapElementEvents type, HtmlEventHandlerWithTarget<HTMLMapElement> listener);

		public extern void AddEventListener(HTMLMapElementEvents type, HtmlEventHandlerWithTarget<HTMLMapElement> listener, bool capture);

		public extern void AddEventListener(HTMLMapElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLMapElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMapElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLMapElement> listener, bool capture);

		public readonly HTMLCollection Areas;

		public string Name;

		public extern void RemoveEventListener(HTMLMapElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLMapElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLMapElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLMapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLMapElementEvents type, HtmlEventHandlerWithTarget<HTMLMapElement> listener);

		public extern void RemoveEventListener(HTMLMapElementEvents type, HtmlEventHandlerWithTarget<HTMLMapElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLMapElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLMapElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMapElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLMapElement> listener, bool capture);
	}
}
