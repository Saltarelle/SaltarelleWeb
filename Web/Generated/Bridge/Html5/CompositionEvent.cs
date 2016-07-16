namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CompositionEvent : UIEvent
	{
		internal CompositionEvent()
		{
		}

		[FieldProperty]
		public string Data
		{
			get {
				return null;
			}
		}

		public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, string dataArg, string localeArg)
		{
		}

		[FieldProperty]
		public string Locale
		{
			get {
				return null;
			}
		}
	}
}
