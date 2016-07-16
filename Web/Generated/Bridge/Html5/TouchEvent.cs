namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchEvent : UIEvent
	{
		internal extern TouchEvent();

		[FieldProperty]
		public extern bool AltKey
		{
			get;
		}

		[FieldProperty]
		public extern TouchList ChangedTouches
		{
			get;
		}

		[FieldProperty]
		public extern bool CtrlKey
		{
			get;
		}

		public extern void InitTouchEvent(string type, bool canBubble, bool cancelable, WindowInstance view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, TouchList touches, TouchList targetTouches, TouchList changedTouches);

		[FieldProperty]
		public extern bool MetaKey
		{
			get;
		}

		[FieldProperty]
		public extern bool ShiftKey
		{
			get;
		}

		[FieldProperty]
		public extern TouchList TargetTouches
		{
			get;
		}

		[FieldProperty]
		public extern TouchList Touches
		{
			get;
		}
	}
}
