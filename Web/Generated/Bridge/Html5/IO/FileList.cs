using System.Collections.Generic;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileList
	{
		internal FileList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public File this[int index]
		{
			get {
				return default(File);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<File> GetEnumerator()
		{
			return null;
		}

		public File Item(int index)
		{
			return default(File);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}
	}
}
