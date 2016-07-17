namespace Bridge.Html5.WebComponents
{
	[Namespace(false), External]
	public partial class ElementReplaceEvent : Event
	{
		internal extern ElementReplaceEvent();

		public extern ElementReplaceEvent(string type);

		public extern ElementReplaceEvent(string type, ElementReplaceEventInit eventInitDict);

		public extern void InitElementReplaceEvent(string type, bool canBubble, bool cancelable, Element upgrade);

		public readonly Element Upgrade;
	}
}
