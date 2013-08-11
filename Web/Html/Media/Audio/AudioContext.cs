// AudioContext.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	public partial class AudioContext {
		[InlineCode("new (window.AudioContext || " + "window.webkitAudioContext || " + "window.mozAudioContext || " + "window.msAudioContext || " + "window.oAudioContext)()")]
		public AudioContext() {
		}
	}
}
