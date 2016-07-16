namespace Bridge.Html5
{
	[External, Serializable]
	public partial class ClipboardEventInit : EventInit
	{
		public extern string Data
		{
			get;
			set;
		}

		public extern string DataType
		{
			get;
			set;
		}
	}
}
