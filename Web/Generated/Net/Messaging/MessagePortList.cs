using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Net.Messaging {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class MessagePortList {
		internal MessagePortList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MessagePort this[uint index] {
			get {
				return default(MessagePort);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MessagePort> GetEnumerator() {
			return null;
		}

		public MessagePort Item(uint index) {
			return default(MessagePort);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}
	}
}
