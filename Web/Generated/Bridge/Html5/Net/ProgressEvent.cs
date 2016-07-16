namespace Bridge.Html5.Net
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ProgressEvent : Event
	{
		internal ProgressEvent()
		{
		}

		public ProgressEvent(string type)
		{
		}

		public ProgressEvent(string type, ProgressEventInit eventInitDict)
		{
		}

		[FieldProperty]
		public bool LengthComputable
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public ulong Loaded
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public ulong Total
		{
			get {
				return 0;
			}
		}
	}
}
