namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DIR'"), Name("Element")]
	public partial class DirectoryElement : Element
	{
		internal extern DirectoryElement();

		public extern void AddEventListener(DirectoryElementEvents type, Action listener);

		public extern void AddEventListener(DirectoryElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(DirectoryElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DirectoryElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DirectoryElementEvents type, HtmlEventHandlerWithTarget<DirectoryElement> listener);

		public extern void AddEventListener(DirectoryElementEvents type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture);

		public extern void AddEventListener(DirectoryElementEvents type, IEventListener listener);

		public extern void AddEventListener(DirectoryElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture);

		public bool Compact;

		public extern void RemoveEventListener(DirectoryElementEvents type, Action listener);

		public extern void RemoveEventListener(DirectoryElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DirectoryElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DirectoryElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DirectoryElementEvents type, HtmlEventHandlerWithTarget<DirectoryElement> listener);

		public extern void RemoveEventListener(DirectoryElementEvents type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture);

		public extern void RemoveEventListener(DirectoryElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(DirectoryElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DirectoryElement> listener, bool capture);
	}
}
