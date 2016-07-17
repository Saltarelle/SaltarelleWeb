namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class ChannelSplitterNode : AudioNode
	{
		internal extern ChannelSplitterNode();

		public extern void AddEventListener(ChannelSplitterNodeEvents type, Action listener);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener, bool capture);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, IEventListener listener);

		public extern void AddEventListener(ChannelSplitterNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener, bool capture);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, Action listener);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener, bool capture);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(ChannelSplitterNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ChannelSplitterNode> listener, bool capture);
	}
}
