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

		public void Alert(string message) {
		}

		[IntrinsicProperty]
		public ApplicationCache ApplicationCache {
			get {
				return default(ApplicationCache);
			}
		}

		public string Atob(string stringToEncode) {
			return null;
		}

		public void Back() {
		}

		public void Blur() {
		}

		public string Btoa(string encodedString) {
			return null;
		}

		public void ClearInterval(int intervalId) {
		}

		public void ClearTimeout(int timeoutId) {
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public bool Closed {
			get {
				return false;
			}
		}

		public bool Confirm(string message) {
			return false;
		}

		[IntrinsicProperty]
		public Crypto Crypto {
			get {
				return default(Crypto);
			}
		}

		[IntrinsicProperty]
		public object DialogArguments {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public DocumentInstance Document {
			get {
				return default(DocumentInstance);
			}
		}

		public string Escape(string regular) {
			return null;
		}

		public bool Find(string aString) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive, bool aBackwards) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord, bool aSearchInFrames) {
			return false;
		}

		public bool Find(string aString, bool aCaseSensitive, bool aBackwards, bool aWrapAround, bool aWholeWord, bool aSearchInFrames, bool aShowDialog) {
			return false;
		}

		public void Focus() {
		}

		[IntrinsicProperty]
		public Element FrameElement {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public Element[] Frames {
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

		public Style GetComputedStyle(XmlElement element) {
			return default(Style);
		}

		public Style GetComputedStyle(XmlElement element, string pseudoElt) {
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
		}

		[IntrinsicProperty]
		public int InnerWidth {
			get {
				return 0;
			}
		}

		[IntrinsicProperty, ScriptName("window")]
		public WindowInstance Instance {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public int Length {
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

		public MediaQueryList MatchMedia(string mediaQueryString) {
			return default(MediaQueryList);
		}

		[IntrinsicProperty]
		public BarProp Menubar {
			get {
				return default(BarProp);
			}
		}

		public void MoveBy(int deltaX, int deltaY) {
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
		public BeforeUnloadEventHandlerNonNull OnBeforeunload {
			get {
				return default(BeforeUnloadEventHandlerNonNull);
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
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
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

		[IntrinsicProperty, ScriptName("onwaiting")]
		public HtmlEventHandler OnWaiting {
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

		public WindowInstance Open(string strUrl) {
			return default(WindowInstance);
		}

		public WindowInstance Open(string strUrl, string strWindowName) {
			return default(WindowInstance);
		}

		public WindowInstance Open(string strUrl, string strWindowName, string strWindowFeatures) {
			return default(WindowInstance);
		}

		public WindowInstance OpenDialog(string url) {
			return default(WindowInstance);
		}

		public WindowInstance OpenDialog(string url, string name) {
			return default(WindowInstance);
		}

		[ExpandParams]
		public WindowInstance OpenDialog(string url, string name, string features, params object[] args) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public WindowInstance Opener {
			get {
				return default(WindowInstance);
			}
		}

		[IntrinsicProperty]
		public int OuterHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int OuterWidth {
			get {
				return 0;
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

		public void PostMessage(object message) {
		}

		public void PostMessage(object message, string targetOrigin) {
		}

		public void Print() {
		}

		public string Prompt(string text) {
			return null;
		}

		public string Prompt(string text, string value) {
			return null;
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

		public void ResizeBy(int xDelta, int yDelta) {
		}

		public void ResizeTo(int iWidth, int iHeight) {
		}

		[IntrinsicProperty]
		public object ReturnValue {
			get {
				return null;
			}
			set {
			}
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
		}

		[IntrinsicProperty]
		public int ScreenY {
			get {
				return 0;
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

		public void ScrollBy(int xDelta, int yDelta) {
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

		public int SetInterval(Function func) {
			return 0;
		}

		[ExpandParams]
		public int SetInterval(Function func, int delay, params object[] args) {
			return 0;
		}

		public int SetInterval(string code) {
			return 0;
		}

		public int SetInterval(string code, int delay) {
			return 0;
		}

		public int SetTimeout(Function func) {
			return 0;
		}

		[ExpandParams]
		public int SetTimeout(Function func, int delay, params object[] args) {
			return 0;
		}

		public int SetTimeout(string code) {
			return 0;
		}

		public int SetTimeout(string code, int delay) {
			return 0;
		}

		public object ShowModalDialog(string uri) {
			return null;
		}

		public object ShowModalDialog(string uri, object arguments) {
			return null;
		}

		public object ShowModalDialog(string uri, object arguments, string options) {
			return null;
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

		public string Unescape(string escaped) {
			return null;
		}
	}
}
