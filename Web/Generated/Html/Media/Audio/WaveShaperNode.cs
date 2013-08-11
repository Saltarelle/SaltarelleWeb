// WaveShaperNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Html.Media.Graphics.WebGL;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WaveShaperNode : AudioNode {
		internal WaveShaperNode() {
		}

		[IntrinsicProperty]
		public Float32Array Curve {
			get { return default(Float32Array); }
			set { }
		}

		[IntrinsicProperty]
		public OverSampleType Oversample {
			get { return default(OverSampleType); }
			set { }
		}
	}
}
