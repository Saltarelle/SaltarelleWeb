namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HR'"), Name("Element")]
	public partial class HRElement : Element
	{
		internal extern HRElement();

		public extern void AddEventListener(HRElementEvents type, Action listener);

		public extern void AddEventListener(HRElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HRElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HRElementEvents type, HtmlEventHandlerWithTarget<HRElement> listener);

		public extern void AddEventListener(HRElementEvents type, HtmlEventHandlerWithTarget<HRElement> listener, bool capture);

		public extern void AddEventListener(HRElementEvents type, IEventListener listener);

		public extern void AddEventListener(HRElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HRElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HRElement> listener, bool capture);

		public string Align;

		public string Color;

		public bool NoShade;

		public extern void RemoveEventListener(HRElementEvents type, Action listener);

		public extern void RemoveEventListener(HRElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HRElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HRElementEvents type, HtmlEventHandlerWithTarget<HRElement> listener);

		public extern void RemoveEventListener(HRElementEvents type, HtmlEventHandlerWithTarget<HRElement> listener, bool capture);

		public extern void RemoveEventListener(HRElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HRElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HRElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HRElement> listener, bool capture);

		public string Size;

		public string Width;
	}
}
