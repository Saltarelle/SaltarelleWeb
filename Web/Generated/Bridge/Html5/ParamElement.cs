namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class ParamElement : Element
	{
		internal extern ParamElement();

		public extern void AddEventListener(ParamElementEvents type, Action listener);

		public extern void AddEventListener(ParamElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ParamElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ParamElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ParamElementEvents type, HtmlEventHandlerWithTarget<ParamElement> listener);

		public extern void AddEventListener(ParamElementEvents type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture);

		public extern void AddEventListener(ParamElementEvents type, IEventListener listener);

		public extern void AddEventListener(ParamElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture);

		public string Name;

		public extern void RemoveEventListener(ParamElementEvents type, Action listener);

		public extern void RemoveEventListener(ParamElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ParamElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ParamElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ParamElementEvents type, HtmlEventHandlerWithTarget<ParamElement> listener);

		public extern void RemoveEventListener(ParamElementEvents type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture);

		public extern void RemoveEventListener(ParamElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ParamElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParamElement> listener, bool capture);

		public string Type;

		public string Value;

		public string ValueType;
	}
}
