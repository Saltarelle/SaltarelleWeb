using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IFRAME'"), Name("Element")]
	public partial class IFrameElement : Element
	{
		internal IFrameElement()
		{
		}

		public void AddEventListener(IFrameElementEvents type, Action listener)
		{
		}

		public void AddEventListener(IFrameElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(IFrameElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(IFrameElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener)
		{
		}

		public void AddEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture)
		{
		}

		public void AddEventListener(IFrameElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(IFrameElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Align
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool AllowFullscreen
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public DocumentBase ContentDocument
		{
			get {
				return default(DocumentBase);
			}
		}

		[FieldProperty]
		public WindowInstance ContentWindow
		{
			get {
				return default(WindowInstance);
			}
		}

		[FieldProperty]
		public string FrameBorder
		{
			get {
				return null;
			}
			set {
			}
		}

		public DocumentBase GetSVGDocument()
		{
			return default(DocumentBase);
		}

		[FieldProperty]
		public string Height
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string LongDesc
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string MarginHeight
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string MarginWidth
		{
			get {
				return null;
			}
			set {
			}
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

		public void RemoveEventListener(IFrameElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(IFrameElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<IFrameElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public DOMSettableTokenList Sandbox
		{
			get {
				return default(DOMSettableTokenList);
			}
		}

		[FieldProperty]
		public string Scrolling
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Src
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Srcdoc
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Width
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
