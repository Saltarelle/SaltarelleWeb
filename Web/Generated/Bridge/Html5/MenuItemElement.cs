namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class MenuItemElement : Element
	{
		internal extern MenuItemElement();

		public extern void AddEventListener(MenuItemElementEvents type, Action listener);

		public extern void AddEventListener(MenuItemElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MenuItemElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MenuItemElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MenuItemElementEvents type, HtmlEventHandlerWithTarget<MenuItemElement> listener);

		public extern void AddEventListener(MenuItemElementEvents type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture);

		public extern void AddEventListener(MenuItemElementEvents type, IEventListener listener);

		public extern void AddEventListener(MenuItemElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture);

		public bool Checked;

		public bool DefaultChecked;

		public bool Disabled;

		public string Icon;

		public string Label;

		public string Radiogroup;

		public extern void RemoveEventListener(MenuItemElementEvents type, Action listener);

		public extern void RemoveEventListener(MenuItemElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MenuItemElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MenuItemElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MenuItemElementEvents type, HtmlEventHandlerWithTarget<MenuItemElement> listener);

		public extern void RemoveEventListener(MenuItemElementEvents type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture);

		public extern void RemoveEventListener(MenuItemElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MenuItemElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture);

		public string Type;
	}
}
