namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioProcessingEvent : Event
	{
		internal extern AudioProcessingEvent();

		public readonly AudioBuffer InputBuffer;

		public readonly AudioBuffer OutputBuffer;

		public readonly double PlaybackTime;
	}
}
