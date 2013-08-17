using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FORM'"), ScriptName("Element")]
	public partial class FormElement : Element {
		internal FormElement() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public Element this[string name] {
			get {
				return default(Element);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public XmlElement this[uint index] {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public string AcceptCharset {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Action {
			get {
				return null;
			}
			set {
			}
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Autocomplete {
			get {
				return null;
			}
			set {
			}
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public ElementCollection Elements {
			get {
				return default(ElementCollection);
			}
		}

		[IntrinsicProperty]
		public string Encoding {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Enctype {
			get {
				return null;
			}
			set {
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlElement> GetEnumerator() {
			return null;
		}

		[IntrinsicProperty]
		public int Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Method {
			get {
				return null;
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

		[IntrinsicProperty]
		public bool NoValidate {
			get {
				return false;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FormElement> listener, bool capture) {
		}

		public void Reset() {
		}

		public void Submit() {
		}

		[IntrinsicProperty]
		public string Target {
			get {
				return null;
			}
			set {
			}
		}
	}
}
