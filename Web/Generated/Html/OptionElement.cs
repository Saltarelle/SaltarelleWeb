﻿using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTION'"), ScriptName("Element")]
	public partial class OptionElement : Element {
		[InlineCode("new Option()")]
		public OptionElement() {
		}

		[InlineCode("new Option({text})")]
		public OptionElement(string text) {
		}

		[InlineCode("new Option({text}, {value})")]
		public OptionElement(string text, string value) {
		}

		[InlineCode("new Option({text}, {value}, {defaultSelected})")]
		public OptionElement(string text, string value, bool defaultSelected) {
		}

		[InlineCode("new Option({text}, {value}, {defaultSelected}, {selected})")]
		public OptionElement(string text, string value, bool defaultSelected, bool selected) {
		}

		public void AddEventListener(OptionElementEvents type, Action listener) {
		}

		public void AddEventListener(OptionElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener) {
		}

		public void AddEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture) {
		}

		public void AddEventListener(OptionElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(OptionElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool DefaultSelected {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Disabled {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public FormElement Form {
			get {
				return default(FormElement);
			}
		}

		[IntrinsicProperty]
		public int Index {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(OptionElementEvents type, Action listener) {
		}

		public void RemoveEventListener(OptionElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener) {
		}

		public void RemoveEventListener(OptionElementEvents type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture) {
		}

		public void RemoveEventListener(OptionElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(OptionElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<OptionElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Selected {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Text {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Value {
			get {
				return null;
			}
			set {
			}
		}
	}
}
