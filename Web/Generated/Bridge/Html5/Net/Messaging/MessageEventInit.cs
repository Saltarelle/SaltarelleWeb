using System;

namespace Bridge.Html5.Net.Messaging
{
	[External, Serializable]
	public partial class MessageEventInit : EventInit
	{
		public extern object Data
		{
			get;
			set;
		}

		public extern string LastEventId
		{
			get;
			set;
		}

		public extern string Origin
		{
			get;
			set;
		}

		public extern MessagePort[] Ports
		{
			get;
			set;
		}

		public extern TypeOption<WindowInstance, MessagePort> Source
		{
			get;
			set;
		}
	}
}
