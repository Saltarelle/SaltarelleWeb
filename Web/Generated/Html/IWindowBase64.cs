using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported]
	public partial interface IWindowBase64 {
		string Atob(string stringToEncode);

		string Btoa(string encodedString);
	}
}
