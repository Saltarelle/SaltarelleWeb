namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class DynamicsCompressorNode : AudioNode
	{
		internal extern DynamicsCompressorNode();

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, Action listener);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, IEventListener listener);

		public extern void AddEventListener(DynamicsCompressorNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture);

		public readonly AudioParam Attack;

		public readonly AudioParam Knee;

		public readonly AudioParam Ratio;

		public readonly AudioParam Reduction;

		public readonly AudioParam Release;

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, Action listener);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(DynamicsCompressorNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DynamicsCompressorNode> listener, bool capture);

		public readonly AudioParam Threshold;
	}
}
