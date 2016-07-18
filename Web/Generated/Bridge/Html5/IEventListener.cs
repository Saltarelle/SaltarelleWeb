namespace Bridge.Html5
{
	[External, Name("Object")]
	public partial interface IEventListener
	{
		void HandleEvent(Event @event);
	}
}
