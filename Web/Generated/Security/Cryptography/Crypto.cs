using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Security.Cryptography {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Crypto : IRandomSource {
		internal Crypto() {
		}

		public ArrayBufferView GetRandomValues(ArrayBufferView array) {
			return default(ArrayBufferView);
		}
	}
}
