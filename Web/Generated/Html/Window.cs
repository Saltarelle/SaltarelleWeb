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
		static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		static void AddEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void AddEventListener(string type, IEventListener listener, bool capture, bool? wantsUntrusted) {
		}

		public static void Alert(string message) {
		}

		[IntrinsicProperty]
		public static ApplicationCache ApplicationCache {
			get {
				return default(ApplicationCache);
			}
		}

		public static string Atob(string stringToEncode) {
			return null;
		}

		public static void Back() {
		}

		public static void Blur() {
		}

		public static string Btoa(string encodedString) {
			return null;
		}

		public static void ClearInterval(int intervalId) {
		}

		public static void ClearTimeout(int timeoutId) {
		}

		public static void Close() {
		}

		[IntrinsicProperty]
		public static bool Closed {
			get {
				return false;
			}
		}

		public static bool Confirm(string message) {
			return false;
		}

		[IntrinsicProperty]
		public static Crypto Crypto {
			get {
				return default(Crypto);
			}
		}

		[IntrinsicProperty]
		public static object DialogArguments {
			get {
				return null;
			}
		}

		public static bool DispatchEvent(Event @event) {
			return false;
		}

		[IntrinsicProperty]
		public static DocumentInstance Document {
			get {
				return default(DocumentInstance);
			}
		}

		public static string Escape(string regular) {
			return null;
		}

		public static bool Find(string aString) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive, bool aBackwards) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord, bool aSearchInFrames) {
			return false;
		}

		public static bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord, bool aSearchInFrames, bool aShowDialog) {
			return false;
		}

		public static void Focus() {
		}

		[IntrinsicProperty]
		public static Element FrameElement {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public static Element[] Frames {
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

		public static Style GetComputedStyle(XmlElement element) {
			return default(Style);
		}

		public static Style GetComputedStyle(XmlElement element, string pseudoElt) {
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
		}

		[IntrinsicProperty]
		public static int InnerWidth {
			get {
				return 0;
			}
		}

		[IntrinsicProperty, ScriptName("window")]
		public static WindowInstance Instance {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static int Length {
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

		public static MediaQueryList MatchMedia(string mediaQueryString) {
			return default(MediaQueryList);
		}

		[IntrinsicProperty]
		public static BarProp Menubar {
			get {
				return default(BarProp);
			}
		}

		public static void MoveBy(int deltaX, int deltaY) {
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
		public static BeforeUnloadEventHandlerNonNull OnBeforeunload {
			get {
				return default(BeforeUnloadEventHandlerNonNull);
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
		public static HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
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

		public static WindowInstance Open(string strUrl) {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string strUrl, string strWindowName) {
			return default(WindowInstance);
		}

		public static WindowInstance Open(string strUrl, string strWindowName, string strWindowFeatures) {
			return default(WindowInstance);
		}

		public static WindowInstance OpenDialog(string url) {
			return default(WindowInstance);
		}

		public static WindowInstance OpenDialog(string url, string name) {
			return default(WindowInstance);
		}

		[ExpandParams]
		public static WindowInstance OpenDialog(string url, string name, string features, params object[] args) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public static WindowInstance Opener {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public static int OuterHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public static int OuterWidth {
			get {
				return 0;
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

		public static void PostMessage(object message) {
		}

		public static void PostMessage(object message, string targetOrigin) {
		}

		public static void Print() {
		}

		public static string Prompt(string text) {
			return null;
		}

		public static string Prompt(string text, string value) {
			return null;
		}

		static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener) {
		}

		static void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WindowInstance> listener, bool capture) {
		}

		public static void RemoveEventListener(string type, IEventListener listener) {
		}

		public static void RemoveEventListener(string type, IEventListener listener, bool capture) {
		}

		public static void ResizeBy(int xDelta, int yDelta) {
		}

		public static void ResizeTo(int iWidth, int iHeight) {
		}

		[IntrinsicProperty]
		public static object ReturnValue {
			get {
				return null;
			}
			set {
			}
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
		}

		[IntrinsicProperty]
		public static int ScreenY {
			get {
				return 0;
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

		public static void ScrollBy(int xDelta, int yDelta) {
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

		public static int SetInterval(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetInterval(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetInterval(string code) {
			return 0;
		}

		public static int SetInterval(string code, int delay) {
			return 0;
		}

		public static int SetTimeout(Function func) {
			return 0;
		}

		[ExpandParams]
		public static int SetTimeout(Function func, int delay, params object[] args) {
			return 0;
		}

		public static int SetTimeout(string code) {
			return 0;
		}

		public static int SetTimeout(string code, int delay) {
			return 0;
		}

		public static object ShowModalDialog(string uri) {
			return null;
		}

		public static object ShowModalDialog(string uri, object arguments) {
			return null;
		}

		public static object ShowModalDialog(string uri, object arguments, string options) {
			return null;
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

		public static string Unescape(string escaped) {
			return null;
		}
	}
}
