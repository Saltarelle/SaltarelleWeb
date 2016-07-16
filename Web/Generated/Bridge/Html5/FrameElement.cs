using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'FRAME'"), Name("Element")]
	public partial class FrameElement : Element
	{
		internal FrameElement()
		{
		}

		public void AddEventListener(FrameElementEvents type, Action listener)
		{
		}

		public void AddEventListener(FrameElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener)
		{
		}

		public void AddEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture)
		{
		}

		public void AddEventListener(FrameElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(FrameElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture)
		{
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

		[FieldProperty]
		public bool NoResize
		{
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(FrameElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(FrameElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<FrameElement> listener, bool capture)
		{
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
	}
}
