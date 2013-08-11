// EventTarget.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class EventTarget {
		internal EventTarget() {
		}

		public void AddEventListener(string type, IEventListener listener) {
		}

		public void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public bool DispatchEvent(Event @event) {
			return false;
		}

		public void RemoveEventListener(string type, IEventListener listener) {
		}

		public void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}
	}
}
