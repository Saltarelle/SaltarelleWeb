using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography {
	[IgnoreNamespace, Imported]
	public partial interface IRandomSource {
		ArrayBufferView GetRandomValues(ArrayBufferView array);
	}
}
