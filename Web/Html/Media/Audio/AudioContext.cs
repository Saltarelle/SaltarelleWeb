using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	public partial class AudioContext {
		[InlineCode("new ({$System.Html.Window}.AudioContext || " + "{$System.Html.Window}.webkitAudioContext || " + "{$System.Html.Window}.mozAudioContext || " + "{$System.Html.Window}.msAudioContext || " + "{$System.Html.Window}.oAudioContext)()")]
		public AudioContext() {
		}
	}
}
