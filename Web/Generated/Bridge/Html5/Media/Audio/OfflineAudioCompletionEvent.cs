namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class OfflineAudioCompletionEvent : Event
	{
		internal OfflineAudioCompletionEvent()
		{
		}

		[FieldProperty]
		public AudioBuffer RenderedBuffer
		{
			get {
				return default(AudioBuffer);
			}
		}
	}
}
