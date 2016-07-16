namespace Bridge.Html5.Net
{
	[External, Serializable]
	public partial class ProgressEventInit : EventInit
	{
		public bool LengthComputable
		{
			get;
			set;
		}

		public ulong Loaded
		{
			get;
			set;
		}

		public ulong Total
		{
			get;
			set;
		}
	}
}
