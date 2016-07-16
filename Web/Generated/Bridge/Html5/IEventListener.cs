namespace Bridge.Html5
{
	[External]
	public partial interface IEventListener
	{
		extern void HandleEvent(Event @event);
	}
}
