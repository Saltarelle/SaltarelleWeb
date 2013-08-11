// MediaQueryList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MediaQueryList {
		internal MediaQueryList() {
		}

		public void AddListener(MediaQueryListListener listener) {
		}

		[IntrinsicProperty]
		public bool Matches {
			get { return false; }
		}

		[IntrinsicProperty]
		public string Media {
			get { return null; }
		}

		public void RemoveListener(MediaQueryListListener listener) {
		}
	}
}
