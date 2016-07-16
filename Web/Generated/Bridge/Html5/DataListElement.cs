namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DATALIST'"), Name("Element")]
	public partial class DataListElement : Element
	{
		internal extern DataListElement();

		public extern void AddEventListener(DataListElementEvents type, Action listener);

		public extern void AddEventListener(DataListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(DataListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DataListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DataListElementEvents type, HtmlEventHandlerWithTarget<DataListElement> listener);

		public extern void AddEventListener(DataListElementEvents type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture);

		public extern void AddEventListener(DataListElementEvents type, IEventListener listener);

		public extern void AddEventListener(DataListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture);

		[FieldProperty]
		public extern ElementCollection Options
		{
			get;
		}

		public extern void RemoveEventListener(DataListElementEvents type, Action listener);

		public extern void RemoveEventListener(DataListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DataListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DataListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DataListElementEvents type, HtmlEventHandlerWithTarget<DataListElement> listener);

		public extern void RemoveEventListener(DataListElementEvents type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture);

		public extern void RemoveEventListener(DataListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(DataListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataListElement> listener, bool capture);
	}
}
