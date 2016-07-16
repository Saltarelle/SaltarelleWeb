namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MessageChannel
	{
		public extern MessageChannel();

		[FieldProperty]
		public extern MessagePort Port1
		{
			get;
		}

		[FieldProperty]
		public extern MessagePort Port2
		{
			get;
		}
	}
}
