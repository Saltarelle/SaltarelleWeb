using System;

namespace Bridge.Html5.Net.Messaging
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MessageEvent : Event
	{
		internal MessageEvent()
		{
		}

		public MessageEvent(string type)
		{
		}

		public MessageEvent(string type, MessageEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public object Data
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string LastEventId
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public string Origin
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public MessagePortList Ports
		{
			get {
				return default(MessagePortList);
			}
		}

		[FieldProperty]
		public TypeOption<WindowInstance, MessagePort> Source
		{
			get {
				return default(TypeOption<WindowInstance, MessagePort>);
			}
		}
	}
}
