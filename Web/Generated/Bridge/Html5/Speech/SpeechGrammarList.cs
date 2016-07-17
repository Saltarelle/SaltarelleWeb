namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechGrammarList
	{
		internal extern SpeechGrammarList();

		[IndexerName("__Item"), FieldProperty]
		public SpeechGrammar this[int index]
		{
			get;
		}

		public extern void AddFromString(string @string);

		public extern void AddFromString(string @string, double weight);

		public extern void AddFromURI(string src);

		public extern void AddFromURI(string src, double weight);

		public extern SpeechGrammar Item(int index);

		public readonly int Length;
	}
}
