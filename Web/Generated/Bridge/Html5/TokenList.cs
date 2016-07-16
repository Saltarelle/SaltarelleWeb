using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("DOMTokenList")]
	public partial class TokenList
	{
		internal TokenList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public string this[int index]
		{
			get {
				return null;
			}
		}

		[ExpandParams]
		public void Add(params string[] tokens)
		{
		}

		public bool Contains(string token)
		{
			return false;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		public string Item(int index)
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

		[ExpandParams]
		public void Remove(params string[] tokens)
		{
		}

		public bool Toggle(string token)
		{
			return false;
		}

		public bool Toggle(string token, bool force)
		{
			return false;
		}
	}
}
