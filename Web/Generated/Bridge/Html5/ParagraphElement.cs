namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'P'"), Name("Element")]
	public partial class ParagraphElement : Element
	{
		internal extern ParagraphElement();

		public extern void AddEventListener(ParagraphElementEvents type, Action listener);

		public extern void AddEventListener(ParagraphElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ParagraphElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ParagraphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ParagraphElementEvents type, HtmlEventHandlerWithTarget<ParagraphElement> listener);

		public extern void AddEventListener(ParagraphElementEvents type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture);

		public extern void AddEventListener(ParagraphElementEvents type, IEventListener listener);

		public extern void AddEventListener(ParagraphElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		public extern void RemoveEventListener(ParagraphElementEvents type, Action listener);

		public extern void RemoveEventListener(ParagraphElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ParagraphElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ParagraphElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ParagraphElementEvents type, HtmlEventHandlerWithTarget<ParagraphElement> listener);

		public extern void RemoveEventListener(ParagraphElementEvents type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture);

		public extern void RemoveEventListener(ParagraphElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ParagraphElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ParagraphElement> listener, bool capture);
	}
}
