using Bridge.Html5.IO;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DataTransferItemList
	{
		internal DataTransferItemList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public DataTransferItem this[int index]
		{
			get {
				return default(DataTransferItem);
			}
		}

		public DataTransferItem Add(File data)
		{
			return default(DataTransferItem);
		}

		public DataTransferItem Add(string data, string type)
		{
			return default(DataTransferItem);
		}

		public void Clear()
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<DataTransferItem> GetEnumerator()
		{
			return null;
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public void Remove(int index)
		{
		}
	}
}
