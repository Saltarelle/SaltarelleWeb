using Bridge.Html5.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLSelectElement : HTMLElement, IEnumerable<Element>
	{
		internal extern HTMLSelectElement();

		public extern TypeOption<Element, HTMLOptionElement> this[int index]
		{
			get;
			set;
		}

		public extern void Add(TypeOption<HTMLOptionElement, HTMLOptGroupElement> element);

		public extern void Add(TypeOption<HTMLOptionElement, HTMLOptGroupElement> element, TypeOption<HTMLElement, int> before);

		public extern void AddEventListener(HTMLSelectElementEvents type, Action listener);

		public extern void AddEventListener(HTMLSelectElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLSelectElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLSelectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLSelectElementEvents type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener);

		public extern void AddEventListener(HTMLSelectElementEvents type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener, bool capture);

		public extern void AddEventListener(HTMLSelectElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLSelectElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener, bool capture);

		public bool Autofocus;

		public extern bool CheckValidity();

		public bool Disabled;

		public readonly HTMLFormElement Form;

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Element Item(int index);

		public int Length;

		public bool Multiple;

		public string Name;

		public extern HTMLOptionElement NamedItem(string name);

		public readonly HTMLOptionsCollection Options;

		public extern void Remove();

		public extern void Remove(int index);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLSelectElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLSelectElement> listener, bool capture);

		public bool Required;

		public int SelectedIndex;

		public readonly HTMLCollection SelectedOptions;

		public extern void SetCustomValidity(string error);

		public int Size;

		public readonly string Type;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public readonly bool WillValidate;
	}
}
