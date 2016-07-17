namespace Bridge.Html5
{
	[Namespace("false"), External, Name("Element")]
	public partial class MapElement : Element
	{
		internal extern MapElement();

		public extern void AddEventListener(MapElementEvents type, Action listener);

		public extern void AddEventListener(MapElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(MapElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(MapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(MapElementEvents type, HtmlEventHandlerWithTarget<MapElement> listener);

		public extern void AddEventListener(MapElementEvents type, HtmlEventHandlerWithTarget<MapElement> listener, bool capture);

		public extern void AddEventListener(MapElementEvents type, IEventListener listener);

		public extern void AddEventListener(MapElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MapElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<MapElement> listener, bool capture);

		public readonly ElementCollection Areas;

		public string Name;

		public extern void RemoveEventListener(MapElementEvents type, Action listener);

		public extern void RemoveEventListener(MapElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(MapElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(MapElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(MapElementEvents type, HtmlEventHandlerWithTarget<MapElement> listener);

		public extern void RemoveEventListener(MapElementEvents type, HtmlEventHandlerWithTarget<MapElement> listener, bool capture);

		public extern void RemoveEventListener(MapElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(MapElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MapElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<MapElement> listener, bool capture);
	}
}
