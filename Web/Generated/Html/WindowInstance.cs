using System.Data.IndexedDB;
using System.Data.Offline;
using System.Data.WebStorage;
using System.Html.Editing;
using System.Performance;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Window")]
	public partial class WindowInstance : EventTarget, IWindowTimers, IWindowBase64 {
		internal WindowInstance() {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public void AddEventListener(WindowInstanceEvents type, Action listener) {
		}

		public void AddEventListener(WindowInstanceEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public void AddEventListener(WindowInstanceEvents type, IEventListener listener) {
		}

		public void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture) {
		}

		public void Alert() {
		}

		public void Alert(string message) {
		}

		[IntrinsicProperty]
		public ApplicationCache ApplicationCache {
			get {
				return default(ApplicationCache);
			}
		}

		public string Atob(string atob) {
			return null;
		}

		public void Back() {
		}

		public void Blur() {
		}

		public string Btoa(string btoa) {
			return null;
		}

		public void CancelAnimationFrame(int handle) {
		}

		public void CaptureEvents(int dummy) {
		}

		public void ClearInterval(int handle) {
		}

		public void ClearTimeout(int handle) {
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public bool Closed {
			get {
				return false;
			}
		}

		public bool Confirm() {
			return false;
		}

		public bool Confirm(string message) {
			return false;
		}

		[IntrinsicProperty]
		public object Content {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public Crypto Crypto {
			get {
				return default(Crypto);
			}
		}

		[IntrinsicProperty]
		public float DevicePixelRatio {
			get {
				return 0;
			}
		}

		public void Dump(string str) {
		}

		public bool Find() {
			return false;
		}

		public bool Find(string str) {
			return false;
		}

		public bool Find(string str, bool caseSensitive) {
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards) {
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround) {
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord) {
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames) {
			return false;
		}

		public bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog) {
			return false;
		}

		public void Focus() {
		}

		public void Forward() {
		}

		[IntrinsicProperty]
		public XmlElement FrameElement {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlElement[] Frames {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public bool FullScreen {
			get {
				return false;
			}
			set {
			}
		}

		public Style GetComputedStyle(XmlElement elt) {
			return default(Style);
		}

		public Style GetComputedStyle(XmlElement elt, string pseudoElt) {
			return default(Style);
		}

		public Style GetDefaultComputedStyle(XmlElement elt) {
			return default(Style);
		}

		public Style GetDefaultComputedStyle(XmlElement elt, string pseudoElt) {
			return default(Style);
		}

		public Selection GetSelection() {
			return default(Selection);
		}

		[IntrinsicProperty]
		public History History {
			get {
				return default(History);
			}
		}

		public void Home() {
		}

		[IntrinsicProperty]
		public Factory IndexedDB {
			get {
				return default(Factory);
			}
		}

		[IntrinsicProperty]
		public int InnerHeight {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int InnerWidth {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("window")]
		public WindowInstance Instance {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public Storage LocalStorage {
			get {
				return default(Storage);
			}
		}

		[IntrinsicProperty]
		public Location Location {
			get {
				return default(Location);
			}
		}

		[IntrinsicProperty]
		public BarProp Locationbar {
			get {
				return default(BarProp);
			}
		}

		public MediaQueryList MatchMedia(string query) {
			return default(MediaQueryList);
		}

		[IntrinsicProperty]
		public BarProp Menubar {
			get {
				return default(BarProp);
			}
		}

		public void MoveBy(int x, int y) {
		}

		public void MoveTo(int x, int y) {
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public NavigatorInstance Navigator {
			get {
				return default(NavigatorInstance);
			}
		}

		[IntrinsicProperty, ScriptName("onabort")]
		public HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onafterprint")]
		public HtmlEventHandler OnAfterprint {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforeprint")]
		public HtmlEventHandler OnBeforeprint {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforeunload")]
		public BeforeUnloadEventHandler OnBeforeunload {
			get {
				return default(BeforeUnloadEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onblur")]
		public HtmlEventHandler OnBlur {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplay")]
		public HtmlEventHandler OnCanplay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplaythrough")]
		public HtmlEventHandler OnCanplaythrough {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchange")]
		public HtmlEventHandler OnChange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public HtmlEventHandler OnClick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncontextmenu")]
		public HtmlEventHandler OnContextmenu {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondblclick")]
		public HtmlEventHandler OnDblclick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondevicelight")]
		public HtmlEventHandler OnDevicelight {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondevicemotion")]
		public HtmlEventHandler OnDevicemotion {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondeviceorientation")]
		public HtmlEventHandler OnDeviceorientation {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondeviceproximity")]
		public HtmlEventHandler OnDeviceproximity {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrag")]
		public HtmlEventHandler OnDrag {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragend")]
		public HtmlEventHandler OnDragend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragenter")]
		public HtmlEventHandler OnDragenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragleave")]
		public HtmlEventHandler OnDragleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragover")]
		public HtmlEventHandler OnDragover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragstart")]
		public HtmlEventHandler OnDragstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrop")]
		public HtmlEventHandler OnDrop {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondurationchange")]
		public HtmlEventHandler OnDurationchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onemptied")]
		public HtmlEventHandler OnEmptied {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onended")]
		public HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public ErrorEventHandler OnError {
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onfocus")]
		public HtmlEventHandler OnFocus {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onhashchange")]
		public HtmlEventHandler OnHashchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninput")]
		public HtmlEventHandler OnInput {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninvalid")]
		public HtmlEventHandler OnInvalid {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeydown")]
		public HtmlEventHandler OnKeydown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeypress")]
		public HtmlEventHandler OnKeypress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeyup")]
		public HtmlEventHandler OnKeyup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onload")]
		public HtmlEventHandler OnLoad {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadeddata")]
		public HtmlEventHandler OnLoadeddata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadedmetadata")]
		public HtmlEventHandler OnLoadedmetadata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public HtmlEventHandler OnLoadstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousedown")]
		public HtmlEventHandler OnMousedown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseenter")]
		public HtmlEventHandler OnMouseenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseleave")]
		public HtmlEventHandler OnMouseleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousemove")]
		public HtmlEventHandler OnMousemove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseout")]
		public HtmlEventHandler OnMouseout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseover")]
		public HtmlEventHandler OnMouseover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseup")]
		public HtmlEventHandler OnMouseup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onoffline")]
		public HtmlEventHandler OnOffline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ononline")]
		public HtmlEventHandler OnOnline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpagehide")]
		public HtmlEventHandler OnPagehide {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpageshow")]
		public HtmlEventHandler OnPageshow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public HtmlEventHandler OnPause {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplay")]
		public HtmlEventHandler OnPlay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplaying")]
		public HtmlEventHandler OnPlaying {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerdown")]
		public HtmlEventHandler OnPointerdown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerenter")]
		public HtmlEventHandler OnPointerenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerleave")]
		public HtmlEventHandler OnPointerleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointermove")]
		public HtmlEventHandler OnPointermove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerout")]
		public HtmlEventHandler OnPointerout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerover")]
		public HtmlEventHandler OnPointerover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerup")]
		public HtmlEventHandler OnPointerup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpopstate")]
		public HtmlEventHandler OnPopstate {
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

		[IntrinsicProperty, ScriptName("onratechange")]
		public HtmlEventHandler OnRatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreset")]
		public HtmlEventHandler OnReset {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onresize")]
		public HtmlEventHandler OnResize {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onscroll")]
		public HtmlEventHandler OnScroll {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeked")]
		public HtmlEventHandler OnSeeked {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeking")]
		public HtmlEventHandler OnSeeking {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onselect")]
		public HtmlEventHandler OnSelect {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public HtmlEventHandler OnShow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstalled")]
		public HtmlEventHandler OnStalled {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsubmit")]
		public HtmlEventHandler OnSubmit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsuspend")]
		public HtmlEventHandler OnSuspend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontimeupdate")]
		public HtmlEventHandler OnTimeupdate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchcancel")]
		public HtmlEventHandler OnTouchcancel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchend")]
		public HtmlEventHandler OnTouchend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchenter")]
		public HtmlEventHandler OnTouchenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchleave")]
		public HtmlEventHandler OnTouchleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchmove")]
		public HtmlEventHandler OnTouchmove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchstart")]
		public HtmlEventHandler OnTouchstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onunload")]
		public HtmlEventHandler OnUnload {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onuserproximity")]
		public HtmlEventHandler OnUserproximity {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onvolumechange")]
		public HtmlEventHandler OnVolumechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwaiting")]
		public HtmlEventHandler OnWaiting {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public WindowInstance Open() {
			return default(WindowInstance);
		}

		public WindowInstance Open(string url) {
			return default(WindowInstance);
		}

		public WindowInstance Open(string url, string target) {
			return default(WindowInstance);
		}

		public WindowInstance Open(string url, string target, string features) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public WindowInstance Opener {
			get {
				return default(WindowInstance);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int OuterHeight {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int OuterWidth {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int PageXOffset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int PageYOffset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public WindowInstance Parent {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public PerformanceDetails Performance {
			get {
				return default(PerformanceDetails);
			}
		}

		[IntrinsicProperty]
		public BarProp Personalbar {
			get {
				return default(BarProp);
			}
		}

		public void PostMessage(object message, string targetOrigin) {
		}

		public void PostMessage(object message, string targetOrigin, object[] transfer) {
		}

		public void Print() {
		}

		public string Prompt() {
			return null;
		}

		public string Prompt(string message) {
			return null;
		}

		public string Prompt(string message, string @default) {
			return null;
		}

		public void ReleaseEvents(int dummy) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, Action listener) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture) {
		}

		public int RequestAnimationFrame(FrameRequestCallback callback) {
			return 0;
		}

		public void ResizeBy(int x, int y) {
		}

		public void ResizeTo(int x, int y) {
		}

		[IntrinsicProperty]
		public Screen Screen {
			get {
				return default(Screen);
			}
		}

		[IntrinsicProperty]
		public int ScreenX {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int ScreenY {
			get {
				return 0;
			}
			set {
			}
		}

		public void Scroll(int x, int y) {
		}

		[IntrinsicProperty]
		public BarProp Scrollbars {
			get {
				return default(BarProp);
			}
		}

		public void ScrollBy(int x, int y) {
		}

		public void ScrollByLines(int numLines) {
		}

		public void ScrollByPages(int numPages) {
		}

		[IntrinsicProperty]
		public int ScrollMaxX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ScrollMaxY {
			get {
				return 0;
			}
		}

		public void ScrollTo(int x, int y) {
		}

		[IntrinsicProperty]
		public int ScrollX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int ScrollY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public WindowInstance Self {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public Storage SessionStorage {
			get {
				return default(Storage);
			}
		}

		public void SetResizable(bool resizable) {
		}

		public object ShowModalDialog(string url) {
			return null;
		}

		public object ShowModalDialog(string url, object argument) {
			return null;
		}

		public object ShowModalDialog(string url, object argument, string options) {
			return null;
		}

		public void SizeToContent() {
		}

		[IntrinsicProperty]
		public string Status {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public BarProp Statusbar {
			get {
				return default(BarProp);
			}
		}

		public void Stop() {
		}

		public string ToNativeLineEndings(string @string) {
			return null;
		}

		[IntrinsicProperty]
		public BarProp Toolbar {
			get {
				return default(BarProp);
			}
		}

		[IntrinsicProperty]
		public WindowInstance Top {
			get {
				return default(WindowInstance);
			}
		}

		public void UpdateCommands(string action) {
		}
	}
}
