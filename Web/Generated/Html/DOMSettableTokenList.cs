using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DOMSettableTokenList : TokenList {
		internal DOMSettableTokenList() {
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
