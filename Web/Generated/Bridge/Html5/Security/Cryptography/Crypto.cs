using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Security.Cryptography
{
	[Namespace(false), External]
	public partial class Crypto : IRandomSource
	{
		internal extern Crypto();

		public extern ArrayBufferView GetRandomValues(ArrayBufferView array);
	}
}
