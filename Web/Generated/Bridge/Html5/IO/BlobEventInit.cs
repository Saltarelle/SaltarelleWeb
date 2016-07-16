namespace Bridge.Html5.IO
{
	[External, Serializable]
	public partial class BlobEventInit : EventInit
	{
		public extern Blob Data
		{
			get;
			set;
		}
	}
}
