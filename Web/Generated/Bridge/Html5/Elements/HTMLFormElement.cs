using Bridge.Html5.Nodes;
using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLFormElement : HTMLElement, IEnumerable<Element>
	{
		internal extern HTMLFormElement();

		public extern Element this[int index]
		{
			get;
		}

		public extern HTMLElement this[string name]
		{
			get;
		}

		public string AcceptCharset;

		public string Action;

		public extern void AddEventListener(HTMLFormElementEvents type, Action listener);

		public extern void AddEventListener(HTMLFormElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLFormElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLFormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLFormElementEvents type, HtmlEventHandlerWithTarget<HTMLFormElement> listener);

		public extern void AddEventListener(HTMLFormElementEvents type, HtmlEventHandlerWithTarget<HTMLFormElement> listener, bool capture);

		public extern void AddEventListener(HTMLFormElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLFormElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFormElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLFormElement> listener, bool capture);

		public string Autocomplete;

		public extern bool CheckValidity();

		public readonly HTMLCollection Elements;

		public string Encoding;

		public string Enctype;

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Element> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public readonly int Length;

		public string Method;

		public string Name;

		public bool NoValidate;

		public extern void RemoveEventListener(HTMLFormElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLFormElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLFormElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLFormElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLFormElementEvents type, HtmlEventHandlerWithTarget<HTMLFormElement> listener);

		public extern void RemoveEventListener(HTMLFormElementEvents type, HtmlEventHandlerWithTarget<HTMLFormElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLFormElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLFormElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFormElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLFormElement> listener, bool capture);

		public extern void Reset();

		public extern void Submit();

		public string Target;
	}
}
