namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CustomEvent : Event
	{
		internal CustomEvent()
		{
		}

		public CustomEvent(string type)
		{
		}

		public CustomEvent(string type, CustomEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public object Detail
		{
			get {
				return null;
			}
		}

		public void InitCustomEvent(string type, bool canBubble, bool cancelable, object detail)
		{
		}
	}
}
