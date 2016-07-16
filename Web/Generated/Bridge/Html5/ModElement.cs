namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && ({this}.tagName === 'INS' || {this}.tagName === 'DEL')"), Name("Element")]
	public partial class ModElement : Element
	{
		internal extern ModElement();

		public extern void AddEventListener(ModElementEvents type, Action listener);

		public extern void AddEventListener(ModElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ModElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ModElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ModElementEvents type, HtmlEventHandlerWithTarget<ModElement> listener);

		public extern void AddEventListener(ModElementEvents type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture);

		public extern void AddEventListener(ModElementEvents type, IEventListener listener);

		public extern void AddEventListener(ModElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture);

		[FieldProperty]
		public extern string Cite
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string DateTime
		{
			get;
			set;
		}

		public extern void RemoveEventListener(ModElementEvents type, Action listener);

		public extern void RemoveEventListener(ModElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ModElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ModElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ModElementEvents type, HtmlEventHandlerWithTarget<ModElement> listener);

		public extern void RemoveEventListener(ModElementEvents type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture);

		public extern void RemoveEventListener(ModElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ModElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ModElement> listener, bool capture);
	}
}
