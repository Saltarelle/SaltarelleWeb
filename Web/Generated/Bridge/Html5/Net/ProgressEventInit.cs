namespace Bridge.Html5.Net
{
	[External, Serializable]
	public partial class ProgressEventInit : EventInit
	{
		public bool LengthComputable;

		public ulong Loaded;

		public ulong Total;
	}
}
