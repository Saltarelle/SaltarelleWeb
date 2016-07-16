using System.Collections.Generic;

namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechRecognitionResult
	{
		internal SpeechRecognitionResult()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public SpeechRecognitionAlternative this[int index]
		{
			get {
				return default(SpeechRecognitionAlternative);
			}
		}

		[FieldProperty]
		public bool Final
		{
			get {
				return false;
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SpeechRecognitionAlternative> GetEnumerator()
		{
			return null;
		}

		public SpeechRecognitionAlternative Item(int index)
		{
			return default(SpeechRecognitionAlternative);
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
