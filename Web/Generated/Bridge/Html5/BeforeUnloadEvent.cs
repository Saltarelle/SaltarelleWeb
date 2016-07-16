namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class BeforeUnloadEvent : Event
	{
		internal BeforeUnloadEvent()
		{
		}

		[FieldProperty]
		public string ReturnValue
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
