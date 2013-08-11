using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	public partial class AudioContext {
		[InlineCode("new (window.AudioContext || " + "window.webkitAudioContext || " + "window.mozAudioContext || " + "window.msAudioContext || " + "window.oAudioContext)()")]
		public AudioContext() {
		}
	}
}
