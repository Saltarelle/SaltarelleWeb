// SharedWorkerGlobalScope.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Data.Offline;
using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[GlobalMethods, Imported]
	public static partial class SharedWorkerGlobalScope {
		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		[IntrinsicProperty]
		public static ApplicationCache ApplicationCache {
			get { return default(ApplicationCache); }
		}

		public static string Atob(string stringToEncode) {
			return null;
		}

		public static string Btoa(string encodedString) {
			return null;
		}

		public static void ClearInterval(int intervalId) {
		}

		public static void ClearTimeout(int timeoutId) {
		}

		public static void Close() {
		}

		public static bool DispatchEvent(Event @event) {
			return false;
		}

		[ExpandParams]
		public static void ImportScripts(params string[] urls) {
		}

		[IntrinsicProperty]
		public static WorkerLocation Location {
			get { return default(WorkerLocation); }
		}

		[IntrinsicProperty]
		public static string Name {
			get { return null; }
		}

		[IntrinsicProperty]
		public static WorkerNavigator Navigator {
			get { return default(WorkerNavigator); }
		}

		[IntrinsicProperty, ScriptName("onconnect")]
		public static HtmlEventHandler OnConnect {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public static ErrorEventHandler OnError {
			get { return default(ErrorEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onoffline")]
		public static HtmlEventHandler OnOffline {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("ononline")]
		public static HtmlEventHandler OnOnline {
			get { return default(HtmlEventHandler); }
			set { }
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public static WorkerGlobalScope Self {
			get { return default(WorkerGlobalScope); }
		}

		public static int SetInterval(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetInterval(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetInterval(string code) {
			return 0;
		}

		public static int SetInterval(string code, int delay) {
			return 0;
		}

		public static int SetTimeout(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetTimeout(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetTimeout(string code) {
			return 0;
		}

		public static int SetTimeout(string code, int delay) {
			return 0;
		}

		public static string ToNativeLineEndings(string @string) {
			return null;
		}
	}
}
