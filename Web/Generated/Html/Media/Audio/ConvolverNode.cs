// ConvolverNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ConvolverNode : AudioNode {
		internal ConvolverNode() {
		}

		[IntrinsicProperty]
		public AudioBuffer Buffer {
			get { return default(AudioBuffer); }
			set { }
		}

		[IntrinsicProperty]
		public bool Normalize {
			get { return false; }
			set { }
		}
	}
}
