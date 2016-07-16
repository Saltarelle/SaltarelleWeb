using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Text
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextEncoder
	{
		public extern TextEncoder();

		public extern TextEncoder(string utfLabel);

		public extern Uint8Array Encode();

		public extern Uint8Array Encode(string input);

		public extern Uint8Array Encode(string input, TextEncodeOptions options);

		[FieldProperty]
		public extern string Encoding
		{
			get;
		}
	}
}
