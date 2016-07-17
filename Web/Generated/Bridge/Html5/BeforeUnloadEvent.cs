namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class BeforeUnloadEvent : Event
	{
		internal extern BeforeUnloadEvent();

		public string ReturnValue;
	}
}
