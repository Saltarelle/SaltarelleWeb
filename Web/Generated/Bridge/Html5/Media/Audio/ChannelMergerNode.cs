namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class ChannelMergerNode : AudioNode
	{
		internal extern ChannelMergerNode();

		public extern void AddEventListener(ChannelMergerNodeEvents type, Action listener);

		public extern void AddEventListener(ChannelMergerNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(ChannelMergerNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ChannelMergerNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ChannelMergerNodeEvents type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener);

		public extern void AddEventListener(ChannelMergerNodeEvents type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener, bool capture);

		public extern void AddEventListener(ChannelMergerNodeEvents type, IEventListener listener);

		public extern void AddEventListener(ChannelMergerNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener, bool capture);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, Action listener);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener, bool capture);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(ChannelMergerNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ChannelMergerNode> listener, bool capture);
	}
}
