﻿using System.Runtime.CompilerServices;

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
			get {
				return null;
			}
		}

		public void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail) {
		}
	}
}
