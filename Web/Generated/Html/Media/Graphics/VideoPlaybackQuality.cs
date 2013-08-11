// VideoPlaybackQuality.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class VideoPlaybackQuality {
		internal VideoPlaybackQuality() {
		}

		[IntrinsicProperty]
		public uint CorruptedVideoFrames {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double CreationTime {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint DroppedVideoFrames {
			get { return 0; }
		}

		[IntrinsicProperty]
		public double TotalFrameDelay {
			get { return 0; }
		}

		[IntrinsicProperty]
		public uint TotalVideoFrames {
			get { return 0; }
		}
	}
}
