namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchEvent : UIEvent
	{
		internal extern TouchEvent();

		public readonly bool AltKey;

		public readonly TouchList ChangedTouches;

		public readonly bool CtrlKey;

		public extern void InitTouchEvent(string type, bool canBubble, bool cancelable, WindowInstance view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, TouchList touches, TouchList targetTouches, TouchList changedTouches);

		public readonly bool MetaKey;

		public readonly bool ShiftKey;

		public readonly TouchList TargetTouches;

		public readonly TouchList Touches;
	}
}
