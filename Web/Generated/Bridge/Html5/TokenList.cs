using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("DOMTokenList")]
	public partial class TokenList
	{
		internal extern TokenList();

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get;
		}

		[ExpandParams]
		public extern void Add(params string[] tokens);

		public extern bool Contains(string token);

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<string> GetEnumerator();

		public extern string Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[ExpandParams]
		public extern void Remove(params string[] tokens);

		public extern bool Toggle(string token);

		public extern bool Toggle(string token, bool force);
	}
}
