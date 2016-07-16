namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OUTPUT'"), Name("Element")]
	public partial class OutputElement : Element
	{
		internal extern OutputElement();

		public extern void AddEventListener(OutputElementEvents type, Action listener);

		public extern void AddEventListener(OutputElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void AddEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void AddEventListener(OutputElementEvents type, IEventListener listener);

		public extern void AddEventListener(OutputElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern bool CheckValidity();

		[FieldProperty]
		public extern string DefaultValue
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
		public extern DOMSettableTokenList HtmlFor
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		public extern void RemoveEventListener(OutputElementEvents type, Action listener);

		public extern void RemoveEventListener(OutputElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void RemoveEventListener(OutputElementEvents type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void RemoveEventListener(OutputElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(OutputElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OutputElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

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
