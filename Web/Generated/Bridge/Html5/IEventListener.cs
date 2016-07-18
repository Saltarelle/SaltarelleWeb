namespace Bridge.Html5
{
	[External, Name("Object"), ExternalInterface]
	public partial interface IEventListener
	{
		void HandleEvent(Event @event);
	}
}
