using System.Runtime.CompilerServices;

namespace System.Net.Messaging {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MessageChannel {
		public MessageChannel() {
		}

		[IntrinsicProperty]
		public MessagePort Port1 {
			get {
				return default(MessagePort);
			}
		}

		[IntrinsicProperty]
		public MessagePort Port2 {
			get {
				return default(MessagePort);
			}
		}
	}
}
