using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class WindowInstance {
		[IntrinsicProperty]
		public static object DialogArguments { get { return null; } }

		[IntrinsicProperty]
		public static object ReturnValue { get; set; }
	}
}