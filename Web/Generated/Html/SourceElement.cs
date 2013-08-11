// SourceElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'SOURCE'"), ScriptName("Element")]
	public partial class SourceElement : Element {
		internal SourceElement() {
		}

		[IntrinsicProperty]
		public string Media {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Src {
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
