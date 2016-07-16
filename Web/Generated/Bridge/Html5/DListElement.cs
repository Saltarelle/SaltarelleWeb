﻿namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'DL'"), Name("Element")]
	public partial class DListElement : Element
	{
		internal extern DListElement();

		public extern void AddEventListener(DListElementEvents type, Action listener);

		public extern void AddEventListener(DListElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(DListElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DListElementEvents type, HtmlEventHandlerWithTarget<DListElement> listener);

		public extern void AddEventListener(DListElementEvents type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture);

		public extern void AddEventListener(DListElementEvents type, IEventListener listener);

		public extern void AddEventListener(DListElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture);

		[FieldProperty]
		public extern bool Compact
		{
			get;
			set;
		}

		public extern void RemoveEventListener(DListElementEvents type, Action listener);

		public extern void RemoveEventListener(DListElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DListElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DListElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DListElementEvents type, HtmlEventHandlerWithTarget<DListElement> listener);

		public extern void RemoveEventListener(DListElementEvents type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture);

		public extern void RemoveEventListener(DListElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(DListElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DListElement> listener, bool capture);
	}
}
