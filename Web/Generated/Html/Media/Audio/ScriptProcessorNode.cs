using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ScriptProcessorNode : AudioNode {
		internal ScriptProcessorNode() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture) {
		}

		[IntrinsicProperty]
		public int BufferSize {
			get {
				return 0;
			}
		}

		[IntrinsicProperty, ScriptName("onaudioprocess")]
		public HtmlEventHandler OnAudioprocess {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture) {
		}
	}
}
