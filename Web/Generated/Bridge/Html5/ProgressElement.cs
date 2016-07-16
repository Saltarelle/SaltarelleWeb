namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PROGRESS'"), Name("Element")]
	public partial class ProgressElement : Element
	{
		internal extern ProgressElement();

		public extern void AddEventListener(ProgressElementEvents type, Action listener);

		public extern void AddEventListener(ProgressElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void AddEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public extern void AddEventListener(ProgressElementEvents type, IEventListener listener);

		public extern void AddEventListener(ProgressElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		[FieldProperty]
		public extern double Max
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Position
		{
			get;
		}

		public extern void RemoveEventListener(ProgressElementEvents type, Action listener);

		public extern void RemoveEventListener(ProgressElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void RemoveEventListener(ProgressElementEvents type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		public extern void RemoveEventListener(ProgressElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ProgressElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ProgressElement> listener, bool capture);

		[FieldProperty]
		public extern double Value
		{
			get;
			set;
		}
	}
}
