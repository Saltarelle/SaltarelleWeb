namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MouseEvent : UIEvent
	{
		internal MouseEvent()
		{
		}

		public MouseEvent(string typeArg)
		{
		}

		public MouseEvent(string typeArg, MouseEventInit mouseEventInitDict)
		{
		}

		[FieldProperty]
		public bool AltKey
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public short Button
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public ushort Buttons
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int ClientX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int ClientY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public bool CtrlKey
		{
			get {
				return false;
			}
		}

		public bool GetModifierState(string keyArg)
		{
			return false;
		}

		public void InitMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, EventTarget relatedTargetArg)
		{
		}

		[FieldProperty]
		public bool MetaKey
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public EventTarget RelatedTarget
		{
			get {
				return default(EventTarget);
			}
		}

		[FieldProperty]
		public int ScreenX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int ScreenY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public bool ShiftKey
		{
			get {
				return false;
			}
		}
	}
}
