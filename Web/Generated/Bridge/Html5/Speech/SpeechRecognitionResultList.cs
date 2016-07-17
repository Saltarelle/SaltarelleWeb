using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External]
	public partial class SpeechRecognitionResultList : IEnumerable<SpeechRecognitionResult>
	{
		internal extern SpeechRecognitionResultList();

		public extern SpeechRecognitionResult this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<SpeechRecognitionResult> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern SpeechRecognitionResult Item(int index);

		public readonly int Length;
	}
}
