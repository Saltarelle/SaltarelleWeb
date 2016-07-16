using System.Collections.Generic;

namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class MessagePortList
	{
		internal MessagePortList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public MessagePort this[int index]
		{
			get {
				return default(MessagePort);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MessagePort> GetEnumerator()
		{
			return null;
		}

		public MessagePort Item(int index)
		{
			return default(MessagePort);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}
	}
}
