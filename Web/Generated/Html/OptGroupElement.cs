// OptGroupElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'OPTGROUP'"), ScriptName("Element")]
	public partial class OptGroupElement : Element {
		internal OptGroupElement() {
		}

		[IntrinsicProperty]
		public bool Disabled {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Label {
			get { return null; }
			set { }
		}
	}
}
