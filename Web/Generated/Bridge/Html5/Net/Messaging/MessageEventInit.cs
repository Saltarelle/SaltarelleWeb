using System;

namespace Bridge.Html5.Net.Messaging
{
	[External, Serializable]
	public partial class MessageEventInit : EventInit
	{
		public object Data
		{
			get;
			set;
		}

		public string LastEventId
		{
			get;
			set;
		}

		public string Origin
		{
			get;
			set;
		}

		public MessagePort[] Ports
		{
			get;
			set;
		}

		public TypeOption<WindowInstance, MessagePort> Source
		{
			get;
			set;
		}
	}
}
