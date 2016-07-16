using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechGrammarList
	{
		internal SpeechGrammarList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SpeechGrammar this[int index]
		{
			get {
				return default(SpeechGrammar);
			}
		}

		public void AddFromString(string @string)
		{
		}

		public void AddFromString(string @string, double weight)
		{
		}

		public void AddFromURI(string src)
		{
		}

		public void AddFromURI(string src, double weight)
		{
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechGrammar> GetEnumerator()
		{
			return null;
		}

		public SpeechGrammar Item(int index)
		{
			return default(SpeechGrammar);
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
