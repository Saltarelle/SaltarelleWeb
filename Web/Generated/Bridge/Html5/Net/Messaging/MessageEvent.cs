using System;

namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MessageEvent : Event
	{
		internal extern MessageEvent();

		public extern MessageEvent(string type);

		public extern MessageEvent(string type, MessageEventInit eventInitDict);

		[FieldProperty]
		public extern object Data
		{
			get;
		}

		[FieldProperty]
		public extern string LastEventId
		{
			get;
		}

		[FieldProperty]
		public extern string Origin
		{
			get;
		}

		[FieldProperty]
		public extern MessagePortList Ports
		{
			get;
		}

		[FieldProperty]
		public extern TypeOption<WindowInstance, MessagePort> Source
		{
			get;
		}
	}
}
