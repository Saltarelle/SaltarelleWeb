using System;

namespace Bridge.Html5.Net.Messaging
{
	[External, Serializable]
	public partial class MessageEventInit : EventInit
	{
		public object Data;

		public string LastEventId;

		public string Origin;

		public MessagePort[] Ports;

		public TypeOption<WindowInstance, MessagePort> Source;
	}
}
