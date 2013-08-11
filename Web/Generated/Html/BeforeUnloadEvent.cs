// BeforeUnloadEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class BeforeUnloadEvent : Event {
		internal BeforeUnloadEvent() {
		}

		[IntrinsicProperty]
		public string ReturnValue {
			get { return null; }
			set { }
		}
	}
}
