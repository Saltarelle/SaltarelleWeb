namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioProcessingEvent : Event
	{
		internal AudioProcessingEvent()
		{
		}

		[FieldProperty]
		public AudioBuffer InputBuffer
		{
			get {
				return default(AudioBuffer);
			}
		}

		[FieldProperty]
		public AudioBuffer OutputBuffer
		{
			get {
				return default(AudioBuffer);
			}
		}

		[FieldProperty]
		public double PlaybackTime
		{
			get {
				return 0;
			}
		}
	}
}
