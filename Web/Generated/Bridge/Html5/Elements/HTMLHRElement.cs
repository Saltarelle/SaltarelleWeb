namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLHRElement : HTMLElement
	{
		internal extern HTMLHRElement();

		public extern void AddEventListener(HTMLHRElementEvents type, Action listener);

		public extern void AddEventListener(HTMLHRElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLHRElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLHRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLHRElementEvents type, HtmlEventHandlerWithTarget<HTMLHRElement> listener);

		public extern void AddEventListener(HTMLHRElementEvents type, HtmlEventHandlerWithTarget<HTMLHRElement> listener, bool capture);

		public extern void AddEventListener(HTMLHRElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLHRElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHRElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLHRElement> listener, bool capture);

		public string Align;

		public string Color;

		public bool NoShade;

		public extern void RemoveEventListener(HTMLHRElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLHRElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLHRElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLHRElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLHRElementEvents type, HtmlEventHandlerWithTarget<HTMLHRElement> listener);

		public extern void RemoveEventListener(HTMLHRElementEvents type, HtmlEventHandlerWithTarget<HTMLHRElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLHRElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLHRElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHRElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLHRElement> listener, bool capture);

		public string Size;

		public string Width;
	}
}
