using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Security.Cryptography
{
	[Namespace(false), External]
	public partial interface IRandomSource
	{
		ArrayBufferView GetRandomValues(ArrayBufferView array);
	}
}
