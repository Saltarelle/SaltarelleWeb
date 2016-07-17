namespace Bridge.Html5.Media.Audio
{
	[Namespace(false), External]
	public partial class OfflineAudioCompletionEvent : Event
	{
		internal extern OfflineAudioCompletionEvent();

		public readonly AudioBuffer RenderedBuffer;
	}
}
