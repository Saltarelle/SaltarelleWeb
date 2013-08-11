using System.Runtime.CompilerServices;

namespace System.Html {
	[Imported]
	public partial interface IEventListener {
		void HandleEvent(Event @event);
	}
}
