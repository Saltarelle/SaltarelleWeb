namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioProcessingEvent : Event
	{
		internal extern AudioProcessingEvent();

		[FieldProperty]
		public extern AudioBuffer InputBuffer
		{
			get;
		}

		[FieldProperty]
		public extern AudioBuffer OutputBuffer
		{
			get;
		}

		[FieldProperty]
		public extern double PlaybackTime
		{
			get;
		}
	}
}
