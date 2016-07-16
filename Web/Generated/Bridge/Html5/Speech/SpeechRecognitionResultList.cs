using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResultList
	{
		internal SpeechRecognitionResultList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionResult this[int index]
		{
			get {
				return default(SpeechRecognitionResult);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionResult> GetEnumerator()
		{
			return null;
		}

		public SpeechRecognitionResult Item(int index)
		{
			return default(SpeechRecognitionResult);
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
