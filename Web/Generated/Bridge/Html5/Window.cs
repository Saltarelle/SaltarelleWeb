using Bridge.Html5.Data.IndexedDB;
using Bridge.Html5.Data.Offline;
using Bridge.Html5.Data.WebStorage;
using Bridge.Html5.Editing;
using Bridge.Html5.Performance;
using Bridge.Html5.Security.Cryptography;
using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("window")]
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

		[FieldProperty]
		public static extern ApplicationCache ApplicationCache
		{
			get;
		}

		public static extern string Atob(string atob);

		public static extern void Back();

		public static extern void Blur();

		public static extern string Btoa(string btoa);

		public static extern void CancelAnimationFrame(int handle);

		public static extern void CaptureEvents();

		public static extern void Close();

		[FieldProperty]
		public static extern bool Closed
		{
			get;
		}

		public static extern bool Confirm();

		public static extern bool Confirm(string message);

		[FieldProperty]
		public static extern object Content
		{
			get;
		}

		[FieldProperty]
		public static extern Crypto Crypto
		{
			get;
		}

		[FieldProperty]
		public static extern double DevicePixelRatio
		{
			get;
		}

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

		[FieldProperty]
		public static extern Element FrameElement
		{
			get;
		}

		[FieldProperty]
		public static extern XmlElement[] Frames
		{
			get;
		}

		[FieldProperty]
		public static extern bool FullScreen
		{
			get;
			set;
		}

		public static extern Style GetComputedStyle(Element elt);

		public static extern Style GetComputedStyle(Element elt, string pseudoElt);

		public static extern Style GetDefaultComputedStyle(Element elt);

		public static extern Style GetDefaultComputedStyle(Element elt, string pseudoElt);

		public static extern Selection GetSelection();

		[FieldProperty]
		public static extern History History
		{
			get;
		}

		public static extern void Home();

		[FieldProperty]
		public static extern Factory IndexedDB
		{
			get;
		}

		[FieldProperty]
		public static extern int InnerHeight
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern int InnerWidth
		{
			get;
			set;
		}

		[FieldProperty, Name("window")]
		public static extern WindowInstance Instance
		{
			get;
		}

		[FieldProperty]
		public static extern int Length
		{
			get;
		}

		[FieldProperty]
		public static extern Storage LocalStorage
		{
			get;
		}

		[FieldProperty]
		public static extern Location Location
		{
			get;
		}

		[FieldProperty]
		public static extern BarProp Locationbar
		{
			get;
		}

		public static extern MediaQueryList MatchMedia(string query);

		[FieldProperty]
		public static extern BarProp Menubar
		{
			get;
		}

		public static extern void MoveBy(int x, int y);

		public static extern void MoveTo(int x, int y);

		[FieldProperty]
		public static extern string Name
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern NavigatorInstance Navigator
		{
			get;
		}

		[FieldProperty, Name("onabort")]
		public static extern HtmlEventHandler OnAbort
		{
			get;
			set;
		}

		[FieldProperty, Name("onafterprint")]
		public static extern HtmlEventHandler OnAfterprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeprint")]
		public static extern HtmlEventHandler OnBeforeprint
		{
			get;
			set;
		}

		[FieldProperty, Name("onbeforeunload")]
		public static extern BeforeUnloadEventHandler OnBeforeunload
		{
			get;
			set;
		}

		[FieldProperty, Name("onblur")]
		public static extern HtmlEventHandler OnBlur
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplay")]
		public static extern HtmlEventHandler OnCanplay
		{
			get;
			set;
		}

		[FieldProperty, Name("oncanplaythrough")]
		public static extern HtmlEventHandler OnCanplaythrough
		{
			get;
			set;
		}

		[FieldProperty, Name("onchange")]
		public static extern HtmlEventHandler OnChange
		{
			get;
			set;
		}

		[FieldProperty, Name("onclick")]
		public static extern HtmlEventHandler OnClick
		{
			get;
			set;
		}

		[FieldProperty, Name("oncontextmenu")]
		public static extern HtmlEventHandler OnContextmenu
		{
			get;
			set;
		}

		[FieldProperty, Name("ondblclick")]
		public static extern HtmlEventHandler OnDblclick
		{
			get;
			set;
		}

		[FieldProperty, Name("ondevicelight")]
		public static extern HtmlEventHandler OnDevicelight
		{
			get;
			set;
		}

		[FieldProperty, Name("ondevicemotion")]
		public static extern HtmlEventHandler OnDevicemotion
		{
			get;
			set;
		}

		[FieldProperty, Name("ondeviceorientation")]
		public static extern HtmlEventHandler OnDeviceorientation
		{
			get;
			set;
		}

		[FieldProperty, Name("ondeviceproximity")]
		public static extern HtmlEventHandler OnDeviceproximity
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrag")]
		public static extern HtmlEventHandler OnDrag
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragend")]
		public static extern HtmlEventHandler OnDragend
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragenter")]
		public static extern HtmlEventHandler OnDragenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragleave")]
		public static extern HtmlEventHandler OnDragleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragover")]
		public static extern HtmlEventHandler OnDragover
		{
			get;
			set;
		}

		[FieldProperty, Name("ondragstart")]
		public static extern HtmlEventHandler OnDragstart
		{
			get;
			set;
		}

		[FieldProperty, Name("ondrop")]
		public static extern HtmlEventHandler OnDrop
		{
			get;
			set;
		}

		[FieldProperty, Name("ondurationchange")]
		public static extern HtmlEventHandler OnDurationchange
		{
			get;
			set;
		}

		[FieldProperty, Name("onemptied")]
		public static extern HtmlEventHandler OnEmptied
		{
			get;
			set;
		}

		[FieldProperty, Name("onended")]
		public static extern HtmlEventHandler OnEnded
		{
			get;
			set;
		}

		[FieldProperty, Name("onerror")]
		public static extern ErrorEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onfocus")]
		public static extern HtmlEventHandler OnFocus
		{
			get;
			set;
		}

		[FieldProperty, Name("onhashchange")]
		public static extern HtmlEventHandler OnHashchange
		{
			get;
			set;
		}

		[FieldProperty, Name("oninput")]
		public static extern HtmlEventHandler OnInput
		{
			get;
			set;
		}

		[FieldProperty, Name("oninvalid")]
		public static extern HtmlEventHandler OnInvalid
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeydown")]
		public static extern HtmlEventHandler OnKeydown
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeypress")]
		public static extern HtmlEventHandler OnKeypress
		{
			get;
			set;
		}

		[FieldProperty, Name("onkeyup")]
		public static extern HtmlEventHandler OnKeyup
		{
			get;
			set;
		}

		[FieldProperty, Name("onload")]
		public static extern HtmlEventHandler OnLoad
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadeddata")]
		public static extern HtmlEventHandler OnLoadeddata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadedmetadata")]
		public static extern HtmlEventHandler OnLoadedmetadata
		{
			get;
			set;
		}

		[FieldProperty, Name("onloadstart")]
		public static extern HtmlEventHandler OnLoadstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onmessage")]
		public static extern HtmlEventHandler OnMessage
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousedown")]
		public static extern HtmlEventHandler OnMousedown
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseenter")]
		public static extern HtmlEventHandler OnMouseenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseleave")]
		public static extern HtmlEventHandler OnMouseleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onmousemove")]
		public static extern HtmlEventHandler OnMousemove
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseout")]
		public static extern HtmlEventHandler OnMouseout
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseover")]
		public static extern HtmlEventHandler OnMouseover
		{
			get;
			set;
		}

		[FieldProperty, Name("onmouseup")]
		public static extern HtmlEventHandler OnMouseup
		{
			get;
			set;
		}

		[FieldProperty, Name("onoffline")]
		public static extern HtmlEventHandler OnOffline
		{
			get;
			set;
		}

		[FieldProperty, Name("ononline")]
		public static extern HtmlEventHandler OnOnline
		{
			get;
			set;
		}

		[FieldProperty, Name("onpagehide")]
		public static extern HtmlEventHandler OnPagehide
		{
			get;
			set;
		}

		[FieldProperty, Name("onpageshow")]
		public static extern HtmlEventHandler OnPageshow
		{
			get;
			set;
		}

		[FieldProperty, Name("onpause")]
		public static extern HtmlEventHandler OnPause
		{
			get;
			set;
		}

		[FieldProperty, Name("onplay")]
		public static extern HtmlEventHandler OnPlay
		{
			get;
			set;
		}

		[FieldProperty, Name("onplaying")]
		public static extern HtmlEventHandler OnPlaying
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointercancel")]
		public static extern HtmlEventHandler OnPointercancel
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerdown")]
		public static extern HtmlEventHandler OnPointerdown
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerenter")]
		public static extern HtmlEventHandler OnPointerenter
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerleave")]
		public static extern HtmlEventHandler OnPointerleave
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointermove")]
		public static extern HtmlEventHandler OnPointermove
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerout")]
		public static extern HtmlEventHandler OnPointerout
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerover")]
		public static extern HtmlEventHandler OnPointerover
		{
			get;
			set;
		}

		[FieldProperty, Name("onpointerup")]
		public static extern HtmlEventHandler OnPointerup
		{
			get;
			set;
		}

		[FieldProperty, Name("onpopstate")]
		public static extern HtmlEventHandler OnPopstate
		{
			get;
			set;
		}

		[FieldProperty, Name("onprogress")]
		public static extern HtmlEventHandler OnProgress
		{
			get;
			set;
		}

		[FieldProperty, Name("onratechange")]
		public static extern HtmlEventHandler OnRatechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onreset")]
		public static extern HtmlEventHandler OnReset
		{
			get;
			set;
		}

		[FieldProperty, Name("onresize")]
		public static extern HtmlEventHandler OnResize
		{
			get;
			set;
		}

		[FieldProperty, Name("onscroll")]
		public static extern HtmlEventHandler OnScroll
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeked")]
		public static extern HtmlEventHandler OnSeeked
		{
			get;
			set;
		}

		[FieldProperty, Name("onseeking")]
		public static extern HtmlEventHandler OnSeeking
		{
			get;
			set;
		}

		[FieldProperty, Name("onselect")]
		public static extern HtmlEventHandler OnSelect
		{
			get;
			set;
		}

		[FieldProperty, Name("onshow")]
		public static extern HtmlEventHandler OnShow
		{
			get;
			set;
		}

		[FieldProperty, Name("onstalled")]
		public static extern HtmlEventHandler OnStalled
		{
			get;
			set;
		}

		[FieldProperty, Name("onsubmit")]
		public static extern HtmlEventHandler OnSubmit
		{
			get;
			set;
		}

		[FieldProperty, Name("onsuspend")]
		public static extern HtmlEventHandler OnSuspend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontimeupdate")]
		public static extern HtmlEventHandler OnTimeupdate
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchcancel")]
		public static extern HtmlEventHandler OnTouchcancel
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchend")]
		public static extern HtmlEventHandler OnTouchend
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchenter")]
		public static extern HtmlEventHandler OnTouchenter
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchleave")]
		public static extern HtmlEventHandler OnTouchleave
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchmove")]
		public static extern HtmlEventHandler OnTouchmove
		{
			get;
			set;
		}

		[FieldProperty, Name("ontouchstart")]
		public static extern HtmlEventHandler OnTouchstart
		{
			get;
			set;
		}

		[FieldProperty, Name("onunload")]
		public static extern HtmlEventHandler OnUnload
		{
			get;
			set;
		}

		[FieldProperty, Name("onuserproximity")]
		public static extern HtmlEventHandler OnUserproximity
		{
			get;
			set;
		}

		[FieldProperty, Name("onvolumechange")]
		public static extern HtmlEventHandler OnVolumechange
		{
			get;
			set;
		}

		[FieldProperty, Name("onwaiting")]
		public static extern HtmlEventHandler OnWaiting
		{
			get;
			set;
		}

		public static extern WindowInstance Open();

		public static extern WindowInstance Open(string url);

		public static extern WindowInstance Open(string url, string target);

		public static extern WindowInstance Open(string url, string target, string features);

		[FieldProperty]
		public static extern WindowInstance Opener
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern int OuterHeight
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern int OuterWidth
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern int PageXOffset
		{
			get;
		}

		[FieldProperty]
		public static extern int PageYOffset
		{
			get;
		}

		[FieldProperty]
		public static extern WindowInstance Parent
		{
			get;
		}

		[FieldProperty]
		public static extern PerformanceDetails Performance
		{
			get;
		}

		[FieldProperty]
		public static extern BarProp Personalbar
		{
			get;
		}

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

		[FieldProperty]
		public static extern Screen Screen
		{
			get;
		}

		[FieldProperty]
		public static extern int ScreenX
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern int ScreenY
		{
			get;
			set;
		}

		public static extern void Scroll(int x, int y);

		[FieldProperty]
		public static extern BarProp Scrollbars
		{
			get;
		}

		public static extern void ScrollBy(int x, int y);

		public static extern void ScrollByLines(int numLines);

		public static extern void ScrollByPages(int numPages);

		[FieldProperty]
		public static extern int ScrollMaxX
		{
			get;
		}

		[FieldProperty]
		public static extern int ScrollMaxY
		{
			get;
		}

		public static extern void ScrollTo(int x, int y);

		[FieldProperty]
		public static extern int ScrollX
		{
			get;
		}

		[FieldProperty]
		public static extern int ScrollY
		{
			get;
		}

		[FieldProperty]
		public static extern WindowInstance Self
		{
			get;
		}

		[FieldProperty]
		public static extern Storage SessionStorage
		{
			get;
		}

		public static extern void SetResizable(bool resizable);

		public static extern object ShowModalDialog(string url, object argument);

		public static extern object ShowModalDialog(string url, object argument, string options);

		public static extern void SizeToContent();

		[FieldProperty]
		public static extern string Status
		{
			get;
			set;
		}

		[FieldProperty]
		public static extern BarProp Statusbar
		{
			get;
		}

		public static extern void Stop();

		public static extern string ToNativeLineEndings(string @string);

		[FieldProperty]
		public static extern BarProp Toolbar
		{
			get;
		}

		[FieldProperty]
		public static extern WindowInstance Top
		{
			get;
		}

		public static extern void UpdateCommands(string action);
	}
}
