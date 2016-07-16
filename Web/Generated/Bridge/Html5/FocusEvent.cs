namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FocusEvent : UIEvent
	{
		internal FocusEvent()
		{
		}

		public FocusEvent(string typeArg)
		{
		}

		public FocusEvent(string typeArg, FocusEventInit focusEventInitDict)
		{
		}

		[FieldProperty]
		public EventTarget RelatedTarget
		{
			get {
				return default(EventTarget);
			}
		}
	}
}
