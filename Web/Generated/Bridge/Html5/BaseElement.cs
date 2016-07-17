namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BASE'"), Name("Element")]
	public partial class BaseElement : Element
	{
		internal extern BaseElement();

		public extern void AddEventListener(BaseElementEvents type, Action listener);

		public extern void AddEventListener(BaseElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(BaseElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(BaseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(BaseElementEvents type, HtmlEventHandlerWithTarget<BaseElement> listener);

		public extern void AddEventListener(BaseElementEvents type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture);

		public extern void AddEventListener(BaseElementEvents type, IEventListener listener);

		public extern void AddEventListener(BaseElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture);

		public string Href;

		public extern void RemoveEventListener(BaseElementEvents type, Action listener);

		public extern void RemoveEventListener(BaseElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(BaseElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(BaseElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(BaseElementEvents type, HtmlEventHandlerWithTarget<BaseElement> listener);

		public extern void RemoveEventListener(BaseElementEvents type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture);

		public extern void RemoveEventListener(BaseElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(BaseElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<BaseElement> listener, bool capture);

		public string Target;
	}
}
