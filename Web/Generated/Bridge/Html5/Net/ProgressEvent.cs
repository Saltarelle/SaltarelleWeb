namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ProgressEvent : Event
	{
		internal extern ProgressEvent();

		public extern ProgressEvent(string type);

		public extern ProgressEvent(string type, ProgressEventInit eventInitDict);

		[FieldProperty]
		public extern bool LengthComputable
		{
			get;
		}

		[FieldProperty]
		public extern ulong Loaded
		{
			get;
		}

		[FieldProperty]
		public extern ulong Total
		{
			get;
		}
	}
}
