namespace Bridge.Html5.Data.Offline
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ApplicationCache : EventTarget
	{
		internal extern ApplicationCache();

		public extern void Abort();

		public extern void AddEventListener(ApplicationCacheEvents type, Action listener);

		public extern void AddEventListener(ApplicationCacheEvents type, Action listener, bool capture);

		public extern void AddEventListener(ApplicationCacheEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ApplicationCacheEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener);

		public extern void AddEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture);

		public extern void AddEventListener(ApplicationCacheEvents type, IEventListener listener);

		public extern void AddEventListener(ApplicationCacheEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture);

		public const ushort CHECKING = 2;

		public const ushort DOWNLOADING = 3;

		public const ushort IDLE = 1;

		public const ushort OBSOLETE = 5;

		[Name("oncached")]
		public HtmlEventHandler OnCached;

		[Name("onchecking")]
		public HtmlEventHandler OnChecking;

		[Name("ondownloading")]
		public HtmlEventHandler OnDownloading;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onnoupdate")]
		public HtmlEventHandler OnNoupdate;

		[Name("onobsolete")]
		public HtmlEventHandler OnObsolete;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		[Name("onupdateready")]
		public HtmlEventHandler OnUpdateready;

		public extern void RemoveEventListener(ApplicationCacheEvents type, Action listener);

		public extern void RemoveEventListener(ApplicationCacheEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener);

		public extern void RemoveEventListener(ApplicationCacheEvents type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture);

		public extern void RemoveEventListener(ApplicationCacheEvents type, IEventListener listener);

		public extern void RemoveEventListener(ApplicationCacheEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ApplicationCache> listener, bool capture);

		public readonly ApplicationCacheStatus Status;

		public extern void SwapCache();

		public const ushort UNCACHED = 0;

		public extern void Update();

		public const ushort UPDATEREADY = 4;
	}
}
