namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class EventTarget
	{
		internal extern EventTarget();

		public extern void AddEventListener(string type, IEventListener listener);

		public extern void AddEventListener(string type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted);

		public extern bool DispatchEvent(Event @event);

		public extern void RemoveEventListener(string type, IEventListener listener);

		public extern void RemoveEventListener(string type, IEventListener listener, bool capture);
	}
}
