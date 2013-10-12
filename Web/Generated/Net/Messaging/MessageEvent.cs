using System.Html;
using System.Runtime.CompilerServices;

namespace System.Net.Messaging {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MessageEvent : Event {
		internal MessageEvent() {
		}

		public MessageEvent(string type) {
		}

		public MessageEvent(string type, MessageEventInit eventInitDict) {
		}

		[IntrinsicProperty]
		public object Data {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string LastEventId {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Origin {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public MessagePortList Ports {
			get {
				return default(MessagePortList);
			}
		}

		[IntrinsicProperty]
		public TypeOption<WindowInstance, MessagePort> Source {
			get {
				return default(TypeOption<WindowInstance, MessagePort>);
			}
		}
	}
}
