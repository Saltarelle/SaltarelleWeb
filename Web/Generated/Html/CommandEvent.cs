using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CommandEvent : Event {
		internal CommandEvent() {
		}

		[IntrinsicProperty]
		public string Command {
			get {
				return null;
			}
		}

		public void InitCommandEvent(string type, bool canBubble, bool cancelable, string command) {
		}
	}
}
