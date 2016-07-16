using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Text
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextDecoder
	{
		public extern TextDecoder();

		public extern TextDecoder(string label);

		public extern TextDecoder(string label, TextDecoderOptions options);

		public extern string Decode();

		public extern string Decode(ArrayBufferView input);

		public extern string Decode(ArrayBufferView input, TextDecodeOptions options);

		[FieldProperty]
		public extern string Encoding
		{
			get;
		}
	}
}
