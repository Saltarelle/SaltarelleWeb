using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Media.Graphics.WebGL;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class WaveShaperNode : AudioNode
	{
		internal extern WaveShaperNode();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture);

		public extern void AddEventListener(WaveShaperNodeEvents type, Action listener);

		public extern void AddEventListener(WaveShaperNodeEvents type, Action listener, bool capture);

		public extern void AddEventListener(WaveShaperNodeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(WaveShaperNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(WaveShaperNodeEvents type, HtmlEventHandlerWithTarget<WaveShaperNode> listener);

		public extern void AddEventListener(WaveShaperNodeEvents type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture);

		public extern void AddEventListener(WaveShaperNodeEvents type, IEventListener listener);

		public extern void AddEventListener(WaveShaperNodeEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern Float32Array Curve
		{
			get;
			set;
		}

		[FieldProperty]
		public extern OverSampleType Oversample
		{
			get;
			set;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, Action listener);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, HtmlEventHandlerWithTarget<WaveShaperNode> listener);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, HtmlEventHandlerWithTarget<WaveShaperNode> listener, bool capture);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, IEventListener listener);

		public extern void RemoveEventListener(WaveShaperNodeEvents type, IEventListener listener, bool capture);
	}
}
