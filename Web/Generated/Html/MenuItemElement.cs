using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'MENUITEM'"), ScriptName("Element")]
	public partial class MenuItemElement : Element {
		internal MenuItemElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Checked {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool DefaultChecked {
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
		public string Icon {
			get {
				return null;
			}
			set {
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

		[IntrinsicProperty]
		public string Radiogroup {
			get {
				return null;
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MenuItemElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
