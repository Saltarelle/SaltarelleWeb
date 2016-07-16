using System;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SELECT'"), Name("Element")]
	public partial class SelectElement : Element
	{
		internal extern SelectElement();

		[IndexerName("__Item"), FieldProperty]
		public TypeOption<Element, OptionElement> this[int index]
		{
			get;
			set;
		}

		public extern void Add(TypeOption<OptionElement, OptGroupElement> element);

		public extern void Add(TypeOption<OptionElement, OptGroupElement> element, TypeOption<Element, int> before);

		public extern void AddEventListener(SelectElementEvents type, Action listener);

		public extern void AddEventListener(SelectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SelectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener);

		public extern void AddEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture);

		public extern void AddEventListener(SelectElementEvents type, IEventListener listener);

		public extern void AddEventListener(SelectElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture);

		[FieldProperty]
		public extern bool Autofocus
		{
			get;
			set;
		}

		public extern bool CheckValidity();

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		public extern Element Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Multiple
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		public extern OptionElement NamedItem(string name);

		[FieldProperty]
		public extern HtmlOptionsCollection Options
		{
			get;
		}

		public extern void Remove();

		public extern void Remove(int index);

		public extern void RemoveEventListener(SelectElementEvents type, Action listener);

		public extern void RemoveEventListener(SelectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SelectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener);

		public extern void RemoveEventListener(SelectElementEvents type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture);

		public extern void RemoveEventListener(SelectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SelectElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SelectElement> listener, bool capture);

		[FieldProperty]
		public extern bool Required
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int SelectedIndex
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection SelectedOptions
		{
			get;
		}

		public extern void SetCustomValidity(string error);

		[FieldProperty]
		public extern int Size
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
		}

		[FieldProperty]
		public extern string ValidationMessage
		{
			get;
		}

		[FieldProperty]
		public extern ValidityState Validity
		{
			get;
		}

		[FieldProperty]
		public extern string Value
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool WillValidate
		{
			get;
		}
	}
}
