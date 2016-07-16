﻿namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MENU'"), Name("Element")]
	public partial class MenuElement : Element
	{
		internal extern MenuElement();

		public extern void AddEventListener(MenuElementEvents type, Action listener);

		public extern void AddEventListener(MenuElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MenuElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MenuElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MenuElementEvents type, HtmlEventHandlerWithTarget<MenuElement> listener);

		public extern void AddEventListener(MenuElementEvents type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture);

		public extern void AddEventListener(MenuElementEvents type, IEventListener listener);

		public extern void AddEventListener(MenuElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture);

		[FieldProperty]
		public extern bool Compact
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Label
		{
			get;
			set;
		}

		public extern void RemoveEventListener(MenuElementEvents type, Action listener);

		public extern void RemoveEventListener(MenuElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MenuElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MenuElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MenuElementEvents type, HtmlEventHandlerWithTarget<MenuElement> listener);

		public extern void RemoveEventListener(MenuElementEvents type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture);

		public extern void RemoveEventListener(MenuElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MenuElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuElement> listener, bool capture);

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}
	}
}
