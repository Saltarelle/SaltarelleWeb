namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class CloseEvent : Event
	{
		internal extern CloseEvent();

		public extern CloseEvent(string type);

		public extern CloseEvent(string type, CloseEventInit eventInitDict);

		[FieldProperty]
		public extern ushort Code
		{
			get;
		}

		public extern void InitCloseEvent(string type, bool canBubble, bool cancelable, bool wasClean, ushort code, string reason);

		[FieldProperty]
		public extern string Reason
		{
			get;
		}

		[FieldProperty]
		public extern bool WasClean
		{
			get;
		}
	}
}
