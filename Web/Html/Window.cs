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


		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {}
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {}
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {}
		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {}
	}
}