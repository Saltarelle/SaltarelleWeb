using System.Xml;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Window {
		public static void AddEventListener(string type, Action listener) {}
		public static void AddEventListener(string type, Action listener, bool capture) {}
		public static void AddEventListener(string type, Action listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, Action listener) {}
		public static void RemoveEventListener(string type, Action listener, bool capture) {}


		public static void AddEventListener(string type, HtmlEventHandler listener) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, HtmlEventHandler listener) {}
		public static void RemoveEventListener(string type, HtmlEventHandler listener, bool capture) {}

		[IntrinsicProperty]
		public static object DialogArguments { get { return null; } }

		[IntrinsicProperty]
		public static object ReturnValue { get; set; }

		[IntrinsicProperty]
		public static DocumentBase Document { get { return null; } }
	}
}