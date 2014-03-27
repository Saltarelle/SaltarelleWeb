﻿using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OBJECT'"), ScriptName("Element")]
	public partial class ObjectElement : Element {
		internal ObjectElement() {
		}

		public void AddEventListener(ObjectElementEvents type, Action listener) {
		}

		public void AddEventListener(ObjectElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener) {
		}

		public void AddEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture) {
		}

		public void AddEventListener(ObjectElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(ObjectElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Archive {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Border {
			get {
				return null;
			}
			set {
			}
		}

		[InlineCode("{this}({*arguments})")]
		public object Call(params object[] arguments) {
			return null;
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public string Code {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CodeBase {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CodeType {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DocumentBase ContentDocument {
			get {
				return default(DocumentBase);
			}
		}

		[IntrinsicProperty]
		public WindowInstance ContentWindow {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public string Data {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Declare {
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

		public DocumentBase GetSVGDocument() {
			return default(DocumentBase);
		}

		[IntrinsicProperty]
		public string Height {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int Hspace {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		public void RemoveEventListener(ObjectElementEvents type, Action listener) {
		}

		public void RemoveEventListener(ObjectElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener) {
		}

		public void RemoveEventListener(ObjectElementEvents type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture) {
		}

		public void RemoveEventListener(ObjectElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(ObjectElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ObjectElement> listener, bool capture) {
		}

		public void SetCustomValidity(string error) {
		}

		[IntrinsicProperty]
		public string Standby {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool TypeMustMatch {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string UseMap {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string ValidationMessage {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ValidityState Validity {
			get {
				return default(ValidityState);
			}
		}

		[IntrinsicProperty]
		public int Vspace {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Width {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool WillValidate {
			get {
				return false;
			}
		}
	}
}
