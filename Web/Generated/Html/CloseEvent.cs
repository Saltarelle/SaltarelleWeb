// CloseEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CloseEvent : Event {
		internal CloseEvent() {
		}

		public CloseEvent(string type) {
		}

		public CloseEvent(string type, CloseEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public ushort Code {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string Reason {
			get { return null; }
		}

		[IntrinsicProperty]
		public bool WasClean {
			get { return false; }
		}
	}
}
