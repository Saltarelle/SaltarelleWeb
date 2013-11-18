using System.Xml;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class WindowInstance {
		[IntrinsicProperty]
		public object DialogArguments { get { return null; } }

		[IntrinsicProperty]
		public object ReturnValue { get; set; }

		[IntrinsicProperty]
		public DocumentBase Document { get { return default(DocumentBase); } }
	}
}