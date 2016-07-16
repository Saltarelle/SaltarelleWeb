using System;

namespace Bridge.Html5
{
	public delegate bool ErrorEventHandler(TypeOption<Event, string> @event, string source, int lineno, int column, object error);
}
