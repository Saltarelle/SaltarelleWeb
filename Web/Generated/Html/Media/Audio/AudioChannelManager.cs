using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioChannelManager : EventTarget {
		internal AudioChannelManager() {
		}

		[IntrinsicProperty]
		public bool Headphones {
			get { return false; }
		}

		[IntrinsicProperty, ScriptName("onheadphoneschange")]
		public HtmlEventHandler OnHeadphoneschange {
			get { return default(HtmlEventHandler); }
			set { }
		}
	}
}
