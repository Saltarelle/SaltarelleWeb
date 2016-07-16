namespace Bridge.Html5
{
	[External, Serializable]
	public partial class CloseEventInit : EventInit
	{
		public extern ushort Code
		{
			get;
			set;
		}

		public extern string Reason
		{
			get;
			set;
		}

		public extern bool WasClean
		{
			get;
			set;
		}
	}
}
