namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FocusEvent : UIEvent
	{
		internal extern FocusEvent();

		public extern FocusEvent(string typeArg);

		public extern FocusEvent(string typeArg, FocusEventInit focusEventInitDict);

		public readonly EventTarget RelatedTarget;
	}
}
