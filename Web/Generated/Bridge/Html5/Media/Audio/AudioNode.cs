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

		[FieldProperty]
		public extern int ChannelCount
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ChannelCountMode ChannelCountMode
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ChannelInterpretation ChannelInterpretation
		{
			get;
			set;
		}

		public extern void Connect(AudioNode destination);

		public extern void Connect(AudioNode destination, int output);

		public extern void Connect(AudioNode destination, int output, int input);

		public extern void Connect(AudioParam destination);

		public extern void Connect(AudioParam destination, int output);

		[FieldProperty]
		public extern AudioContext Context
		{
			get;
		}

		public extern void Disconnect();

		public extern void Disconnect(int output);

		[FieldProperty]
		public extern int NumberOfInputs
		{
			get;
		}

		[FieldProperty]
		public extern int NumberOfOutputs
		{
			get;
		}

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
