namespace Bridge.Html5.WebComponents
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ElementReplaceEvent : Event
	{
		internal ElementReplaceEvent()
		{
		}

		public ElementReplaceEvent(string type)
		{
		}

		public ElementReplaceEvent(string type, ElementReplaceEventInit eventInitDict)
		{
		}

		public void InitElementReplaceEvent(string type, bool canBubble, bool cancelable, Element upgrade)
		{
		}

		[FieldProperty]
		public Element Upgrade
		{
			get {
				return default(Element);
			}
		}
	}
}
