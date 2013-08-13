using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'STYLE'"), ScriptName("Element")]
	public partial class StyleElement : Element {
		internal StyleElement() {
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
		public string Media {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Scoped {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get {
				return default(StyleSheet);
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
