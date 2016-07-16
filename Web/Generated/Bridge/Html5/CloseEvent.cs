namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CloseEvent : Event
	{
		internal CloseEvent()
		{
		}

		public CloseEvent(string type)
		{
		}

		public CloseEvent(string type, CloseEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public ushort Code
		{
			get {
				return 0;
			}
		}

		public void InitCloseEvent(string type, bool canBubble, bool cancelable, bool wasClean, ushort code, string reason)
		{
		}

		[FieldProperty]
		public string Reason
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool WasClean
		{
			get {
				return false;
			}
		}
	}
}
