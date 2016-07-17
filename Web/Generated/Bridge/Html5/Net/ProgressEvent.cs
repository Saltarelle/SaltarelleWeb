namespace Bridge.Html5.Net
{
	[Namespace(false), External]
	public partial class ProgressEvent : Event
	{
		internal extern ProgressEvent();

		public extern ProgressEvent(string type);

		public extern ProgressEvent(string type, ProgressEventInit eventInitDict);

		public readonly bool LengthComputable;

		public readonly ulong Loaded;

		public readonly ulong Total;
	}
}
