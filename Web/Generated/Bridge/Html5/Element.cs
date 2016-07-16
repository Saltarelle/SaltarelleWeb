using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLElement")]
	public partial class Element : XmlElement
	{
		internal extern Element();

		[FieldProperty]
		public extern string AccessKey
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string AccessKeyLabel
		{
			get;
		}

		public extern void AddEventListener(ElementEvents type, Action listener);

		public extern void AddEventListener(ElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void AddEventListener(ElementEvents type, IEventListener listener);

		public extern void AddEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void Blur();

		[FieldProperty]
		public extern string ClassName
		{
			get;
			set;
		}

		public extern void Click();

		[FieldProperty]
		public extern string ContentEditable
		{
			get;
			set;
		}

		[FieldProperty]
		public extern MenuElement ContextMenu
		{
			get;
		}

		[FieldProperty]
		public extern DOMStringMap Dataset
		{
			get;
		}

		[FieldProperty]
		public extern string Dir
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Draggable
		{
			get;
			set;
		}

		public extern void Focus();

		[FieldProperty]
		public extern bool Hidden
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool IsContentEditable
		{
			get;
		}

		[FieldProperty]
		public extern string ItemId
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DOMSettableTokenList ItemProp
		{
			get;
		}

		[FieldProperty]
		public extern DOMSettableTokenList ItemRef
		{
			get;
		}

		[FieldProperty]
		public extern bool ItemScope
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DOMSettableTokenList ItemType
		{
			get;
		}

		[FieldProperty]
		public extern object ItemValue
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Lang
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int OffsetHeight
		{
			get;
		}

		[FieldProperty]
		public extern int OffsetLeft
		{
			get;
		}

		[FieldProperty]
		public extern Element OffsetParent
		{
			get;
		}

		[FieldProperty]
		public extern int OffsetTop
		{
			get;
		}

		[FieldProperty]
		public extern int OffsetWidth
		{
			get;
		}

		[FieldProperty, Name("onabort")]
		public extern HtmlEventHandler OnAbort
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

		[FieldProperty, Name("oncopy")]
		public extern HtmlEventHandler OnCopy
		{
			get;
			set;
		}

		[FieldProperty, Name("oncut")]
		public extern HtmlEventHandler OnCut
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
		public extern HtmlEventHandler OnError
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

		[FieldProperty, Name("onpaste")]
		public extern HtmlEventHandler OnPaste
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

		public extern void RemoveEventListener(ElementEvents type, Action listener);

		public extern void RemoveEventListener(ElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(ElementEvents type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Element> listener, bool capture);

		[FieldProperty]
		public extern bool Scrollgrab
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Spellcheck
		{
			get;
			set;
		}

		[FieldProperty]
		public extern Style Style
		{
			get;
		}

		[FieldProperty]
		public extern int TabIndex
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Title
		{
			get;
			set;
		}
	}
}
