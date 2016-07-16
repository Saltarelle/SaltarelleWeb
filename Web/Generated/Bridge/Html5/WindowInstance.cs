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
		internal WindowInstance()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, Action listener)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public void Alert()
		{
		}

		public void Alert(string message)
		{
		}

		[FieldProperty]
		public ApplicationCache ApplicationCache
		{
			get {
				return default(ApplicationCache);
			}
		}

		public string Atob(string atob)
		{
			return null;
		}

		public void Back()
		{
		}

		public void Blur()
		{
		}

		public string Btoa(string btoa)
		{
			return null;
		}

		public void CancelAnimationFrame(int handle)
		{
		}

		public void CaptureEvents()
		{
		}

		public void Close()
		{
		}

		[FieldProperty]
		public bool Closed
		{
			get {
				return false;
			}
		}

		public bool Confirm()
		{
			return false;
		}

		public bool Confirm(string message)
		{
			return false;
		}

		[FieldProperty]
		public object Content
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public Crypto Crypto
		{
			get {
				return default(Crypto);
			}
		}

		[FieldProperty]
		public double DevicePixelRatio
		{
			get {
				return 0;
			}
		}

		public void Dump(string str)
		{
		}

		public bool Find()
		{
			return false;
		}

		public bool Find(string str)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames)
		{
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog)
		{
			return false;
		}

		public void Focus()
		{
		}

		public void Forward()
		{
		}

		[FieldProperty]
		public Element FrameElement
		{
			get {
				return default(Element);
			}
		}

		[FieldProperty]
		public XmlElement[] Frames
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public bool FullScreen
		{
			get {
				return false;
			}
			set {
			}
		}

		public Style GetComputedStyle(Element elt)
		{
			return default(Style);
		}

		public Style GetComputedStyle(Element elt, string pseudoElt)
		{
			return default(Style);
		}

		public Style GetDefaultComputedStyle(Element elt)
		{
			return default(Style);
		}

		public Style GetDefaultComputedStyle(Element elt, string pseudoElt)
		{
			return default(Style);
		}

		public Selection GetSelection()
		{
			return default(Selection);
		}

		[FieldProperty]
		public History History
		{
			get {
				return default(History);
			}
		}

		public void Home()
		{
		}

		[FieldProperty]
		public Factory IndexedDB
		{
			get {
				return default(Factory);
			}
		}

		[FieldProperty]
		public int InnerHeight
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int InnerWidth
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty, Name("window")]
		public WindowInstance Instance
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public Storage LocalStorage
		{
			get {
				return default(Storage);
			}
		}

		[FieldProperty]
		public Location Location
		{
			get {
				return default(Location);
			}
		}

		[FieldProperty]
		public BarProp Locationbar
		{
			get {
				return default(BarProp);
			}
		}

		public MediaQueryList MatchMedia(string query)
		{
			return default(MediaQueryList);
		}

		[FieldProperty]
		public BarProp Menubar
		{
			get {
				return default(BarProp);
			}
		}

		public void MoveBy(int x, int y)
		{
		}

		public void MoveTo(int x, int y)
		{
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public NavigatorInstance Navigator
		{
			get {
				return default(NavigatorInstance);
			}
		}

		[FieldProperty, Name("onabort")]
		public HtmlEventHandler OnAbort
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onafterprint")]
		public HtmlEventHandler OnAfterprint
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforeprint")]
		public HtmlEventHandler OnBeforeprint
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onbeforeunload")]
		public BeforeUnloadEventHandler OnBeforeunload
		{
			get {
				return default(BeforeUnloadEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onblur")]
		public HtmlEventHandler OnBlur
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplay")]
		public HtmlEventHandler OnCanplay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onchange")]
		public HtmlEventHandler OnChange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onclick")]
		public HtmlEventHandler OnClick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncontextmenu")]
		public HtmlEventHandler OnContextmenu
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondblclick")]
		public HtmlEventHandler OnDblclick
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondevicelight")]
		public HtmlEventHandler OnDevicelight
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondevicemotion")]
		public HtmlEventHandler OnDevicemotion
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondeviceorientation")]
		public HtmlEventHandler OnDeviceorientation
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondeviceproximity")]
		public HtmlEventHandler OnDeviceproximity
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrag")]
		public HtmlEventHandler OnDrag
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragend")]
		public HtmlEventHandler OnDragend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragenter")]
		public HtmlEventHandler OnDragenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragleave")]
		public HtmlEventHandler OnDragleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragover")]
		public HtmlEventHandler OnDragover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondragstart")]
		public HtmlEventHandler OnDragstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondrop")]
		public HtmlEventHandler OnDrop
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ondurationchange")]
		public HtmlEventHandler OnDurationchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onemptied")]
		public HtmlEventHandler OnEmptied
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onended")]
		public HtmlEventHandler OnEnded
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onerror")]
		public ErrorEventHandler OnError
		{
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onfocus")]
		public HtmlEventHandler OnFocus
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onhashchange")]
		public HtmlEventHandler OnHashchange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninput")]
		public HtmlEventHandler OnInput
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oninvalid")]
		public HtmlEventHandler OnInvalid
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeydown")]
		public HtmlEventHandler OnKeydown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeypress")]
		public HtmlEventHandler OnKeypress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onkeyup")]
		public HtmlEventHandler OnKeyup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onload")]
		public HtmlEventHandler OnLoad
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadeddata")]
		public HtmlEventHandler OnLoadeddata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onloadstart")]
		public HtmlEventHandler OnLoadstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmessage")]
		public HtmlEventHandler OnMessage
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousedown")]
		public HtmlEventHandler OnMousedown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseenter")]
		public HtmlEventHandler OnMouseenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseleave")]
		public HtmlEventHandler OnMouseleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmousemove")]
		public HtmlEventHandler OnMousemove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseout")]
		public HtmlEventHandler OnMouseout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseover")]
		public HtmlEventHandler OnMouseover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onmouseup")]
		public HtmlEventHandler OnMouseup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onoffline")]
		public HtmlEventHandler OnOffline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ononline")]
		public HtmlEventHandler OnOnline
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpagehide")]
		public HtmlEventHandler OnPagehide
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpageshow")]
		public HtmlEventHandler OnPageshow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpause")]
		public HtmlEventHandler OnPause
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplay")]
		public HtmlEventHandler OnPlay
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onplaying")]
		public HtmlEventHandler OnPlaying
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointercancel")]
		public HtmlEventHandler OnPointercancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerdown")]
		public HtmlEventHandler OnPointerdown
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerenter")]
		public HtmlEventHandler OnPointerenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerleave")]
		public HtmlEventHandler OnPointerleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointermove")]
		public HtmlEventHandler OnPointermove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerout")]
		public HtmlEventHandler OnPointerout
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerover")]
		public HtmlEventHandler OnPointerover
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpointerup")]
		public HtmlEventHandler OnPointerup
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onpopstate")]
		public HtmlEventHandler OnPopstate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onprogress")]
		public HtmlEventHandler OnProgress
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onratechange")]
		public HtmlEventHandler OnRatechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onreset")]
		public HtmlEventHandler OnReset
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onresize")]
		public HtmlEventHandler OnResize
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onscroll")]
		public HtmlEventHandler OnScroll
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeked")]
		public HtmlEventHandler OnSeeked
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onseeking")]
		public HtmlEventHandler OnSeeking
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onselect")]
		public HtmlEventHandler OnSelect
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onshow")]
		public HtmlEventHandler OnShow
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onstalled")]
		public HtmlEventHandler OnStalled
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsubmit")]
		public HtmlEventHandler OnSubmit
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsuspend")]
		public HtmlEventHandler OnSuspend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchend")]
		public HtmlEventHandler OnTouchend
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchenter")]
		public HtmlEventHandler OnTouchenter
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchleave")]
		public HtmlEventHandler OnTouchleave
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchmove")]
		public HtmlEventHandler OnTouchmove
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("ontouchstart")]
		public HtmlEventHandler OnTouchstart
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onunload")]
		public HtmlEventHandler OnUnload
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onuserproximity")]
		public HtmlEventHandler OnUserproximity
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onvolumechange")]
		public HtmlEventHandler OnVolumechange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onwaiting")]
		public HtmlEventHandler OnWaiting
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public WindowInstance Open()
		{
			return default(WindowInstance);
		}

		public WindowInstance Open(string url)
		{
			return default(WindowInstance);
		}

		public WindowInstance Open(string url, string target)
		{
			return default(WindowInstance);
		}

		public WindowInstance Open(string url, string target, string features)
		{
			return default(WindowInstance);
		}

		[FieldProperty]
		public WindowInstance Opener
		{
			get {
				return default(WindowInstance);
			}
			set {
			}
		}

		[FieldProperty]
		public int OuterHeight
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int OuterWidth
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int PageXOffset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int PageYOffset
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public WindowInstance Parent
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public PerformanceDetails Performance
		{
			get {
				return default(PerformanceDetails);
			}
		}

		[FieldProperty]
		public BarProp Personalbar
		{
			get {
				return default(BarProp);
			}
		}

		public void PostMessage(object message, string targetOrigin)
		{
		}

		public void PostMessage(object message, string targetOrigin, object[] transfer)
		{
		}

		public void Print()
		{
		}

		public string Prompt()
		{
			return null;
		}

		public string Prompt(string message)
		{
			return null;
		}

		public string Prompt(string message, string @default)
		{
			return null;
		}

		public void ReleaseEvents()
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, Action listener)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture)
		{
		}

		public int RequestAnimationFrame(FrameRequestCallback callback)
		{
			return 0;
		}

		public void ResizeBy(int x, int y)
		{
		}

		public void ResizeTo(int x, int y)
		{
		}

		[FieldProperty]
		public Screen Screen
		{
			get {
				return default(Screen);
			}
		}

		[FieldProperty]
		public int ScreenX
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int ScreenY
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void Scroll(int x, int y)
		{
		}

		[FieldProperty]
		public BarProp Scrollbars
		{
			get {
				return default(BarProp);
			}
		}

		public void ScrollBy(int x, int y)
		{
		}

		public void ScrollByLines(int numLines)
		{
		}

		public void ScrollByPages(int numPages)
		{
		}

		[FieldProperty]
		public int ScrollMaxX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int ScrollMaxY
		{
			get {
				return 0;
			}
		}

		public void ScrollTo(int x, int y)
		{
		}

		[FieldProperty]
		public int ScrollX
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int ScrollY
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public WindowInstance Self
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public Storage SessionStorage
		{
			get {
				return default(Storage);
			}
		}

		public void SetResizable(bool resizable)
		{
		}

		public object ShowModalDialog(string url, object argument)
		{
			return null;
		}

		public object ShowModalDialog(string url, object argument, string options)
		{
			return null;
		}

		public void SizeToContent()
		{
		}

		[FieldProperty]
		public string Status
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public BarProp Statusbar
		{
			get {
				return default(BarProp);
			}
		}

		public void Stop()
		{
		}

		public string ToNativeLineEndings(string @string)
		{
			return null;
		}

		[FieldProperty]
		public BarProp Toolbar
		{
			get {
				return default(BarProp);
			}
		}

		[FieldProperty]
		public WindowInstance Top
		{
			get {
				return default(WindowInstance);
			}
		}

		public void UpdateCommands(string action)
		{
		}
	}
}
