using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NotifyAudioAvailableEvent : Event
	{
		internal extern NotifyAudioAvailableEvent();

		[FieldProperty]
		public extern Float32Array FrameBuffer
		{
			get;
		}

		public extern void InitAudioAvailableEvent(string type, bool canBubble, bool cancelable, double[] frameBuffer, int frameBufferLength, double time, bool allowAudioData);

		[FieldProperty]
		public extern double Time
		{
			get;
		}
	}
}
