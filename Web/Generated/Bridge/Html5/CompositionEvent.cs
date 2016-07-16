namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CompositionEvent : UIEvent
	{
		internal extern CompositionEvent();

		[FieldProperty]
		public extern string Data
		{
			get;
		}

		public extern void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, string dataArg, string localeArg);

		[FieldProperty]
		public extern string Locale
		{
			get;
		}
	}
}
