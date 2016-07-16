namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class OfflineAudioCompletionEvent : Event
	{
		internal extern OfflineAudioCompletionEvent();

		[FieldProperty]
		public extern AudioBuffer RenderedBuffer
		{
			get;
		}
	}
}
