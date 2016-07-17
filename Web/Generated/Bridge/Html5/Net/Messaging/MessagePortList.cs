using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External, Name("Object")]
	public partial class MessagePortList : IEnumerable<MessagePort>
	{
		internal extern MessagePortList();

		public extern MessagePort this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<MessagePort> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern MessagePort Item(int index);

		public readonly int Length;
	}
}
