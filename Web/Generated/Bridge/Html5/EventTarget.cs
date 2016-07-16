namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class EventTarget
	{
		internal EventTarget()
		{
		}

		public void AddEventListener(string type, IEventListener listener)
		{
		}

		public void AddEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted)
		{
		}

		public bool DispatchEvent(Event @event)
		{
			return false;
		}

		public void RemoveEventListener(string type, IEventListener listener)
		{
		}

		public void RemoveEventListener(string type, IEventListener listener, bool capture)
		{
		}
	}
}
