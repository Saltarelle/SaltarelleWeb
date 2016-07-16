namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MouseEvent : UIEvent
	{
		internal extern MouseEvent();

		public extern MouseEvent(string typeArg);

		public extern MouseEvent(string typeArg, MouseEventInit mouseEventInitDict);

		[FieldProperty]
		public extern bool AltKey
		{
			get;
		}

		[FieldProperty]
		public extern short Button
		{
			get;
		}

		[FieldProperty]
		public extern ushort Buttons
		{
			get;
		}

		[FieldProperty]
		public extern int ClientX
		{
			get;
		}

		[FieldProperty]
		public extern int ClientY
		{
			get;
		}

		[FieldProperty]
		public extern bool CtrlKey
		{
			get;
		}

		public extern bool GetModifierState(string keyArg);

		public extern void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, EventTarget relatedTargetArg);

		[FieldProperty]
		public extern bool MetaKey
		{
			get;
		}

		[FieldProperty]
		public extern EventTarget RelatedTarget
		{
			get;
		}

		[FieldProperty]
		public extern int ScreenX
		{
			get;
		}

		[FieldProperty]
		public extern int ScreenY
		{
			get;
		}

		[FieldProperty]
		public extern bool ShiftKey
		{
			get;
		}
	}
}
