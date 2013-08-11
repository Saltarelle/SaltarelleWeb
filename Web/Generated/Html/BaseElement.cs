// BaseElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'BASE'"), ScriptName("Element")]
	public partial class BaseElement : Element {
		internal BaseElement() {
		}

		[IntrinsicProperty]
		public string Href {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Target {
			get { return null; }
			set { }
		}
	}
}
