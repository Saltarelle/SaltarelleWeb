using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OBJECT'"), Name("Element")]
	public partial class ObjectElement : Element
	{
		internal extern ObjectElement();

		public extern void AddEventListener(ObjectElementEvents type, Action listener);

		public extern void AddEventListener(ObjectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener);

		public extern void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture);

		public extern void AddEventListener(ObjectElementEvents type, IEventListener listener);

		public extern void AddEventListener(ObjectElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Archive
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Border
		{
			get;
			set;
		}

		[Template("{this}({*arguments})")]
		public extern object Call(params object[] arguments);

		public extern bool CheckValidity();

		[FieldProperty]
		public extern string Code
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CodeBase
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string CodeType
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DocumentBase ContentDocument
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance ContentWindow
		{
			get;
		}

		[FieldProperty]
		public extern string Data
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Declare
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		public extern DocumentBase GetSVGDocument();

		[FieldProperty]
		public extern string Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Hspace
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

		public extern void RemoveEventListener(ObjectElementEvents type, Action listener);

		public extern void RemoveEventListener(ObjectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener);

		public extern void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture);

		public extern void RemoveEventListener(ObjectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ObjectElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		[FieldProperty]
		public extern string Standby
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool TypeMustMatch
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string UseMap
		{
			get;
			set;
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
		public extern int Vspace
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Width
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
