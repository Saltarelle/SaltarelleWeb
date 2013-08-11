// TransitionEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class TransitionEvent : Event {
		internal TransitionEvent() {
		}

		public TransitionEvent(string type) {
		}

		public TransitionEvent(string type, TransitionEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public float ElapsedTime {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string PropertyName {
			get { return null; }
		}

		[IntrinsicProperty]
		public string PseudoElement {
			get { return null; }
		}
	}
}
