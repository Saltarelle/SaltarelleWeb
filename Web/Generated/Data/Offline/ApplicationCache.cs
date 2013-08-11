// ApplicationCache.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.Offline {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ApplicationCache : EventTarget {
		internal ApplicationCache() {
		}

		public void Abort() {
		}

		public const ushort CHECKING = 2;

		public const ushort DOWNLOADING = 3;

		public const ushort IDLE = 1;

		public const ushort OBSOLETE = 5;

		[IntrinsicProperty, ScriptName("oncached")]
		public HtmlEventHandler OnCached {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onchecking")]
		public HtmlEventHandler OnChecking {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("ondownloading")]
		public HtmlEventHandler OnDownloading {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onnoupdate")]
		public HtmlEventHandler OnNoupdate {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onobsolete")]
		public HtmlEventHandler OnObsolete {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public HtmlEventHandler OnProgress {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onupdateready")]
		public HtmlEventHandler OnUpdateready {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public ApplicationCacheStatus Status {
			get { return default(ApplicationCacheStatus); }
		}

		public void SwapCache() {
		}

		public const ushort UNCACHED = 0;

		public void Update() {
		}

		public const ushort UPDATEREADY = 4;
	}
}
