namespace Bridge.Html5
{
	[External, Serializable]
	public partial class CloseEventInit : EventInit
	{
		public ushort Code
		{
			get;
			set;
		}

		public string Reason
		{
			get;
			set;
		}

		public bool WasClean
		{
			get;
			set;
		}
	}
}
