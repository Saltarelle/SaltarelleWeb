namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class OfflineAudioCompletionEvent : Event
	{
		internal extern OfflineAudioCompletionEvent();

		public readonly AudioBuffer RenderedBuffer;
	}
}
