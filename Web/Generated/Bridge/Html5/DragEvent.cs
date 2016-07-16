namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DragEvent : MouseEvent
	{
		internal extern DragEvent();

		[FieldProperty]
		public extern DataTransfer DataTransfer
		{
			get;
		}

		public extern void InitDragEvent(string type, bool canBubble, bool cancelable, WindowInstance aView, int aDetail, int aScreenX, int aScreenY, int aClientX, int aClientY, bool aCtrlKey, bool aAltKey, bool aShiftKey, bool aMetaKey, ushort aButton, EventTarget aRelatedTarget, DataTransfer aDataTransfer);
	}
}
