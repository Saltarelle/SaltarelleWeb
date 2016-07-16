using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResultList
	{
		internal extern SpeechRecognitionResultList();

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionResult this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<SpeechRecognitionResult> GetEnumerator();

		public extern SpeechRecognitionResult Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
