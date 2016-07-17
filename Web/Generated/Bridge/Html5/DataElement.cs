namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class DataElement : Element
	{
		internal extern DataElement();

		public extern void AddEventListener(DataElementEvents type, Action listener);

		public extern void AddEventListener(DataElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(DataElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DataElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DataElementEvents type, HtmlEventHandlerWithTarget<DataElement> listener);

		public extern void AddEventListener(DataElementEvents type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture);

		public extern void AddEventListener(DataElementEvents type, IEventListener listener);

		public extern void AddEventListener(DataElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture);

		public extern void RemoveEventListener(DataElementEvents type, Action listener);

		public extern void RemoveEventListener(DataElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DataElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DataElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DataElementEvents type, HtmlEventHandlerWithTarget<DataElement> listener);

		public extern void RemoveEventListener(DataElementEvents type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture);

		public extern void RemoveEventListener(DataElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(DataElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DataElement> listener, bool capture);

		public string Value;
	}
}
