using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DragEvent : MouseEvent {
		internal DragEvent() {
		}

		[IntrinsicProperty]
		public DataTransfer DataTransfer {
			get {
				return default(DataTransfer);
			}
		}

		public void InitDragEvent(string type, bool canBubble, bool cancelable, WindowInstance aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton, EventTarget aRelatedTarget, DataTransfer aDataTransfer) {
		}
	}
}
