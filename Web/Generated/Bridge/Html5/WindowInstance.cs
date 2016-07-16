using Bridge.Html5.Data.IndexedDB;
using Bridge.Html5.Data.Offline;
using Bridge.Html5.Data.WebStorage;
using Bridge.Html5.Editing;
using Bridge.Html5.Performance;
using Bridge.Html5.Security.Cryptography;
using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Window")]
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

		[FieldProperty]
		public extern ApplicationCache ApplicationCache
		{
			get;
		}

		public extern string Atob(string atob);

		public extern void Back();

		public extern void Blur();

		public extern string Btoa(string btoa);

		public extern void CancelAnimationFrame(int handle);

		public extern void CaptureEvents();

		public extern void Close();

		[FieldProperty]
		public extern bool Closed
		{
			get;
		}

		public extern bool Confirm();

		public extern bool Confirm(string message);

		[FieldProperty]
		public extern object Content
		{
			get;
		}

		[FieldProperty]
		public extern Crypto Crypto
		{
			get;
		}

		[FieldProperty]
		public extern double DevicePixelRatio
		{
			get;
		}

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

		[FieldProperty]
		public extern Element FrameElement
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement[] Frames
		{
			get;
		}

		[FieldProperty]
		public extern bool FullScreen
		{
			get;
			set;
		}

		public extern Style GetComputedStyle(Element elt);

		public extern Style GetComputedStyle(Element elt, string pseudoElt);

		public extern Style GetDefaultComputedStyle(Element elt);

		public extern Style GetDefaultComputedStyle(Element elt, string pseudoElt);

		public extern Selection GetSelection();

		[FieldProperty]
		public extern History History
		{
			get;
		}

		public extern void Home();

		[FieldProperty]
		public extern Factory IndexedDB
		{
			get;
		}

		[FieldProperty]
		public extern int InnerHeight
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int InnerWidth
		{
			get;
			set;
		}

		[FieldProperty, Name("window")]
		public extern WindowInstance Instance
		{
			get;
		}

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern Storage LocalStorage
		{
			get;
		}

		[FieldProperty]
		public extern Location Location
		{
			get;
		}

		[FieldProperty]
		public extern BarProp Locationbar
		{
			get;
		}

		public extern MediaQueryList MatchMedia(string query);

		[FieldProperty]
		public extern BarProp Menubar
		{
			get;
		}

		public extern void MoveBy(int x, int y);

		public extern void MoveTo(int x, int y);

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		[FieldProperty]
		public extern NavigatorInstance Navigator
		{
			get;
		}

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onafterprint")]
		public extern HtmlEventHandler OnAfterprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeprint")]
		public extern HtmlEventHandler OnBeforeprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeunload")]
		public extern BeforeUnloadEventHandler OnBeforeunload
		{
			get;
			set;
		}

		[FieldProperty, Name("onblur")]
		public extern HtmlEventHandler OnBlur
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplay")]
		public extern HtmlEventHandler OnCanplay
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplaythrough")]
		public extern HtmlEventHandler OnCanplaythrough
		{
			get;
			set;
		}

		[FieldProperty, Name("onchange")]
		public extern HtmlEventHandler OnChange
		{
			get;
			set;
		}

		[FieldProperty, Name("onclick")]
		public extern HtmlEventHandler OnClick
		{
			get;
			set;
		}

		[FieldProperty, Name("oncontextmenu")]
		public extern HtmlEventHandler OnContextmenu
		{
			get;
			set;
		}

		[FieldProperty, Name("ondblclick")]
		public extern HtmlEventHandler OnDblclick
		{
			get;
			set;
		}

		[FieldProperty, Name("ondevicelight")]
		public extern HtmlEventHandler OnDevicelight
		{
			get;
			set;
		}

		[FieldProperty, Name("ondevicemotion")]
		public extern HtmlEventHandler OnDevicemotion
		{
			get;
			set;
		}

		[FieldProperty, Name("ondeviceorientation")]
		public extern HtmlEventHandler OnDeviceorientation
		{
			get;
			set;
		}

		[FieldProperty, Name("ondeviceproximity")]
		public extern HtmlEventHandler OnDeviceproximity
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrag")]
		public extern HtmlEventHandler OnDrag
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragend")]
		public extern HtmlEventHandler OnDragend
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragenter")]
		public extern HtmlEventHandler OnDragenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragleave")]
		public extern HtmlEventHandler OnDragleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragover")]
		public extern HtmlEventHandler OnDragover
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragstart")]
		public extern HtmlEventHandler OnDragstart
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrop")]
		public extern HtmlEventHandler OnDrop
		{
			get;
			set;
		}

		[FieldProperty, Name("ondurationchange")]
		public extern HtmlEventHandler OnDurationchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onemptied")]
		public extern HtmlEventHandler OnEmptied
		{
			get;
			set;
		}

		[FieldProperty, Name("onended")]
		public extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public extern ErrorEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onfocus")]
		public extern HtmlEventHandler OnFocus
		{
			get;
			set;
		}

		[FieldProperty, Name("onhashchange")]
		public extern HtmlEventHandler OnHashchange
		{
			get;
			set;
		}

		[FieldProperty, Name("oninput")]
		public extern HtmlEventHandler OnInput
		{
			get;
			set;
		}

		[FieldProperty, Name("oninvalid")]
		public extern HtmlEventHandler OnInvalid
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeydown")]
		public extern HtmlEventHandler OnKeydown
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeypress")]
		public extern HtmlEventHandler OnKeypress
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeyup")]
		public extern HtmlEventHandler OnKeyup
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadeddata")]
		public extern HtmlEventHandler OnLoadeddata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadedmetadata")]
		public extern HtmlEventHandler OnLoadedmetadata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onmessage")]
		public extern HtmlEventHandler OnMessage
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousedown")]
		public extern HtmlEventHandler OnMousedown
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseenter")]
		public extern HtmlEventHandler OnMouseenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseleave")]
		public extern HtmlEventHandler OnMouseleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousemove")]
		public extern HtmlEventHandler OnMousemove
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseout")]
		public extern HtmlEventHandler OnMouseout
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseover")]
		public extern HtmlEventHandler OnMouseover
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseup")]
		public extern HtmlEventHandler OnMouseup
		{
			get;
			set;
		}

		[FieldProperty, Name("onoffline")]
		public extern HtmlEventHandler OnOffline
		{
			get;
			set;
		}

		[FieldProperty, Name("ononline")]
		public extern HtmlEventHandler OnOnline
		{
			get;
			set;
		}

		[FieldProperty, Name("onpagehide")]
		public extern HtmlEventHandler OnPagehide
		{
			get;
			set;
		}

		[FieldProperty, Name("onpageshow")]
		public extern HtmlEventHandler OnPageshow
		{
			get;
			set;
		}

		[FieldProperty, Name("onpause")]
		public extern HtmlEventHandler OnPause
		{
			get;
			set;
		}

		[FieldProperty, Name("onplay")]
		public extern HtmlEventHandler OnPlay
		{
			get;
			set;
		}

		[FieldProperty, Name("onplaying")]
		public extern HtmlEventHandler OnPlaying
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointercancel")]
		public extern HtmlEventHandler OnPointercancel
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerdown")]
		public extern HtmlEventHandler OnPointerdown
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerenter")]
		public extern HtmlEventHandler OnPointerenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerleave")]
		public extern HtmlEventHandler OnPointerleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointermove")]
		public extern HtmlEventHandler OnPointermove
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerout")]
		public extern HtmlEventHandler OnPointerout
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerover")]
		public extern HtmlEventHandler OnPointerover
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerup")]
		public extern HtmlEventHandler OnPointerup
		{
			get;
			set;
		}

		[FieldProperty, Name("onpopstate")]
		public extern HtmlEventHandler OnPopstate
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

		[FieldProperty, Name("onratechange")]
		public extern HtmlEventHandler OnRatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreset")]
		public extern HtmlEventHandler OnReset
		{
			get;
			set;
		}

		[FieldProperty, Name("onresize")]
		public extern HtmlEventHandler OnResize
		{
			get;
			set;
		}

		[FieldProperty, Name("onscroll")]
		public extern HtmlEventHandler OnScroll
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeked")]
		public extern HtmlEventHandler OnSeeked
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeking")]
		public extern HtmlEventHandler OnSeeking
		{
			get;
			set;
		}

		[FieldProperty, Name("onselect")]
		public extern HtmlEventHandler OnSelect
		{
			get;
			set;
		}

		[FieldProperty, Name("onshow")]
		public extern HtmlEventHandler OnShow
		{
			get;
			set;
		}

		[FieldProperty, Name("onstalled")]
		public extern HtmlEventHandler OnStalled
		{
			get;
			set;
		}

		[FieldProperty, Name("onsubmit")]
		public extern HtmlEventHandler OnSubmit
		{
			get;
			set;
		}

		[FieldProperty, Name("onsuspend")]
		public extern HtmlEventHandler OnSuspend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontimeupdate")]
		public extern HtmlEventHandler OnTimeupdate
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchcancel")]
		public extern HtmlEventHandler OnTouchcancel
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchend")]
		public extern HtmlEventHandler OnTouchend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchenter")]
		public extern HtmlEventHandler OnTouchenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchleave")]
		public extern HtmlEventHandler OnTouchleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchmove")]
		public extern HtmlEventHandler OnTouchmove
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchstart")]
		public extern HtmlEventHandler OnTouchstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onunload")]
		public extern HtmlEventHandler OnUnload
		{
			get;
			set;
		}

		[FieldProperty, Name("onuserproximity")]
		public extern HtmlEventHandler OnUserproximity
		{
			get;
			set;
		}

		[FieldProperty, Name("onvolumechange")]
		public extern HtmlEventHandler OnVolumechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onwaiting")]
		public extern HtmlEventHandler OnWaiting
		{
			get;
			set;
		}

		public extern WindowInstance Open();

		public extern WindowInstance Open(string url);

		public extern WindowInstance Open(string url, string target);

		public extern WindowInstance Open(string url, string target, string features);

		[FieldProperty]
		public extern WindowInstance Opener
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int OuterHeight
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int OuterWidth
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int PageXOffset
		{
			get;
		}

		[FieldProperty]
		public extern int PageYOffset
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance Parent
		{
			get;
		}

		[FieldProperty]
		public extern PerformanceDetails Performance
		{
			get;
		}

		[FieldProperty]
		public extern BarProp Personalbar
		{
			get;
		}

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

		[FieldProperty]
		public extern Screen Screen
		{
			get;
		}

		[FieldProperty]
		public extern int ScreenX
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int ScreenY
		{
			get;
			set;
		}

		public extern void Scroll(int x, int y);

		[FieldProperty]
		public extern BarProp Scrollbars
		{
			get;
		}

		public extern void ScrollBy(int x, int y);

		public extern void ScrollByLines(int numLines);

		public extern void ScrollByPages(int numPages);

		[FieldProperty]
		public extern int ScrollMaxX
		{
			get;
		}

		[FieldProperty]
		public extern int ScrollMaxY
		{
			get;
		}

		public extern void ScrollTo(int x, int y);

		[FieldProperty]
		public extern int ScrollX
		{
			get;
		}

		[FieldProperty]
		public extern int ScrollY
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance Self
		{
			get;
		}

		[FieldProperty]
		public extern Storage SessionStorage
		{
			get;
		}

		public extern void SetResizable(bool resizable);

		public extern object ShowModalDialog(string url, object argument);

		public extern object ShowModalDialog(string url, object argument, string options);

		public extern void SizeToContent();

		[FieldProperty]
		public extern string Status
		{
			get;
			set;
		}

		[FieldProperty]
		public extern BarProp Statusbar
		{
			get;
		}

		public extern void Stop();

		public extern string ToNativeLineEndings(string @string);

		[FieldProperty]
		public extern BarProp Toolbar
		{
			get;
		}

		[FieldProperty]
		public extern WindowInstance Top
		{
			get;
		}

		public extern void UpdateCommands(string action);
	}
}
