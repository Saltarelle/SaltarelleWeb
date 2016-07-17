using System;

namespace Bridge.Html5.Net.Messaging
{
	[Namespace(false), External]
	public partial class MessageEvent : Event
	{
		internal extern MessageEvent();

		public extern MessageEvent(string type);

		public extern MessageEvent(string type, MessageEventInit eventInitDict);

		public readonly object Data;

		public readonly string LastEventId;

		public readonly string Origin;

		public readonly MessagePortList Ports;

		public readonly TypeOption<WindowInstance, MessagePort> Source;
	}
}
