// AudioDestinationNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioDestinationNode : AudioNode {
		internal AudioDestinationNode() {
		}

		[IntrinsicProperty]
		public uint MaxChannelCount {
			get { return 0; }
		}
	}
}
