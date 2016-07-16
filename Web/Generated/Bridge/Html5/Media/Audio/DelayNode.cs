namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DelayNode : AudioNode
	{
		internal extern DelayNode();

		public extern void AddEventListener(DelayNodeEvents type, Action listener);

		public extern void AddEventListener(DelayNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(DelayNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DelayNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DelayNodeEvents type, HtmlEventHandlerWithTarget<DelayNode> listener);

		public extern void AddEventListener(DelayNodeEvents type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture);

		public extern void AddEventListener(DelayNodeEvents type, IEventListener listener);

		public extern void AddEventListener(DelayNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture);

		[FieldProperty]
		public extern AudioParam DelayTime
		{
			get;
		}

		public extern void RemoveEventListener(DelayNodeEvents type, Action listener);

		public extern void RemoveEventListener(DelayNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DelayNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DelayNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DelayNodeEvents type, HtmlEventHandlerWithTarget<DelayNode> listener);

		public extern void RemoveEventListener(DelayNodeEvents type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture);

		public extern void RemoveEventListener(DelayNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(DelayNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DelayNode> listener, bool capture);
	}
}
