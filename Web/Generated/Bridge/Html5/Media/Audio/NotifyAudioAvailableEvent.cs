using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class NotifyAudioAvailableEvent : Event
	{
		internal NotifyAudioAvailableEvent()
		{
		}

		[FieldProperty]
		public Float32Array FrameBuffer
		{
			get {
				return default(Float32Array);
			}
		}

		public void InitAudioAvailableEvent(string type, bool canBubble, bool cancelable, double[] frameBuffer, int frameBufferLength, double time, bool allowAudioData)
		{
		}

		[FieldProperty]
		public double Time
		{
			get {
				return 0;
			}
		}
	}
}
