namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DragEvent : MouseEvent
	{
		internal extern DragEvent();

		public readonly DataTransfer DataTransfer;

		public extern void InitDragEvent(string type, bool canBubble, bool cancelable, WindowInstance aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton, EventTarget aRelatedTarget, DataTransfer aDataTransfer);
	}
}
