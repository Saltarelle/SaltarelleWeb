namespace Bridge.Html5
{
	[External, Serializable]
	public partial class CloseEventInit : EventInit
	{
		public ushort Code;

		public string Reason;

		public bool WasClean;
	}
}
