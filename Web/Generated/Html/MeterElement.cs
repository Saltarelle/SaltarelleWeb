// MeterElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'METER'"), ScriptName("Element")]
	public partial class MeterElement : Element {
		internal MeterElement() {
		}

		[IntrinsicProperty]
		public double High {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Low {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Max {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Min {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Optimum {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double Value {
			get { return 0; }
			set { }
		}
	}
}
