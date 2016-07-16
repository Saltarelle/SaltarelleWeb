namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IMG'"), Name("Element")]
	public partial class ImageElement : Element
	{
		[Template("new Image()")]
		public ImageElement()
		{
		}

		[Template("new Image({width})")]
		public ImageElement(int width)
		{
		}

		[Template("new Image({width}, {height})")]
		public ImageElement(int width, int height)
		{
		}

		public void AddEventListener(ImageElementEvents type, Action listener)
		{
		}

		public void AddEventListener(ImageElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener)
		{
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture)
		{
		}

		public void AddEventListener(ImageElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ImageElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture)
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
		public string Alt
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Border
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Complete
		{
			get {
				return false;
			}
		}

		[FieldProperty]
		public string CrossOrigin
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int Height
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int Hspace
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool IsMap
		{
			get {
				return false;
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
		public string Lowsrc
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
		public int NaturalHeight
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int NaturalWidth
		{
			get {
				return 0;
			}
		}

		public void RemoveEventListener(ImageElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ImageElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture)
		{
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
		public string UseMap
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int Vspace
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int Width
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int X
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public int Y
		{
			get {
				return 0;
			}
		}
	}
}
