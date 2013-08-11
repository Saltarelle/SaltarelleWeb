namespace System.Html {
	public partial class Document {
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


		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {}
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {}
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener) {}
		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture) {}
	}
}