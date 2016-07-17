namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class MouseEvent : UIEvent
	{
		internal extern MouseEvent();

		public extern MouseEvent(string typeArg);

		public extern MouseEvent(string typeArg, MouseEventInit mouseEventInitDict);

		public readonly bool AltKey;

		public readonly short Button;

		public readonly ushort Buttons;

		public readonly int ClientX;

		public readonly int ClientY;

		public readonly bool CtrlKey;

		public extern bool GetModifierState(string keyArg);

		public extern void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, EventTarget relatedTargetArg);

		public readonly bool MetaKey;

		public readonly EventTarget RelatedTarget;

		public readonly int ScreenX;

		public readonly int ScreenY;

		public readonly bool ShiftKey;
	}
}
