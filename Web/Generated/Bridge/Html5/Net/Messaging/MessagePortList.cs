namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class MessagePortList
	{
		internal extern MessagePortList();

		[IndexerName("__Item"), FieldProperty]
		public MessagePort this[int index]
		{
			get;
		}

		public extern MessagePort Item(int index);

		public readonly int Length;
	}
}
