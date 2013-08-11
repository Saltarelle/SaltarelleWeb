// HtmlElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'HTML'"), ScriptName("Element")]
	public partial class HtmlElement : Element {
		internal HtmlElement() {
		}

		[IntrinsicProperty]
		public string Version {
			get { return null; }
			set { }
		}
	}
}
