using Bridge.Html5.Data.IndexedDB;
using Bridge.Html5.Data.Offline;
using Bridge.Html5.Data.WebStorage;
using Bridge.Html5.Editing;
using Bridge.Html5.Performance;
using Bridge.Html5.Security.Cryptography;
using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[External, Namespace(false), Name("window")]
	public static partial class Window
	{
		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public static extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture);

		public static extern void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted);

		public static extern void AddEventListener(WindowInstanceEvents type, Action listener);

		public static extern void AddEventListener(WindowInstanceEvents type, Action listener, bool capture);

		public static extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener);

		public static extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture);

		public static extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public static extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public static extern void AddEventListener(WindowInstanceEvents type, IEventListener listener);

		public static extern void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture);

		public static extern void Alert();

		public static extern void Alert(string message);

		public static readonly ApplicationCache ApplicationCache;

		public static extern string Atob(string atob);

		public static extern void Back();

		public static extern void Blur();

		public static extern string Btoa(string btoa);

		public static extern void CancelAnimationFrame(int handle);

		public static extern void CaptureEvents();

		public static extern void Close();

		public static readonly bool Closed;

		public static extern bool Confirm();

		public static extern bool Confirm(string message);

		public static readonly object Content;

		public static readonly Crypto Crypto;

		public static readonly double DevicePixelRatio;

		public static extern bool DispatchEvent(Event @event);

		public static extern void Dump(string str);

		public static extern bool Find();

		public static extern bool Find(string str);

		public static extern bool Find(string str, bool caseSensitive);

		public static extern bool Find(string str, bool caseSensitive, bool backwards);

		public static extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround);

		public static extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord);

		public static extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames);

		public static extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog);

		public static extern void Focus();

		public static extern void Forward();

		public static readonly Element FrameElement;

		public static readonly XmlElement[] Frames;

		public static bool FullScreen;

		public static extern Style GetComputedStyle(Element elt);

		public static extern Style GetComputedStyle(Element elt, string pseudoElt);

		public static extern Style GetDefaultComputedStyle(Element elt);

		public static extern Style GetDefaultComputedStyle(Element elt, string pseudoElt);

		public static extern Selection GetSelection();

		public static readonly History History;

		public static extern void Home();

		public static readonly Factory IndexedDB;

		public static int InnerHeight;

		public static int InnerWidth;

		[Name("window")]
		public static readonly WindowInstance Instance;

		public static readonly int Length;

		public static readonly Storage LocalStorage;

		public static readonly Location Location;

		public static readonly BarProp Locationbar;

		public static extern MediaQueryList MatchMedia(string query);

		public static readonly BarProp Menubar;

		public static extern void MoveBy(int x, int y);

		public static extern void MoveTo(int x, int y);

		public static string Name;

		public static readonly NavigatorInstance Navigator;

		[Name("onabort")]
		public static HtmlEventHandler OnAbort;

		[Name("onafterprint")]
		public static HtmlEventHandler OnAfterprint;

		[Name("onbeforeprint")]
		public static HtmlEventHandler OnBeforeprint;

		[Name("onbeforeunload")]
		public static BeforeUnloadEventHandler OnBeforeunload;

		[Name("onblur")]
		public static HtmlEventHandler OnBlur;

		[Name("oncanplay")]
		public static HtmlEventHandler OnCanplay;

		[Name("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough;

		[Name("onchange")]
		public static HtmlEventHandler OnChange;

		[Name("onclick")]
		public static HtmlEventHandler OnClick;

		[Name("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu;

		[Name("ondblclick")]
		public static HtmlEventHandler OnDblclick;

		[Name("ondevicelight")]
		public static HtmlEventHandler OnDevicelight;

		[Name("ondevicemotion")]
		public static HtmlEventHandler OnDevicemotion;

		[Name("ondeviceorientation")]
		public static HtmlEventHandler OnDeviceorientation;

		[Name("ondeviceproximity")]
		public static HtmlEventHandler OnDeviceproximity;

		[Name("ondrag")]
		public static HtmlEventHandler OnDrag;

		[Name("ondragend")]
		public static HtmlEventHandler OnDragend;

		[Name("ondragenter")]
		public static HtmlEventHandler OnDragenter;

		[Name("ondragleave")]
		public static HtmlEventHandler OnDragleave;

		[Name("ondragover")]
		public static HtmlEventHandler OnDragover;

		[Name("ondragstart")]
		public static HtmlEventHandler OnDragstart;

		[Name("ondrop")]
		public static HtmlEventHandler OnDrop;

		[Name("ondurationchange")]
		public static HtmlEventHandler OnDurationchange;

		[Name("onemptied")]
		public static HtmlEventHandler OnEmptied;

		[Name("onended")]
		public static HtmlEventHandler OnEnded;

		[Name("onerror")]
		public static ErrorEventHandler OnError;

		[Name("onfocus")]
		public static HtmlEventHandler OnFocus;

		[Name("onhashchange")]
		public static HtmlEventHandler OnHashchange;

		[Name("oninput")]
		public static HtmlEventHandler OnInput;

		[Name("oninvalid")]
		public static HtmlEventHandler OnInvalid;

		[Name("onkeydown")]
		public static HtmlEventHandler OnKeydown;

		[Name("onkeypress")]
		public static HtmlEventHandler OnKeypress;

		[Name("onkeyup")]
		public static HtmlEventHandler OnKeyup;

		[Name("onload")]
		public static HtmlEventHandler OnLoad;

		[Name("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata;

		[Name("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata;

		[Name("onloadstart")]
		public static HtmlEventHandler OnLoadstart;

		[Name("onmessage")]
		public static HtmlEventHandler OnMessage;

		[Name("onmousedown")]
		public static HtmlEventHandler OnMousedown;

		[Name("onmouseenter")]
		public static HtmlEventHandler OnMouseenter;

		[Name("onmouseleave")]
		public static HtmlEventHandler OnMouseleave;

		[Name("onmousemove")]
		public static HtmlEventHandler OnMousemove;

		[Name("onmouseout")]
		public static HtmlEventHandler OnMouseout;

		[Name("onmouseover")]
		public static HtmlEventHandler OnMouseover;

		[Name("onmouseup")]
		public static HtmlEventHandler OnMouseup;

		[Name("onoffline")]
		public static HtmlEventHandler OnOffline;

		[Name("ononline")]
		public static HtmlEventHandler OnOnline;

		[Name("onpagehide")]
		public static HtmlEventHandler OnPagehide;

		[Name("onpageshow")]
		public static HtmlEventHandler OnPageshow;

		[Name("onpause")]
		public static HtmlEventHandler OnPause;

		[Name("onplay")]
		public static HtmlEventHandler OnPlay;

		[Name("onplaying")]
		public static HtmlEventHandler OnPlaying;

		[Name("onpointercancel")]
		public static HtmlEventHandler OnPointercancel;

		[Name("onpointerdown")]
		public static HtmlEventHandler OnPointerdown;

		[Name("onpointerenter")]
		public static HtmlEventHandler OnPointerenter;

		[Name("onpointerleave")]
		public static HtmlEventHandler OnPointerleave;

		[Name("onpointermove")]
		public static HtmlEventHandler OnPointermove;

		[Name("onpointerout")]
		public static HtmlEventHandler OnPointerout;

		[Name("onpointerover")]
		public static HtmlEventHandler OnPointerover;

		[Name("onpointerup")]
		public static HtmlEventHandler OnPointerup;

		[Name("onpopstate")]
		public static HtmlEventHandler OnPopstate;

		[Name("onprogress")]
		public static HtmlEventHandler OnProgress;

		[Name("onratechange")]
		public static HtmlEventHandler OnRatechange;

		[Name("onreset")]
		public static HtmlEventHandler OnReset;

		[Name("onresize")]
		public static HtmlEventHandler OnResize;

		[Name("onscroll")]
		public static HtmlEventHandler OnScroll;

		[Name("onseeked")]
		public static HtmlEventHandler OnSeeked;

		[Name("onseeking")]
		public static HtmlEventHandler OnSeeking;

		[Name("onselect")]
		public static HtmlEventHandler OnSelect;

		[Name("onshow")]
		public static HtmlEventHandler OnShow;

		[Name("onstalled")]
		public static HtmlEventHandler OnStalled;

		[Name("onsubmit")]
		public static HtmlEventHandler OnSubmit;

		[Name("onsuspend")]
		public static HtmlEventHandler OnSuspend;

		[Name("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate;

		[Name("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel;

		[Name("ontouchend")]
		public static HtmlEventHandler OnTouchend;

		[Name("ontouchenter")]
		public static HtmlEventHandler OnTouchenter;

		[Name("ontouchleave")]
		public static HtmlEventHandler OnTouchleave;

		[Name("ontouchmove")]
		public static HtmlEventHandler OnTouchmove;

		[Name("ontouchstart")]
		public static HtmlEventHandler OnTouchstart;

		[Name("onunload")]
		public static HtmlEventHandler OnUnload;

		[Name("onuserproximity")]
		public static HtmlEventHandler OnUserproximity;

		[Name("onvolumechange")]
		public static HtmlEventHandler OnVolumechange;

		[Name("onwaiting")]
		public static HtmlEventHandler OnWaiting;

		public static extern WindowInstance Open();

		public static extern WindowInstance Open(string url);

		public static extern WindowInstance Open(string url, string target);

		public static extern WindowInstance Open(string url, string target, string features);

		public static WindowInstance Opener;

		public static int OuterHeight;

		public static int OuterWidth;

		public static readonly int PageXOffset;

		public static readonly int PageYOffset;

		public static readonly WindowInstance Parent;

		public static readonly PerformanceDetails Performance;

		public static readonly BarProp Personalbar;

		public static extern void PostMessage(object message, string targetOrigin);

		public static extern void PostMessage(object message, string targetOrigin, object[] transfer);

		public static extern void Print();

		public static extern string Prompt();

		public static extern string Prompt(string message);

		public static extern string Prompt(string message, string @default);

		public static extern void ReleaseEvents();

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public static extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public static extern void RemoveEventListener(string type, IEventListener listener);

		public static extern void RemoveEventListener(string type, IEventListener listener, bool capture);

		public static extern void RemoveEventListener(WindowInstanceEvents type, Action listener);

		public static extern void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture);

		public static extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener);

		public static extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture);

		public static extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public static extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public static extern void RemoveEventListener(WindowInstanceEvents type, IEventListener listener);

		public static extern void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture);

		public static extern int RequestAnimationFrame(FrameRequestCallback callback);

		public static extern void ResizeBy(int x, int y);

		public static extern void ResizeTo(int x, int y);

		public static readonly Screen Screen;

		public static int ScreenX;

		public static int ScreenY;

		public static extern void Scroll(int x, int y);

		public static readonly BarProp Scrollbars;

		public static extern void ScrollBy(int x, int y);

		public static extern void ScrollByLines(int numLines);

		public static extern void ScrollByPages(int numPages);

		public static readonly int ScrollMaxX;

		public static readonly int ScrollMaxY;

		public static extern void ScrollTo(int x, int y);

		public static readonly int ScrollX;

		public static readonly int ScrollY;

		public static readonly WindowInstance Self;

		public static readonly Storage SessionStorage;

		public static extern void SetResizable(bool resizable);

		public static extern object ShowModalDialog(string url, object argument);

		public static extern object ShowModalDialog(string url, object argument, string options);

		public static extern void SizeToContent();

		public static string Status;

		public static readonly BarProp Statusbar;

		public static extern void Stop();

		public static extern string ToNativeLineEndings(string @string);

		public static readonly BarProp Toolbar;

		public static readonly WindowInstance Top;

		public static extern void UpdateCommands(string action);
	}
}
