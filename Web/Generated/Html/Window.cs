using System.Data.IndexedDB;
using System.Data.Offline;
using System.Data.WebStorage;
using System.Html.Editing;
using System.Performance;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported, ScriptName("window")]
	public static partial class Window {
		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public static void AddEventListener(WindowInstanceEvents type, Action listener) {
		}

		public static void AddEventListener(WindowInstanceEvents type, Action listener, bool capture) {
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener) {
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public static void AddEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void AddEventListener(WindowInstanceEvents type, IEventListener listener) {
		}

		public static void AddEventListener(WindowInstanceEvents type, IEventListener listener, bool capture) {
		}

		public static void Alert() {
		}

		public static void Alert(string message) {
		}

		[IntrinsicProperty]
		public static ApplicationCache ApplicationCache {
			get {
				return default(ApplicationCache);
			}
		}

		public static string Atob(string atob) {
			return null;
		}

		public static void Back() {
		}

		public static void Blur() {
		}

		public static string Btoa(string btoa) {
			return null;
		}

		public static void CancelAnimationFrame(int handle) {
		}

		public static void CaptureEvents(int dummy) {
		}

		public static void ClearInterval(int handle) {
		}

		public static void ClearTimeout(int handle) {
		}

		public static void Close() {
		}

		[IntrinsicProperty]
		public static bool Closed {
			get {
				return false;
			}
		}

		public static bool Confirm() {
			return false;
		}

		public static bool Confirm(string message) {
			return false;
		}

		[IntrinsicProperty]
		public static object Content {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static Crypto Crypto {
			get {
				return default(Crypto);
			}
		}

		[IntrinsicProperty]
		public static float DevicePixelRatio {
			get {
				return 0;
			}
		}

		public static bool DispatchEvent(Event @event) {
			return false;
		}

		public static void Dump(string str) {
		}

		public static bool Find() {
			return false;
		}

		public static bool Find(string str) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames) {
			return false;
		}

		public static bool Find(string str, bool caseSensitive, bool backwards, bool wrapAround, bool wholeWord, bool searchInFrames, bool showDialog) {
			return false;
		}

		public static void Focus() {
		}

		public static void Forward() {
		}

		[IntrinsicProperty]
		public static XmlElement FrameElement {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public static XmlElement[] Frames {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public static bool FullScreen {
			get {
				return false;
			}
			set {
			}
		}

		public static Style GetComputedStyle(XmlElement elt) {
			return default(Style);
		}

		public static Style GetComputedStyle(XmlElement elt, string pseudoElt) {
			return default(Style);
		}

		public static Style GetDefaultComputedStyle(XmlElement elt) {
			return default(Style);
		}

		public static Style GetDefaultComputedStyle(XmlElement elt, string pseudoElt) {
			return default(Style);
		}

		public static Selection GetSelection() {
			return default(Selection);
		}

		[IntrinsicProperty]
		public static History History {
			get {
				return default(History);
			}
		}

		public static void Home() {
		}

		[IntrinsicProperty]
		public static Factory IndexedDB {
			get {
				return default(Factory);
			}
		}

		[IntrinsicProperty]
		public static int InnerHeight {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static int InnerWidth {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("window")]
		public static WindowInstance Instance {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static Storage LocalStorage {
			get {
				return default(Storage);
			}
		}

		[IntrinsicProperty]
		public static Location Location {
			get {
				return default(Location);
			}
		}

		[IntrinsicProperty]
		public static BarProp Locationbar {
			get {
				return default(BarProp);
			}
		}

		public static MediaQueryList MatchMedia(string query) {
			return default(MediaQueryList);
		}

		[IntrinsicProperty]
		public static BarProp Menubar {
			get {
				return default(BarProp);
			}
		}

		public static void MoveBy(int x, int y) {
		}

		public static void MoveTo(int x, int y) {
		}

		[IntrinsicProperty]
		public static string Name {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static NavigatorInstance Navigator {
			get {
				return default(NavigatorInstance);
			}
		}

		[IntrinsicProperty, ScriptName("onabort")]
		public static HtmlEventHandler OnAbort {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onafterprint")]
		public static HtmlEventHandler OnAfterprint {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforeprint")]
		public static HtmlEventHandler OnBeforeprint {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onbeforeunload")]
		public static BeforeUnloadEventHandler OnBeforeunload {
			get {
				return default(BeforeUnloadEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onblur")]
		public static HtmlEventHandler OnBlur {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplay")]
		public static HtmlEventHandler OnCanplay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncanplaythrough")]
		public static HtmlEventHandler OnCanplaythrough {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onchange")]
		public static HtmlEventHandler OnChange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onclick")]
		public static HtmlEventHandler OnClick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncontextmenu")]
		public static HtmlEventHandler OnContextmenu {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondblclick")]
		public static HtmlEventHandler OnDblclick {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondevicelight")]
		public static HtmlEventHandler OnDevicelight {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondevicemotion")]
		public static HtmlEventHandler OnDevicemotion {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondeviceorientation")]
		public static HtmlEventHandler OnDeviceorientation {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondeviceproximity")]
		public static HtmlEventHandler OnDeviceproximity {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrag")]
		public static HtmlEventHandler OnDrag {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragend")]
		public static HtmlEventHandler OnDragend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragenter")]
		public static HtmlEventHandler OnDragenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragleave")]
		public static HtmlEventHandler OnDragleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragover")]
		public static HtmlEventHandler OnDragover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondragstart")]
		public static HtmlEventHandler OnDragstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondrop")]
		public static HtmlEventHandler OnDrop {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ondurationchange")]
		public static HtmlEventHandler OnDurationchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onemptied")]
		public static HtmlEventHandler OnEmptied {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onended")]
		public static HtmlEventHandler OnEnded {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public static ErrorEventHandler OnError {
			get {
				return default(ErrorEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onfocus")]
		public static HtmlEventHandler OnFocus {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onhashchange")]
		public static HtmlEventHandler OnHashchange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninput")]
		public static HtmlEventHandler OnInput {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oninvalid")]
		public static HtmlEventHandler OnInvalid {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeydown")]
		public static HtmlEventHandler OnKeydown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeypress")]
		public static HtmlEventHandler OnKeypress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onkeyup")]
		public static HtmlEventHandler OnKeyup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onload")]
		public static HtmlEventHandler OnLoad {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadeddata")]
		public static HtmlEventHandler OnLoadeddata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadedmetadata")]
		public static HtmlEventHandler OnLoadedmetadata {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onloadstart")]
		public static HtmlEventHandler OnLoadstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public static HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousedown")]
		public static HtmlEventHandler OnMousedown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseenter")]
		public static HtmlEventHandler OnMouseenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseleave")]
		public static HtmlEventHandler OnMouseleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmousemove")]
		public static HtmlEventHandler OnMousemove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseout")]
		public static HtmlEventHandler OnMouseout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseover")]
		public static HtmlEventHandler OnMouseover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmouseup")]
		public static HtmlEventHandler OnMouseup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onoffline")]
		public static HtmlEventHandler OnOffline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ononline")]
		public static HtmlEventHandler OnOnline {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpagehide")]
		public static HtmlEventHandler OnPagehide {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpageshow")]
		public static HtmlEventHandler OnPageshow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpause")]
		public static HtmlEventHandler OnPause {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplay")]
		public static HtmlEventHandler OnPlay {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onplaying")]
		public static HtmlEventHandler OnPlaying {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerdown")]
		public static HtmlEventHandler OnPointerdown {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerenter")]
		public static HtmlEventHandler OnPointerenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerleave")]
		public static HtmlEventHandler OnPointerleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointermove")]
		public static HtmlEventHandler OnPointermove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerout")]
		public static HtmlEventHandler OnPointerout {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerover")]
		public static HtmlEventHandler OnPointerover {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpointerup")]
		public static HtmlEventHandler OnPointerup {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onpopstate")]
		public static HtmlEventHandler OnPopstate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onprogress")]
		public static HtmlEventHandler OnProgress {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onratechange")]
		public static HtmlEventHandler OnRatechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onreset")]
		public static HtmlEventHandler OnReset {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onresize")]
		public static HtmlEventHandler OnResize {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onscroll")]
		public static HtmlEventHandler OnScroll {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeked")]
		public static HtmlEventHandler OnSeeked {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onseeking")]
		public static HtmlEventHandler OnSeeking {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onselect")]
		public static HtmlEventHandler OnSelect {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onshow")]
		public static HtmlEventHandler OnShow {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onstalled")]
		public static HtmlEventHandler OnStalled {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsubmit")]
		public static HtmlEventHandler OnSubmit {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onsuspend")]
		public static HtmlEventHandler OnSuspend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontimeupdate")]
		public static HtmlEventHandler OnTimeupdate {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchcancel")]
		public static HtmlEventHandler OnTouchcancel {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchend")]
		public static HtmlEventHandler OnTouchend {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchenter")]
		public static HtmlEventHandler OnTouchenter {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchleave")]
		public static HtmlEventHandler OnTouchleave {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchmove")]
		public static HtmlEventHandler OnTouchmove {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("ontouchstart")]
		public static HtmlEventHandler OnTouchstart {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onunload")]
		public static HtmlEventHandler OnUnload {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onuserproximity")]
		public static HtmlEventHandler OnUserproximity {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onwaiting")]
		public static HtmlEventHandler OnWaiting {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onvolumechange")]
		public static HtmlEventHandler OnVolumechange {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public static WindowInstance Open() {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url) {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string target) {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string url, string target, string features) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public static WindowInstance Opener {
			get {
				return default(WindowInstance);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static int OuterHeight {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static int OuterWidth {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static int PageXOffset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static int PageYOffset {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static WindowInstance Parent {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static PerformanceDetails Performance {
			get {
				return default(PerformanceDetails);
			}
		}

		[IntrinsicProperty]
		public static BarProp Personalbar {
			get {
				return default(BarProp);
			}
		}

		public static void PostMessage(object message, string targetOrigin) {
		}

		public static void PostMessage(object message, string targetOrigin, object[] transfer) {
		}

		public static void Print() {
		}

		public static string Prompt() {
			return null;
		}

		public static string Prompt(string message) {
			return null;
		}

		public static string Prompt(string message, string @default) {
			return null;
		}

		public static void ReleaseEvents(int dummy) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, Action listener) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, Action listener, bool capture) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandler listener, bool capture) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, IEventListener listener) {
		}

		public static void RemoveEventListener(WindowInstanceEvents type, IEventListener listener, bool capture) {
		}

		public static int RequestAnimationFrame(FrameRequestCallback callback) {
			return 0;
		}

		public static void ResizeBy(int x, int y) {
		}

		public static void ResizeTo(int x, int y) {
		}

		[IntrinsicProperty]
		public static Screen Screen {
			get {
				return default(Screen);
			}
		}

		[IntrinsicProperty]
		public static int ScreenX {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static int ScreenY {
			get {
				return 0;
			}
			set {
			}
		}

		public static void Scroll(int x, int y) {
		}

		[IntrinsicProperty]
		public static BarProp Scrollbars {
			get {
				return default(BarProp);
			}
		}

		public static void ScrollBy(int x, int y) {
		}

		public static void ScrollByLines(int numLines) {
		}

		public static void ScrollByPages(int numPages) {
		}

		[IntrinsicProperty]
		public static int ScrollMaxX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static int ScrollMaxY {
			get {
				return 0;
			}
		}

		public static void ScrollTo(int x, int y) {
		}

		[IntrinsicProperty]
		public static int ScrollX {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static int ScrollY {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static WindowInstance Self {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static Storage SessionStorage {
			get {
				return default(Storage);
			}
		}

		public static void SetResizable(bool resizable) {
		}

		public static object ShowModalDialog(string url) {
			return null;
		}

		public static object ShowModalDialog(string url, object argument) {
			return null;
		}

		public static object ShowModalDialog(string url, object argument, string options) {
			return null;
		}

		public static void SizeToContent() {
		}

		[IntrinsicProperty]
		public static string Status {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public static BarProp Statusbar {
			get {
				return default(BarProp);
			}
		}

		public static void Stop() {
		}

		public static string ToNativeLineEndings(string @string) {
			return null;
		}

		[IntrinsicProperty]
		public static BarProp Toolbar {
			get {
				return default(BarProp);
			}
		}

		[IntrinsicProperty]
		public static WindowInstance Top {
			get {
				return default(WindowInstance);
			}
		}

		public static void UpdateCommands(string action) {
		}
	}
}
