using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace(false), External]
	public partial class SpeechGrammarList : IEnumerable<SpeechGrammar>
	{
		internal extern SpeechGrammarList();

		public extern SpeechGrammar this[int index]
		{
			get;
		}

		public extern void AddFromString(string @string);

		public extern void AddFromString(string @string, double weight);

		public extern void AddFromURI(string src);

		public extern void AddFromURI(string src, double weight);

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SpeechGrammar> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SpeechGrammar Item(int index);

		public readonly int Length;
	}
}
