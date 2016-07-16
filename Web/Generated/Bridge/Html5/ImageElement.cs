namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IMG'"), Name("Element")]
	public partial class ImageElement : Element
	{
		[Template("new Image()")]
		public extern ImageElement();

		[Template("new Image({width})")]
		public extern ImageElement(int width);

		[Template("new Image({width}, {height})")]
		public extern ImageElement(int width, int height);

		public extern void AddEventListener(ImageElementEvents type, Action listener);

		public extern void AddEventListener(ImageElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(ImageElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener);

		public extern void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture);

		public extern void AddEventListener(ImageElementEvents type, IEventListener listener);

		public extern void AddEventListener(ImageElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Alt
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Border
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Complete
		{
			get;
		}

		[FieldProperty]
		public extern string CrossOrigin
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Hspace
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool IsMap
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string LongDesc
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Lowsrc
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int NaturalHeight
		{
			get;
		}

		[FieldProperty]
		public extern int NaturalWidth
		{
			get;
		}

		public extern void RemoveEventListener(ImageElementEvents type, Action listener);

		public extern void RemoveEventListener(ImageElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener);

		public extern void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture);

		public extern void RemoveEventListener(ImageElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(ImageElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture);

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string UseMap
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Vspace
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int X
		{
			get;
		}

		[FieldProperty]
		public extern int Y
		{
			get;
		}
	}
}
