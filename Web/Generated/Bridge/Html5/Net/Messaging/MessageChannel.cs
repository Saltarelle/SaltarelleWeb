namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MessageChannel
	{
		public MessageChannel()
		{
		}

		[FieldProperty]
		public MessagePort Port1
		{
			get {
				return default(MessagePort);
			}
		}

		[FieldProperty]
		public MessagePort Port2
		{
			get {
				return default(MessagePort);
			}
		}
	}
}
