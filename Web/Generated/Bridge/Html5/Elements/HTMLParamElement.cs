namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLParamElement : HTMLElement
	{
		internal extern HTMLParamElement();

		public extern void AddEventListener(HTMLParamElementEvents type, Action listener);

		public extern void AddEventListener(HTMLParamElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLParamElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLParamElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLParamElementEvents type, HtmlEventHandlerWithTarget<HTMLParamElement> listener);

		public extern void AddEventListener(HTMLParamElementEvents type, HtmlEventHandlerWithTarget<HTMLParamElement> listener, bool capture);

		public extern void AddEventListener(HTMLParamElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLParamElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLParamElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLParamElement> listener, bool capture);

		public string Name;

		public extern void RemoveEventListener(HTMLParamElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLParamElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLParamElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLParamElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLParamElementEvents type, HtmlEventHandlerWithTarget<HTMLParamElement> listener);

		public extern void RemoveEventListener(HTMLParamElementEvents type, HtmlEventHandlerWithTarget<HTMLParamElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLParamElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLParamElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLParamElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLParamElement> listener, bool capture);

		public string Type;

		public string Value;

		public string ValueType;
	}
}
