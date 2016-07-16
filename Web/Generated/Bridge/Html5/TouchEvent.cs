namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TouchEvent : UIEvent
	{
		internal TouchEvent()
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
		public TouchList ChangedTouches
		{
			get {
				return default(TouchList);
			}
		}

		[FieldProperty]
		public bool CtrlKey
		{
			get {
				return false;
			}
		}

		public void InitTouchEvent(string type, bool canBubble, bool cancelable, WindowInstance view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, TouchList touches, TouchList targetTouches, TouchList changedTouches)
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
		public bool ShiftKey
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public TouchList TargetTouches
		{
			get {
				return default(TouchList);
			}
		}

		[FieldProperty]
		public TouchList Touches
		{
			get {
				return default(TouchList);
			}
		}
	}
}
