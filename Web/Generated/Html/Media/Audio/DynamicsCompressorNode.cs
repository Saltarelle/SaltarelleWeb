// DynamicsCompressorNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DynamicsCompressorNode : AudioNode {
		internal DynamicsCompressorNode() {
		}

		[IntrinsicProperty]
		public AudioParam Attack {
			get { return default(AudioParam); }
		}

		[IntrinsicProperty]
		public AudioParam Knee {
			get { return default(AudioParam); }
		}

		[IntrinsicProperty]
		public AudioParam Ratio {
			get { return default(AudioParam); }
		}

		[IntrinsicProperty]
		public AudioParam Reduction {
			get { return default(AudioParam); }
		}

		[IntrinsicProperty]
		public AudioParam Release {
			get { return default(AudioParam); }
		}

		[IntrinsicProperty]
		public AudioParam Threshold {
			get { return default(AudioParam); }
		}
	}
}
