using System;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class SelectElement : Element
	{
		internal extern SelectElement();

		public extern TypeOption<Element, OptionElement> this[int index]
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

		public bool Autofocus;

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly FormElement Form;

		public extern Element Item(int index);

		public int Length;

		public bool Multiple;

		public string Name;

		public extern OptionElement NamedItem(string name);

		public readonly HtmlOptionsCollection Options;

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

		public bool Required;

		public int SelectedIndex;

		public readonly ElementCollection SelectedOptions;

		public extern void SetCustomValidity(string error);

		public int Size;

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
