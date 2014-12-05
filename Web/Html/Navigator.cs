using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Navigator {
		[InlineCode("(navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia).call(navigator, {params}, {onsuccess})")]
		public static void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess) {}

		[InlineCode("(navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia).call(navigator, {params}, {onsuccess}, {onerror})")]
		public static void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess, Action<string> onerror) {}
	}
}