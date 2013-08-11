// CustomEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CustomEvent : Event {
		internal CustomEvent() {
		}

		public CustomEvent(string type) {
		}

		public CustomEvent(string type, CustomEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public object Detail {
			get { return null; }
		}
	}
}
