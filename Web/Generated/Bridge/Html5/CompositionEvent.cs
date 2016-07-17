namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class CompositionEvent : UIEvent
	{
		internal extern CompositionEvent();

		public readonly string Data;

		public extern void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, WindowInstance viewArg, string dataArg, string localeArg);

		public readonly string Locale;
	}
}
