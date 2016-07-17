using Bridge.Html5.IO;
using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DataTransferItemList : IEnumerable<DataTransferItem>
	{
		internal extern DataTransferItemList();

		public extern DataTransferItem this[int index]
		{
			get;
		}

		public extern DataTransferItem Add(File data);

		public extern DataTransferItem Add(string data, string type);

		public extern void Clear();

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<DataTransferItem> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public readonly int Length;

		public extern void Remove(int index);
	}
}
