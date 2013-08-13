using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ScriptProcessorNode : AudioNode {
		internal ScriptProcessorNode() {
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
	}
}
