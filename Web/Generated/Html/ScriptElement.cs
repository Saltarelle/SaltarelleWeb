using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SCRIPT'"), ScriptName("Element")]
	public partial class ScriptElement : Element {
		internal ScriptElement() {
		}

		[IntrinsicProperty]
		public bool Async {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Charset {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string CrossOrigin {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Defer {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Event {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string HtmlFor {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Src {
			get {
				return null;
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
		public string Type {
			get {
				return null;
			}
			set {
			}
		}
	}
}
