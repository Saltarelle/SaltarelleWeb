// ClipboardEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ClipboardEvent : Event {
		internal ClipboardEvent() {
		}

		public ClipboardEvent(string type) {
		}

		public ClipboardEvent(string type, ClipboardEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public DataTransfer ClipboardData {
			get { return default(DataTransfer); }
		}
	}
}
