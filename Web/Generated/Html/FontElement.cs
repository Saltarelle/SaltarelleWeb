// FontElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FONT'"), ScriptName("Element")]
	public partial class FontElement : Element {
		internal FontElement() {
		}

		[IntrinsicProperty]
		public string Color {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Face {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Size {
			get { return null; }
			set { }
		}
	}
}
