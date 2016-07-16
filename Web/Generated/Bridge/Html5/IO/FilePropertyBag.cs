namespace Bridge.Html5.IO
{
	[External, Serializable]
	public partial class FilePropertyBag : BlobPropertyBag
	{
		public extern string Name
		{
			get;
			set;
		}
	}
}
