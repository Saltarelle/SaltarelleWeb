using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FORM'"), Name("Element")]
	public partial class FormElement : Element
	{
		internal extern FormElement();

		[IndexerName("__Item"), FieldProperty]
		public Element this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public Element this[string name]
		{
			get;
		}

		[FieldProperty]
		public extern string AcceptCharset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Action
		{
			get;
			set;
		}

		public extern void AddEventListener(FormElementEvents type, Action listener);

		public extern void AddEventListener(FormElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void AddEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void AddEventListener(FormElementEvents type, IEventListener listener);

		public extern void AddEventListener(FormElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		[FieldProperty]
		public extern string Autocomplete
		{
			get;
			set;
		}

		public extern bool CheckValidity();

		[FieldProperty]
		public extern ElementCollection Elements
		{
			get;
		}

		[FieldProperty]
		public extern string Encoding
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Enctype
		{
			get;
			set;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern string Method
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

		[FieldProperty]
		public extern bool NoValidate
		{
			get;
			set;
		}

		public extern void RemoveEventListener(FormElementEvents type, Action listener);

		public extern void RemoveEventListener(FormElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void RemoveEventListener(FormElementEvents type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void RemoveEventListener(FormElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(FormElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture);

		public extern void Reset();

		public extern void Submit();

		[FieldProperty]
		public extern string Target
		{
			get;
			set;
		}
	}
}
