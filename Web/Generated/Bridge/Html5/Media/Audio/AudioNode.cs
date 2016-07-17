namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioNode : EventTarget
	{
		internal extern AudioNode();

		public extern void AddEventListener(AudioNodeEvents type, Action listener);

		public extern void AddEventListener(AudioNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener);

		public extern void AddEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture);

		public extern void AddEventListener(AudioNodeEvents type, IEventListener listener);

		public extern void AddEventListener(AudioNodeEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture);

		public int ChannelCount;

		public ChannelCountMode ChannelCountMode;

		public ChannelInterpretation ChannelInterpretation;

		public extern void Connect(AudioNode destination);

		public extern void Connect(AudioNode destination, int output);

		public extern void Connect(AudioNode destination, int output, int input);

		public extern void Connect(AudioParam destination);

		public extern void Connect(AudioParam destination, int output);

		public readonly AudioContext Context;

		public extern void Disconnect();

		public extern void Disconnect(int output);

		public readonly int NumberOfInputs;

		public readonly int NumberOfOutputs;

		public extern void RemoveEventListener(AudioNodeEvents type, Action listener);

		public extern void RemoveEventListener(AudioNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener);

		public extern void RemoveEventListener(AudioNodeEvents type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture);

		public extern void RemoveEventListener(AudioNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioNodeEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioNode> listener, bool capture);
	}
}
