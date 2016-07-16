using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLElement")]
	public partial class Element : XmlElement {
		internal Element() {
		}

		[IntrinsicProperty]
		public string AccessKey {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string AccessKeyLabel {
			get {
				return null;
			}
		}

		public void AddEventListener(ElementEvents type, Action listener) {
		}

		public void AddEventListener(ElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener) {
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture) {
		}

		public void AddEventListener(ElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(ElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture) {
		}

		public void Blur() {
		}

		[IntrinsicProperty]
		public string ClassName {
			get {
				return null;
			}
			set {
			}
		}

		public void Click() {
		}

		[IntrinsicProperty]
		public string ContentEditable {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public MenuElement ContextMenu {
			get {
				return default(MenuElement);
			}
		}

		[IntrinsicProperty]
		public DOMStringMap Dataset {
			get {
				return default(DOMStringMap);
			}
		}

		[IntrinsicProperty]
		public string Dir {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Draggable {
			get {
				return false;
			}
			set {
			}
		}

		public void Focus() {
		}

		[IntrinsicProperty]
		public bool Hidden {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool IsContentEditable {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string ItemId {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DOMSettableTokenList ItemProp {
			get {
				return default(DOMSettableTokenList);
			}
		}

		[IntrinsicProperty]
		public DOMSettableTokenList ItemRef {
			get {
				return default(DOMSettableTokenList);
			}
		}

		[IntrinsicProperty]
		public bool ItemScope {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DOMSettableTokenList ItemType {
			get {
				return default(DOMSettableTokenList);
			}
		}

		[IntrinsicProperty]
		public object ItemValue {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Lang {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int OffsetHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int OffsetLeft {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public Element OffsetParent {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public int OffsetTop {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int OffsetWidth {
			get {
				return 0;
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

		[IntrinsicProperty, ScriptName("oncopy")]
		public HtmlEventHandler OnCopy {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("oncut")]
		public HtmlEventHandler OnCut {
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

		[IntrinsicProperty, ScriptName("onpaste")]
		public HtmlEventHandler OnPaste {
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

		[IntrinsicProperty, ScriptName("onpointercancel")]
		public HtmlEventHandler OnPointercancel {
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

		public void RemoveEventListener(ElementEvents type, Action listener) {
		}

		public void RemoveEventListener(ElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener) {
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture) {
		}

		public void RemoveEventListener(ElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(ElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Scrollgrab {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Spellcheck {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public Style Style {
			get {
				return default(Style);
			}
		}

		[IntrinsicProperty]
		public int TabIndex {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Title {
			get {
				return null;
			}
			set {
			}
		}
	}
}
