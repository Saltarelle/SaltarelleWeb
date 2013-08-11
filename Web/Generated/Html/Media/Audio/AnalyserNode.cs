// AnalyserNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AnalyserNode : AudioNode {
		internal AnalyserNode() {
		}

		[IntrinsicProperty]
		public uint FftSize {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public uint FrequencyBinCount {
			get { return 0; }
		}

		public void GetByteFrequencyData(Uint8Array array) {
		}

		public void GetByteTimeDomainData(Uint8Array array) {
		}

		public void GetFloatFrequencyData(Float32Array array) {
		}

		[IntrinsicProperty]
		public double MaxDecibels {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double MinDecibels {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double SmoothingTimeConstant {
			get { return 0; }
			set { }
		}
	}
}
