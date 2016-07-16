namespace Bridge.Html5
{
	[External, Serializable]
	public partial class ClipboardEventInit : EventInit
	{
		public string Data
		{
			get;
			set;
		}

		public string DataType
		{
			get;
			set;
		}
	}
}
