namespace Bridge.Html5.Speech
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SpeechGrammar
	{
		public extern SpeechGrammar();

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double Weight
		{
			get;
			set;
		}
	}
}
