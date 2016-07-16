using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLElement")]
	public partial class Element : XmlElement
	{
		internal Element()
		{
		}

		[FieldProperty]
		public string AccessKey
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string AccessKeyLabel
		{
			get {
				return null;
			}
		}

		public void AddEventListener(ElementEvents type, Action listener)
		{
		}

		public void AddEventListener(ElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener)
		{
		}

		public void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture)
		{
		}

		public void AddEventListener(ElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture)
		{
		}

		public void Blur()
		{
		}

		[FieldProperty]
		public string ClassName
		{
			get {
				return null;
			}
			set {
			}
		}

		public void Click()
		{
		}

		[FieldProperty]
		public string ContentEditable
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public MenuElement ContextMenu
		{
			get {
				return default(MenuElement);
			}
		}

		[FieldProperty]
		public DOMStringMap Dataset
		{
			get {
				return default(DOMStringMap);
			}
		}

		[FieldProperty]
		public string Dir
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Draggable
		{
			get {
				return false;
			}
			set {
			}
		}

		public void Focus()
		{
		}

		[FieldProperty]
		public bool Hidden
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public bool IsContentEditable
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string ItemId
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public DOMSettableTokenList ItemProp
		{
			get {
				return default(DOMSettableTokenList);
			}
		}

		[FieldProperty]
		public DOMSettableTokenList ItemRef
		{
			get {
				return default(DOMSettableTokenList);
			}
		}

		[FieldProperty]
		public bool ItemScope
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public DOMSettableTokenList ItemType
		{
			get {
				return default(DOMSettableTokenList);
			}
		}

		[FieldProperty]
		public object ItemValue
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Lang
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int OffsetHeight
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int OffsetLeft
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public Element OffsetParent
		{
			get {
				return default(Element);
			}
		}

		[FieldProperty]
		public int OffsetTop
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int OffsetWidth
		{
			get {
				return 0;
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

		[FieldProperty, Name("oncopy")]
		public HtmlEventHandler OnCopy
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("oncut")]
		public HtmlEventHandler OnCut
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
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
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

		[FieldProperty, Name("onpaste")]
		public HtmlEventHandler OnPaste
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

		public void RemoveEventListener(ElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener)
		{
		}

		public void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture)
		{
		}

		public void RemoveEventListener(ElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Scrollgrab
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Spellcheck
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public Style Style
		{
			get {
				return default(Style);
			}
		}

		[FieldProperty]
		public int TabIndex
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string Title
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
