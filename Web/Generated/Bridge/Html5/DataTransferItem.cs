using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransferItem
	{
		internal DataTransferItem()
		{
		}

		public File GetAsFile()
		{
			return default(File);
		}

		public void GetAsString(Action<string> callback)
		{
		}

		[FieldProperty]
		public DataTransferItemKind Kind
		{
			get {
				return default(DataTransferItemKind);
			}
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
		}
	}
}
