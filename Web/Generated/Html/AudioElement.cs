using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'AUDIO'"), ScriptName("Element")]
	public partial class AudioElement : MediaElement {
		[InlineCode("new Audio()")]
		public AudioElement() {
		}

		[InlineCode("new Audio({src})")]
		public AudioElement(string src) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture) {
		}
	}
}
