namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEXTAREA'"), Name("Element")]
	public partial class TextAreaElement : Element
	{
		internal extern TextAreaElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture);

		public extern void AddEventListener(TextAreaElementEvents type, Action listener);

		public extern void AddEventListener(TextAreaElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TextAreaElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TextAreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener);

		public extern void AddEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture);

		public extern void AddEventListener(TextAreaElementEvents type, IEventListener listener);

		public extern void AddEventListener(TextAreaElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern bool Autofocus
		{
			get;
			set;
		}

		public extern bool CheckValidity();

		[FieldProperty]
		public extern int Cols
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string DefaultValue
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern int MaxLength
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
		public extern string Placeholder
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool ReadOnly
		{
			get;
			set;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture);

		public extern void RemoveEventListener(TextAreaElementEvents type, Action listener);

		public extern void RemoveEventListener(TextAreaElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener);

		public extern void RemoveEventListener(TextAreaElementEvents type, HtmlEventHandlerWithTarget<TextAreaElement> listener, bool capture);

		public extern void RemoveEventListener(TextAreaElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TextAreaElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern bool Required
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Rows
		{
			get;
			set;
		}

		public extern void Select();

		[FieldProperty]
		public extern string SelectionDirection
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int SelectionEnd
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int SelectionStart
		{
			get;
			set;
		}

		public extern void SetCustomValidity(string error);

		public extern void SetRangeText(string replacement);

		public extern void SetRangeText(string replacement, int start, int end);

		public extern void SetRangeText(string replacement, int start, int end, SelectionMode selectionMode);

		public extern void SetSelectionRange(int start, int end);

		public extern void SetSelectionRange(int start, int end, string direction);

		[FieldProperty]
		public extern int TextLength
		{
			get;
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

		[FieldProperty]
		public extern string Wrap
		{
			get;
			set;
		}
	}
}
