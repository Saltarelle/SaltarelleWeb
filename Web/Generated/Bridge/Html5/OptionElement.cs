namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTION'"), Name("Element")]
	public partial class OptionElement : Element
	{
		[Template("new Option()")]
		public extern OptionElement();

		[Template("new Option({text})")]
		public extern OptionElement(string text);

		[Template("new Option({text}, {value})")]
		public extern OptionElement(string text, string value);

		[Template("new Option({text}, {value}, {defaultSelected})")]
		public extern OptionElement(string text, string value, bool defaultSelected);

		[Template("new Option({text}, {value}, {defaultSelected}, {selected})")]
		public extern OptionElement(string text, string value, bool defaultSelected, bool selected);

		public extern void AddEventListener(OptionElementEvents type, Action listener);

		public extern void AddEventListener(OptionElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(OptionElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener);

		public extern void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture);

		public extern void AddEventListener(OptionElementEvents type, IEventListener listener);

		public extern void AddEventListener(OptionElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture);

		[FieldProperty]
		public extern bool DefaultSelected
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
		public extern int Index
		{
			get;
		}

		[FieldProperty]
		public extern string Label
		{
			get;
			set;
		}

		public extern void RemoveEventListener(OptionElementEvents type, Action listener);

		public extern void RemoveEventListener(OptionElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener);

		public extern void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture);

		public extern void RemoveEventListener(OptionElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(OptionElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture);

		[FieldProperty]
		public extern bool Selected
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Text
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Value
		{
			get;
			set;
		}
	}
}
