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

		public bool Autofocus;

		public extern bool CheckValidity();

		public int Cols;

		public string DefaultValue;

		public bool Disabled;

		public readonly FormElement Form;

		public int MaxLength;

		public string Name;

		public string Placeholder;

		public bool ReadOnly;

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

		public bool Required;

		public int Rows;

		public extern void Select();

		public string SelectionDirection;

		public int SelectionEnd;

		public int SelectionStart;

		public extern void SetCustomValidity(string error);

		public extern void SetRangeText(string replacement);

		public extern void SetRangeText(string replacement, int start, int end);

		public extern void SetRangeText(string replacement, int start, int end, SelectionMode selectionMode);

		public extern void SetSelectionRange(int start, int end);

		public extern void SetSelectionRange(int start, int end, string direction);

		public readonly int TextLength;

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;

		public string Wrap;
	}
}
