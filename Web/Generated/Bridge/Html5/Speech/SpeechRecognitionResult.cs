using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External]
	public partial class SpeechRecognitionResult : IEnumerable<SpeechRecognitionAlternative>
	{
		internal extern SpeechRecognitionResult();

		public extern SpeechRecognitionAlternative this[int index]
		{
			get;
		}

		public readonly bool Final;

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SpeechRecognitionAlternative> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SpeechRecognitionAlternative Item(int index);

		public readonly int Length;
	}
}
