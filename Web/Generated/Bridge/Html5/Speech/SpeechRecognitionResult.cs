using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResult
	{
		internal extern SpeechRecognitionResult();

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionAlternative this[int index]
		{
			get;
		}

		[FieldProperty]
		public extern bool Final
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<SpeechRecognitionAlternative> GetEnumerator();

		public extern SpeechRecognitionAlternative Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
