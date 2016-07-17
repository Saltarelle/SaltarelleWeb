using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
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

		public string Align;

		public string Archive;

		public string Border;

		[Template("{this}({*arguments})")]
		public extern object Call(params object[] arguments);

		public extern bool CheckValidity();

		public string Code;

		public string CodeBase;

		public string CodeType;

		public readonly DocumentBase ContentDocument;

		public readonly WindowInstance ContentWindow;

		public string Data;

		public bool Declare;

		public readonly FormElement Form;

		public extern DocumentBase GetSVGDocument();

		public string Height;

		public int Hspace;

		public string Name;

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

		public string Standby;

		public string Type;

		public bool TypeMustMatch;

		public string UseMap;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public int Vspace;

		public string Width;

		public readonly bool WillValidate;
	}
}
