using Bridge.Html5.CSS;
using Bridge.Html5.Data.IndexedDB;
using Bridge.Html5.Data.Offline;
using Bridge.Html5.Data.WebStorage;
using Bridge.Html5.Editing;
using Bridge.Html5.Elements;
using Bridge.Html5.Performance;
using Bridge.Html5.Security.Cryptography;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Window")]
	public partial class WindowInstance : EventTarget, IWindowTimers, IWindowBase64
	{
		internal extern WindowInstance();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public extern void AddEventListener(WindowInstanceEvents type, Action listener);

		public extern void AddEventListener(WindowInstanceEvents type, Action listener, bool capture);

		public extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public extern void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public extern void AddEventListener(WindowInstanceEvents type, IEventListener listener);

		public extern void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture);

		public extern void Alert();

		public extern void Alert(string message);

		public readonly ApplicationCache ApplicationCache;

		public extern string Atob(string atob);

		public extern void Back();

		public extern void Blur();

		public extern string Btoa(string btoa);

		public extern void CancelAnimationFrame(int handle);

		public extern void CaptureEvents();

		public extern void Close();

		public readonly bool Closed;

		public extern bool Confirm();

		public extern bool Confirm(string message);

		public readonly object Content;

		public readonly Crypto Crypto;

		public readonly double DevicePixelRatio;

		public extern void Dump(string str);

		public extern bool Find();

		public extern bool Find(string str);

		public extern bool Find(string str, bool caseSensitive);

		public extern bool Find(string str, bool caseSensitive, bool backwards);

		public extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround);

		public extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord);

		public extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames);

		public extern bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog);

		public extern void Focus();

		public extern void Forward();

		public readonly Element FrameElement;

		public readonly Element[] Frames;

		public bool FullScreen;

		public extern CSSStyleDeclaration GetComputedStyle(Element elt);

		public extern CSSStyleDeclaration GetComputedStyle(Element elt, string pseudoElt);

		public extern CSSStyleDeclaration GetDefaultComputedStyle(Element elt);

		public extern CSSStyleDeclaration GetDefaultComputedStyle(Element elt, string pseudoElt);

		public extern Selection GetSelection();

		public readonly History History;

		public extern void Home();

		public readonly Factory IndexedDB;

		public int InnerHeight;

		public int InnerWidth;

		[Name("window")]
		public readonly WindowInstance Instance;

		public readonly int Length;

		public readonly Storage LocalStorage;

		public readonly Location Location;

		public readonly BarProp Locationbar;

		public extern MediaQueryList MatchMedia(string query);

		public readonly BarProp Menubar;

		public extern void MoveBy(int x, int y);

		public extern void MoveTo(int x, int y);

		public string Name;

		public readonly NavigatorInstance Navigator;

		[Name("onabort")]
		public HtmlEventHandler OnAbort;

		[Name("onafterprint")]
		public HtmlEventHandler OnAfterprint;

		[Name("onbeforeprint")]
		public HtmlEventHandler OnBeforeprint;

		[Name("onbeforeunload")]
		public BeforeUnloadEventHandler OnBeforeunload;

		[Name("onblur")]
		public HtmlEventHandler OnBlur;

		[Name("oncanplay")]
		public HtmlEventHandler OnCanplay;

		[Name("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough;

		[Name("onchange")]
		public HtmlEventHandler OnChange;

		[Name("onclick")]
		public HtmlEventHandler OnClick;

		[Name("oncontextmenu")]
		public HtmlEventHandler OnContextmenu;

		[Name("ondblclick")]
		public HtmlEventHandler OnDblclick;

		[Name("ondevicelight")]
		public HtmlEventHandler OnDevicelight;

		[Name("ondevicemotion")]
		public HtmlEventHandler OnDevicemotion;

		[Name("ondeviceorientation")]
		public HtmlEventHandler OnDeviceorientation;

		[Name("ondeviceproximity")]
		public HtmlEventHandler OnDeviceproximity;

		[Name("ondrag")]
		public HtmlEventHandler OnDrag;

		[Name("ondragend")]
		public HtmlEventHandler OnDragend;

		[Name("ondragenter")]
		public HtmlEventHandler OnDragenter;

		[Name("ondragleave")]
		public HtmlEventHandler OnDragleave;

		[Name("ondragover")]
		public HtmlEventHandler OnDragover;

		[Name("ondragstart")]
		public HtmlEventHandler OnDragstart;

		[Name("ondrop")]
		public HtmlEventHandler OnDrop;

		[Name("ondurationchange")]
		public HtmlEventHandler OnDurationchange;

		[Name("onemptied")]
		public HtmlEventHandler OnEmptied;

		[Name("onended")]
		public HtmlEventHandler OnEnded;

		[Name("onerror")]
		public ErrorEventHandler OnError;

		[Name("onfocus")]
		public HtmlEventHandler OnFocus;

		[Name("onhashchange")]
		public HtmlEventHandler OnHashchange;

		[Name("oninput")]
		public HtmlEventHandler OnInput;

		[Name("oninvalid")]
		public HtmlEventHandler OnInvalid;

		[Name("onkeydown")]
		public HtmlEventHandler OnKeydown;

		[Name("onkeypress")]
		public HtmlEventHandler OnKeypress;

		[Name("onkeyup")]
		public HtmlEventHandler OnKeyup;

		[Name("onload")]
		public HtmlEventHandler OnLoad;

		[Name("onloadeddata")]
		public HtmlEventHandler OnLoadeddata;

		[Name("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata;

		[Name("onloadstart")]
		public HtmlEventHandler OnLoadstart;

		[Name("onmessage")]
		public HtmlEventHandler OnMessage;

		[Name("onmousedown")]
		public HtmlEventHandler OnMousedown;

		[Name("onmouseenter")]
		public HtmlEventHandler OnMouseenter;

		[Name("onmouseleave")]
		public HtmlEventHandler OnMouseleave;

		[Name("onmousemove")]
		public HtmlEventHandler OnMousemove;

		[Name("onmouseout")]
		public HtmlEventHandler OnMouseout;

		[Name("onmouseover")]
		public HtmlEventHandler OnMouseover;

		[Name("onmouseup")]
		public HtmlEventHandler OnMouseup;

		[Name("onoffline")]
		public HtmlEventHandler OnOffline;

		[Name("ononline")]
		public HtmlEventHandler OnOnline;

		[Name("onpagehide")]
		public HtmlEventHandler OnPagehide;

		[Name("onpageshow")]
		public HtmlEventHandler OnPageshow;

		[Name("onpause")]
		public HtmlEventHandler OnPause;

		[Name("onplay")]
		public HtmlEventHandler OnPlay;

		[Name("onplaying")]
		public HtmlEventHandler OnPlaying;

		[Name("onpointercancel")]
		public HtmlEventHandler OnPointercancel;

		[Name("onpointerdown")]
		public HtmlEventHandler OnPointerdown;

		[Name("onpointerenter")]
		public HtmlEventHandler OnPointerenter;

		[Name("onpointerleave")]
		public HtmlEventHandler OnPointerleave;

		[Name("onpointermove")]
		public HtmlEventHandler OnPointermove;

		[Name("onpointerout")]
		public HtmlEventHandler OnPointerout;

		[Name("onpointerover")]
		public HtmlEventHandler OnPointerover;

		[Name("onpointerup")]
		public HtmlEventHandler OnPointerup;

		[Name("onpopstate")]
		public HtmlEventHandler OnPopstate;

		[Name("onprogress")]
		public HtmlEventHandler OnProgress;

		[Name("onratechange")]
		public HtmlEventHandler OnRatechange;

		[Name("onreset")]
		public HtmlEventHandler OnReset;

		[Name("onresize")]
		public HtmlEventHandler OnResize;

		[Name("onscroll")]
		public HtmlEventHandler OnScroll;

		[Name("onseeked")]
		public HtmlEventHandler OnSeeked;

		[Name("onseeking")]
		public HtmlEventHandler OnSeeking;

		[Name("onselect")]
		public HtmlEventHandler OnSelect;

		[Name("onshow")]
		public HtmlEventHandler OnShow;

		[Name("onstalled")]
		public HtmlEventHandler OnStalled;

		[Name("onsubmit")]
		public HtmlEventHandler OnSubmit;

		[Name("onsuspend")]
		public HtmlEventHandler OnSuspend;

		[Name("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate;

		[Name("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel;

		[Name("ontouchend")]
		public HtmlEventHandler OnTouchend;

		[Name("ontouchenter")]
		public HtmlEventHandler OnTouchenter;

		[Name("ontouchleave")]
		public HtmlEventHandler OnTouchleave;

		[Name("ontouchmove")]
		public HtmlEventHandler OnTouchmove;

		[Name("ontouchstart")]
		public HtmlEventHandler OnTouchstart;

		[Name("onunload")]
		public HtmlEventHandler OnUnload;

		[Name("onuserproximity")]
		public HtmlEventHandler OnUserproximity;

		[Name("onvolumechange")]
		public HtmlEventHandler OnVolumechange;

		[Name("onwaiting")]
		public HtmlEventHandler OnWaiting;

		public extern WindowInstance Open();

		public extern WindowInstance Open(string url);

		public extern WindowInstance Open(string url, string target);

		public extern WindowInstance Open(string url, string target, string features);

		public WindowInstance Opener;

		public int OuterHeight;

		public int OuterWidth;

		public readonly int PageXOffset;

		public readonly int PageYOffset;

		public readonly WindowInstance Parent;

		public readonly PerformanceDetails Performance;

		public readonly BarProp Personalbar;

		public extern void PostMessage(object message, string targetOrigin);

		public extern void PostMessage(object message, string targetOrigin, object[] transfer);

		public extern void Print();

		public extern string Prompt();

		public extern string Prompt(string message);

		public extern string Prompt(string message, string @default);

		public extern void ReleaseEvents();

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public extern void RemoveEventListener(WindowInstanceEvents type, Action listener);

		public extern void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener);

		public extern void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture);

		public extern void RemoveEventListener(WindowInstanceEvents type, IEventListener listener);

		public extern void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture);

		public extern int RequestAnimationFrame(FrameRequestCallback callback);

		public extern void ResizeBy(int x, int y);

		public extern void ResizeTo(int x, int y);

		public readonly Screen Screen;

		public int ScreenX;

		public int ScreenY;

		public extern void Scroll(int x, int y);

		public readonly BarProp Scrollbars;

		public extern void ScrollBy(int x, int y);

		public extern void ScrollByLines(int numLines);

		public extern void ScrollByPages(int numPages);

		public readonly int ScrollMaxX;

		public readonly int ScrollMaxY;

		public extern void ScrollTo(int x, int y);

		public readonly int ScrollX;

		public readonly int ScrollY;

		public readonly WindowInstance Self;

		public readonly Storage SessionStorage;

		public extern void SetResizable(bool resizable);

		public extern object ShowModalDialog(string url, object argument);

		public extern object ShowModalDialog(string url, object argument, string options);

		public extern void SizeToContent();

		public string Status;

		public readonly BarProp Statusbar;

		public extern void Stop();

		public extern string ToNativeLineEndings(string @string);

		public readonly BarProp Toolbar;

		public readonly WindowInstance Top;

		public extern void UpdateCommands(string action);
	}
}
