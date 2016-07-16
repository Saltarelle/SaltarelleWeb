namespace Bridge.Html5.Net
{
	[External, Serializable]
	public partial class ProgressEventInit : EventInit
	{
		public extern bool LengthComputable
		{
			get;
			set;
		}

		public extern ulong Loaded
		{
			get;
			set;
		}

		public extern ulong Total
		{
			get;
			set;
		}
	}
}
