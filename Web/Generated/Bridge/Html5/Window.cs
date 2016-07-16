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
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, Action listener)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, Action listener, bool capture)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, IEventListener listener)
		{
		}

		public static void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public static void Alert()
		{
		}

		public static void Alert(string message)
		{
		}

		[FieldProperty]
		public static ApplicationCache ApplicationCache
		{
			get {
				return default(ApplicationCache);
			}
		}

		public static string Atob(string atob)
		{
			return null;
		}

		public static void Back()
		{
		}

		public static void Blur()
		{
		}

		public static string Btoa(string btoa)
		{
			return null;
		}

		public static void CancelAnimationFrame(int handle)
		{
		}

		public static void CaptureEvents()
		{
		}

		public static void Close()
		{
		}

		[FieldProperty]
		public static bool Closed
		{
			get {
				return false;
			}
		}

		public static bool Confirm()
		{
			return false;
		}

		public static bool Confirm(string message)
		{
			return false;
		}

		[FieldProperty]
		public static object Content
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static Crypto Crypto
		{
			get {
				return default(Crypto);
			}
		}

		[FieldProperty]
		public static double DevicePixelRatio
		{
			get {
				return 0;
			}
		}

		public static bool DispatchEvent(Event @event)
		{
			return false;
		}

		public static void Dump(string str)
		{
		}

		public static bool Find()
		{
			return false;
		}

		public static bool Find(string str)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames)
		{
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
		{
			return false;
		}

		public static void Focus()
		{
		}

		public static void Forward()
		{
		}

		[FieldProperty]
		public static Element FrameElement
		{
			get {
				return default(Element);
			}
		}

		[FieldProperty]
		public static XmlElement[] Frames
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public static bool FullScreen
		{
			get {
				return false;
			}
			set {
			}
		}

		public static Style GetComputedStyle(Element elt)
		{
			return default(Style);
		}

		public static Style GetComputedStyle(Element elt, string pseudoElt)
		{
			return default(Style);
		}

		public static Style GetDefaultComputedStyle(Element elt)
		{
			return default(Style);
		}

		public static Style GetDefaultComputedStyle(Element elt, string pseudoElt)
		{
			return default(Style);
		}

		public static Selection GetSelection()
		{
			return default(Selection);
		}

		[FieldProperty]
		public static History History
		{
			get {
				return default(History);
			}
		}

		public static void Home()
		{
		}

		[FieldProperty]
		public static Factory IndexedDB
		{
			get {
				return default(Factory);
			}
		}

		[FieldProperty]
		public static int InnerHeight
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public static int InnerWidth
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty, Name("window")]
		public static WindowInstance Instance
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public static int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static Storage LocalStorage
		{
			get {
				return default(Storage);
			}
		}

		[FieldProperty]
		public static Location Location
		{
			get {
				return default(Location);
			}
		}

		[FieldProperty]
		public static BarProp Locationbar
		{
			get {
				return default(BarProp);
			}
		}

		public static MediaQueryList MatchMedia(string query)
		{
			return default(MediaQueryList);
		}

		[FieldProperty]
		public static BarProp Menubar
		{
			get {
				return default(BarProp);
			}
		}

		public static void MoveBy(int x, int y)
		{
		}

		public static void MoveTo(int x, int y)
		{
		}

		[FieldProperty]
		public static string Name
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static NavigatorInstance Navigator
		{
			get {
				return default(NavigatorInstance);
			}
		}

		[FieldProperty, Name("onabort")]
		public static HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onafterprint")]
		public static HtmlEventHandler OnAfterprint
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforeprint")]
		public static HtmlEventHandler OnBeforeprint
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforeunload")]
		public static BeforeUnloadEventHandler OnBeforeunload
		{
			get {
				return default(BeforeUnloadEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onblur")]
		public static HtmlEventHandler OnBlur
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplay")]
		public static HtmlEventHandler OnCanplay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchange")]
		public static HtmlEventHandler OnChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclick")]
		public static HtmlEventHandler OnClick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondblclick")]
		public static HtmlEventHandler OnDblclick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondevicelight")]
		public static HtmlEventHandler OnDevicelight
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondevicemotion")]
		public static HtmlEventHandler OnDevicemotion
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondeviceorientation")]
		public static HtmlEventHandler OnDeviceorientation
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondeviceproximity")]
		public static HtmlEventHandler OnDeviceproximity
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrag")]
		public static HtmlEventHandler OnDrag
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragend")]
		public static HtmlEventHandler OnDragend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragenter")]
		public static HtmlEventHandler OnDragenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragleave")]
		public static HtmlEventHandler OnDragleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragover")]
		public static HtmlEventHandler OnDragover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragstart")]
		public static HtmlEventHandler OnDragstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrop")]
		public static HtmlEventHandler OnDrop
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondurationchange")]
		public static HtmlEventHandler OnDurationchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onemptied")]
		public static HtmlEventHandler OnEmptied
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onended")]
		public static HtmlEventHandler OnEnded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public static ErrorEventHandler OnError
		{
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onfocus")]
		public static HtmlEventHandler OnFocus
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onhashchange")]
		public static HtmlEventHandler OnHashchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninput")]
		public static HtmlEventHandler OnInput
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninvalid")]
		public static HtmlEventHandler OnInvalid
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeydown")]
		public static HtmlEventHandler OnKeydown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeypress")]
		public static HtmlEventHandler OnKeypress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeyup")]
		public static HtmlEventHandler OnKeyup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onload")]
		public static HtmlEventHandler OnLoad
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadstart")]
		public static HtmlEventHandler OnLoadstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmessage")]
		public static HtmlEventHandler OnMessage
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousedown")]
		public static HtmlEventHandler OnMousedown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseenter")]
		public static HtmlEventHandler OnMouseenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseleave")]
		public static HtmlEventHandler OnMouseleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousemove")]
		public static HtmlEventHandler OnMousemove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseout")]
		public static HtmlEventHandler OnMouseout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseover")]
		public static HtmlEventHandler OnMouseover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseup")]
		public static HtmlEventHandler OnMouseup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onoffline")]
		public static HtmlEventHandler OnOffline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ononline")]
		public static HtmlEventHandler OnOnline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpagehide")]
		public static HtmlEventHandler OnPagehide
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpageshow")]
		public static HtmlEventHandler OnPageshow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpause")]
		public static HtmlEventHandler OnPause
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplay")]
		public static HtmlEventHandler OnPlay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplaying")]
		public static HtmlEventHandler OnPlaying
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointercancel")]
		public static HtmlEventHandler OnPointercancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerdown")]
		public static HtmlEventHandler OnPointerdown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerenter")]
		public static HtmlEventHandler OnPointerenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerleave")]
		public static HtmlEventHandler OnPointerleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointermove")]
		public static HtmlEventHandler OnPointermove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerout")]
		public static HtmlEventHandler OnPointerout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerover")]
		public static HtmlEventHandler OnPointerover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerup")]
		public static HtmlEventHandler OnPointerup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpopstate")]
		public static HtmlEventHandler OnPopstate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onprogress")]
		public static HtmlEventHandler OnProgress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onratechange")]
		public static HtmlEventHandler OnRatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreset")]
		public static HtmlEventHandler OnReset
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onresize")]
		public static HtmlEventHandler OnResize
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onscroll")]
		public static HtmlEventHandler OnScroll
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeked")]
		public static HtmlEventHandler OnSeeked
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeking")]
		public static HtmlEventHandler OnSeeking
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onselect")]
		public static HtmlEventHandler OnSelect
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onshow")]
		public static HtmlEventHandler OnShow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onstalled")]
		public static HtmlEventHandler OnStalled
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsubmit")]
		public static HtmlEventHandler OnSubmit
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsuspend")]
		public static HtmlEventHandler OnSuspend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchend")]
		public static HtmlEventHandler OnTouchend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchenter")]
		public static HtmlEventHandler OnTouchenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchleave")]
		public static HtmlEventHandler OnTouchleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchmove")]
		public static HtmlEventHandler OnTouchmove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchstart")]
		public static HtmlEventHandler OnTouchstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onunload")]
		public static HtmlEventHandler OnUnload
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onuserproximity")]
		public static HtmlEventHandler OnUserproximity
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onvolumechange")]
		public static HtmlEventHandler OnVolumechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwaiting")]
		public static HtmlEventHandler OnWaiting
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static WindowInstance Open()
		{
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url)
		{
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string target)
		{
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string target, string features)
		{
			return default(WindowInstance);
		}

		[FieldProperty]
		public static WindowInstance Opener
		{
			get {
				return default(WindowInstance);
			}
			set {
			}
		}

		[FieldProperty]
		public static int OuterHeight
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public static int OuterWidth
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public static int PageXOffset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static int PageYOffset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static WindowInstance Parent
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public static PerformanceDetails Performance
		{
			get {
				return default(PerformanceDetails);
			}
		}

		[FieldProperty]
		public static BarProp Personalbar
		{
			get {
				return default(BarProp);
			}
		}

		public static void PostMessage(object message, string targetOrigin)
		{
		}

		public static void PostMessage(object message, string targetOrigin, object[] transfer)
		{
		}

		public static void Print()
		{
		}

		public static string Prompt()
		{
			return null;
		}

		public static string Prompt(string message)
		{
			return null;
		}

		public static string Prompt(string message, string @default)
		{
			return null;
		}

		public static void ReleaseEvents()
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, Action listener)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, IEventListener listener)
		{
		}

		public static void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public static int RequestAnimationFrame(FrameRequestCallback callback)
		{
			return 0;
		}

		public static void ResizeBy(int x, int y)
		{
		}

		public static void ResizeTo(int x, int y)
		{
		}

		[FieldProperty]
		public static Screen Screen
		{
			get {
				return default(Screen);
			}
		}

		[FieldProperty]
		public static int ScreenX
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public static int ScreenY
		{
			get {
				return 0;
			}
			set {
			}
		}

		public static void Scroll(int x, int y)
		{
		}

		[FieldProperty]
		public static BarProp Scrollbars
		{
			get {
				return default(BarProp);
			}
		}

		public static void ScrollBy(int x, int y)
		{
		}

		public static void ScrollByLines(int numLines)
		{
		}

		public static void ScrollByPages(int numPages)
		{
		}

		[FieldProperty]
		public static int ScrollMaxX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static int ScrollMaxY
		{
			get {
				return 0;
			}
		}

		public static void ScrollTo(int x, int y)
		{
		}

		[FieldProperty]
		public static int ScrollX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static int ScrollY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public static WindowInstance Self
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public static Storage SessionStorage
		{
			get {
				return default(Storage);
			}
		}

		public static void SetResizable(bool resizable)
		{
		}

		public static object ShowModalDialog(string url, object argument)
		{
			return null;
		}

		public static object ShowModalDialog(string url, object argument, string options)
		{
			return null;
		}

		public static void SizeToContent()
		{
		}

		[FieldProperty]
		public static string Status
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public static BarProp Statusbar
		{
			get {
				return default(BarProp);
			}
		}

		public static void Stop()
		{
		}

		public static string ToNativeLineEndings(string @string)
		{
			return null;
		}

		[FieldProperty]
		public static BarProp Toolbar
		{
			get {
				return default(BarProp);
			}
		}

		[FieldProperty]
		public static WindowInstance Top
		{
			get {
				return default(WindowInstance);
			}
		}

		public static void UpdateCommands(string action)
		{
		}
	}
}
