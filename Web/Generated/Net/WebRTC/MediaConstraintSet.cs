using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class MediaConstraintSet {
		[ScriptName("OfferToReceiveAudio")]
		public bool OfferToReceiveAudio {
			get;
			set;
		}

		[ScriptName("OfferToReceiveVideo")]
		public bool OfferToReceiveVideo {
			get;
			set;
		}
	}
}
