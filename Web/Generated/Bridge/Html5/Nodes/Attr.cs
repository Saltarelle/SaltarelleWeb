namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class Attr : Node
	{
		internal extern Attr();

		public extern void AddEventListener(AttrEvents type, Action listener);

		public extern void AddEventListener(AttrEvents type, Action listener, bool capture);

		public extern void AddEventListener(AttrEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AttrEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AttrEvents type, HtmlEventHandlerWithTarget<Attr> listener);

		public extern void AddEventListener(AttrEvents type, HtmlEventHandlerWithTarget<Attr> listener, bool capture);

		public extern void AddEventListener(AttrEvents type, IEventListener listener);

		public extern void AddEventListener(AttrEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Attr> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Attr> listener, bool capture);

		public readonly string LocalName;

		public readonly string Name;

		public readonly string NamespaceURI;

		public readonly Node OwnerElement;

		public readonly string Prefix;

		public extern void RemoveEventListener(AttrEvents type, Action listener);

		public extern void RemoveEventListener(AttrEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AttrEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AttrEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AttrEvents type, HtmlEventHandlerWithTarget<Attr> listener);

		public extern void RemoveEventListener(AttrEvents type, HtmlEventHandlerWithTarget<Attr> listener, bool capture);

		public extern void RemoveEventListener(AttrEvents type, IEventListener listener);

		public extern void RemoveEventListener(AttrEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Attr> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Attr> listener, bool capture);

		public readonly bool Specified;

		public string Value;
	}
}
