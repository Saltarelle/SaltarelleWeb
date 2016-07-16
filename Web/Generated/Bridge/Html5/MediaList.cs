using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class MediaList
	{
		internal extern MediaList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		public extern void AppendMedium(string newMedium);

		public extern void DeleteMedium(string oldMedium);

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern string Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern string MediaText
		{
			get;
			set;
		}
	}
}
