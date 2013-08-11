// RTCDataChannelInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCDataChannelInit {
		public ushort? Id {
			get { return null; }
			set { }
		}

		public ushort MaxRetransmitNum {
			get { return 0; }
			set { }
		}

		public ushort? MaxRetransmits {
			get { return null; }
			set { }
		}

		public ushort? MaxRetransmitTime {
			get { return null; }
			set { }
		}

		public bool Negotiated {
			get { return false; }
			set { }
		}

		public bool Ordered {
			get { return false; }
			set { }
		}

		public bool OutOfOrderAllowed {
			get { return false; }
			set { }
		}

		public bool Preset {
			get { return false; }
			set { }
		}

		public string Protocol {
			get { return null; }
			set { }
		}

		public ushort Stream {
			get { return 0; }
			set { }
		}
	}
}
