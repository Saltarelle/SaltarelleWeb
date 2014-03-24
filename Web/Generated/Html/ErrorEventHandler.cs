namespace System.Html {
	public delegate bool ErrorEventHandler(TypeOption<Event, string> @event, string source, uint lineno, uint column, object error);
}
