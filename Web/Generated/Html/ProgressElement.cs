// ProgressElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'PROGRESS'"), ScriptName("Element")]
	public partial class ProgressElement : Element {
		internal ProgressElement() {
		}

		[IntrinsicProperty]
		public double Max {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Position {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double Value {
			get { return 0; }
			set { }
		}
	}
}
