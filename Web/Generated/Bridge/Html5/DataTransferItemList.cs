using Bridge.Html5.IO;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransferItemList
	{
		internal extern DataTransferItemList();

		[IndexerName("__Item"), FieldProperty]
		public DataTransferItem this[int index]
		{
			get;
		}

		public extern DataTransferItem Add(File data);

		public extern DataTransferItem Add(string data, string type);

		public extern void Clear();

		public readonly int Length;

		public extern void Remove(int index);
	}
}
