using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Security.Cryptography
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class Crypto : IRandomSource
	{
		internal Crypto()
		{
		}

		public ArrayBufferView GetRandomValues(ArrayBufferView array)
		{
			return default(ArrayBufferView);
		}
	}
}
