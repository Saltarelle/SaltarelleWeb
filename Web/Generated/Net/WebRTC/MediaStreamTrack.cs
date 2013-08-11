// MediaStreamTrack.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaStreamTrack {
		internal MediaStreamTrack() {
		}

		[IntrinsicProperty]
		public bool Enabled {
			get { return false; }
			set { }
		}

		[IntrinsicProperty]
		public string Id {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Kind {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Label {
			get { return null; }
		}
	}
}
