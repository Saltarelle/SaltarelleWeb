using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NotifyAudioAvailableEvent : Event
	{
		internal extern NotifyAudioAvailableEvent();

		public readonly Float32Array FrameBuffer;

		public extern void InitAudioAvailableEvent(string type, bool canBubble, bool cancelable, double[] frameBuffer, int frameBufferLength, double time, bool allowAudioData);

		public readonly double Time;
	}
}
