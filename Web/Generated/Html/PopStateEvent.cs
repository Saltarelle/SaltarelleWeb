// PopStateEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PopStateEvent : Event {
		internal PopStateEvent() {
		}

		public PopStateEvent(string type) {
		}

		public PopStateEvent(string type, PopStateEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public object State {
			get { return null; }
		}
	}
}
