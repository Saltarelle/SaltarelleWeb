// AudioNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioNode : EventTarget {
		internal AudioNode() {
		}

		[IntrinsicProperty]
		public uint ChannelCount {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public ChannelCountMode ChannelCountMode {
			get { return default(ChannelCountMode); }
			set { }
		}

		[IntrinsicProperty]
		public ChannelInterpretation ChannelInterpretation {
			get { return default(ChannelInterpretation); }
			set { }
		}

		public void Connect(AudioNode destination) {
		}

		public void Connect(AudioNode destination, uint output) {
		}

		public void Connect(AudioNode destination, uint output, uint input) {
		}

		public void Connect(AudioParam destination) {
		}

		public void Connect(AudioParam destination, uint output) {
		}

		[IntrinsicProperty]
		public AudioContext Context {
			get { return default(AudioContext); }
		}

		public void Disconnect() {
		}

		public void Disconnect(uint output) {
		}

		[IntrinsicProperty]
		public uint NumberOfInputs {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint NumberOfOutputs {
			get { return 0; }
		}
	}
}
