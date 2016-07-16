﻿using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ApplicationCache : EventTarget {
		internal ApplicationCache() {
		}

		public void Abort() {
		}

		public void AddEventListener(ApplicationCacheEvents type, Action listener) {
		}

		public void AddEventListener(ApplicationCacheEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(ApplicationCacheEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(ApplicationCacheEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener) {
		}

		public void AddEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture) {
		}

		public void AddEventListener(ApplicationCacheEvents type, IEventListener listener) {
		}

		public void AddEventListener(ApplicationCacheEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture) {
		}

		public const ushort CHECKING = 2;

		public const ushort DOWNLOADING = 3;

		public const ushort IDLE = 1;

		public const ushort OBSOLETE = 5;

		[IntrinsicProperty, ScriptName("oncached")]
		public HtmlEventHandler OnCached {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchecking")]
		public HtmlEventHandler OnChecking {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondownloading")]
		public HtmlEventHandler OnDownloading {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onnoupdate")]
		public HtmlEventHandler OnNoupdate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onobsolete")]
		public HtmlEventHandler OnObsolete {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public HtmlEventHandler OnProgress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onupdateready")]
		public HtmlEventHandler OnUpdateready {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(ApplicationCacheEvents type, Action listener) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(ApplicationCacheEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture) {
		}

		[IntrinsicProperty]
		public ApplicationCacheStatus Status {
			get {
				return default(ApplicationCacheStatus);
			}
		}

		public void SwapCache() {
		}

		public const ushort UNCACHED = 0;

		public void Update() {
		}

		public const ushort UPDATEREADY = 4;
	}
}
