// ProgressEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ProgressEvent : Event {
		internal ProgressEvent() {
		}

		public ProgressEvent(string type) {
		}

		public ProgressEvent(string type, ProgressEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public bool LengthComputable {
			get { return false; }
		}

		[IntrinsicProperty]
		public ulong Loaded {
			get { return 0; }
		}

		[IntrinsicProperty]
		public ulong Total {
			get { return 0; }
		}
	}
}
