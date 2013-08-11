// OfflineAudioContext.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class OfflineAudioContext : AudioContext {
		internal OfflineAudioContext() {
		}

		public OfflineAudioContext(uint numberOfChannels, uint length, float sampleRate) {
		}

		[IntrinsicProperty, ScriptName("oncomplete")]
		public HtmlEventHandler OnComplete {
			get { return default(HtmlEventHandler); }
			set { }
		}

		public void StartRendering() {
		}
	}
}
