using System.Collections.Generic;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class FileList
	{
		internal extern FileList();

		[IndexerName("__Item"), FieldProperty]
		public File this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<File> GetEnumerator();

		public extern File Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
