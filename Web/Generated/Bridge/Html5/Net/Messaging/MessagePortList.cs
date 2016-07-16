using System.Collections.Generic;

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

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<MessagePort> GetEnumerator();

		public extern MessagePort Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
