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

		[FieldProperty, Name("oncached")]
		public extern HtmlEventHandler OnCached
		{
			get;
			set;
		}

		[FieldProperty, Name("onchecking")]
		public extern HtmlEventHandler OnChecking
		{
			get;
			set;
		}

		[FieldProperty, Name("ondownloading")]
		public extern HtmlEventHandler OnDownloading
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onnoupdate")]
		public extern HtmlEventHandler OnNoupdate
		{
			get;
			set;
		}

		[FieldProperty, Name("onobsolete")]
		public extern HtmlEventHandler OnObsolete
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		[FieldProperty, Name("onupdateready")]
		public extern HtmlEventHandler OnUpdateready
		{
			get;
			set;
		}

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

		[FieldProperty]
		public extern ApplicationCacheStatus Status
		{
			get;
		}

		public extern void SwapCache();

		public const ushort UNCACHED = 0;

		public extern void Update();

		public const ushort UPDATEREADY = 4;
	}
}
