using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLFieldSetElement : HTMLElement
	{
		internal extern HTMLFieldSetElement();

		public extern void AddEventListener(HTMLFieldSetElementEvents type, Action listener);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener, bool capture);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLFieldSetElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener, bool capture);

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly HTMLCollection Elements;

		public readonly HTMLFormElement Form;

		public string Name;

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLFieldSetElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFieldSetElement> listener, bool capture);

		public extern void SetCustomValidity(string error);

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public readonly bool WillValidate;
	}
}
