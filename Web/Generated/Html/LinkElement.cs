// LinkElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'LINK'"), ScriptName("Element")]
	public partial class LinkElement : Element {
		internal LinkElement() {
		}

		[IntrinsicProperty]
		public string Charset {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string CrossOrigin {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public bool Disabled {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Href {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Hreflang {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Media {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Rel {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Rev {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get { return default(StyleSheet); }
		}

		[IntrinsicProperty]
		public string Target {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Type {
			get { return null; }
			set { }
		}
	}
}
