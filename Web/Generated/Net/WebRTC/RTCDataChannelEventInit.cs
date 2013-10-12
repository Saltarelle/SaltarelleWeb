using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCDataChannelEventInit : EventInit {
		public RTCDataChannel Channel {
			get;
			set;
		}
	}
}
