namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BeforeUnloadEvent : Event
	{
		internal extern BeforeUnloadEvent();

		[FieldProperty]
		public extern string ReturnValue
		{
			get;
			set;
		}
	}
}
