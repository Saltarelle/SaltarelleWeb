using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioChannelManager : EventTarget {
		internal AudioChannelManager() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Headphones {
			get {
				return false;
			}
		}

		[IntrinsicProperty, ScriptName("onheadphoneschange")]
		public HtmlEventHandler OnHeadphoneschange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture) {
		}
	}
}
