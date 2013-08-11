// BarProp.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BarProp {
		internal BarProp() {
		}

		[IntrinsicProperty]
		public bool Visible {
			get { return false; }
			set { }
		}
	}
}
