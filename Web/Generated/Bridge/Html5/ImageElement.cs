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

		public string Align;

		public string Alt;

		public string Border;

		public readonly bool Complete;

		public string CrossOrigin;

		public int Height;

		public int Hspace;

		public bool IsMap;

		public string LongDesc;

		public string Lowsrc;

		public string Name;

		public readonly int NaturalHeight;

		public readonly int NaturalWidth;

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

		public string Src;

		public string UseMap;

		public int Vspace;

		public int Width;

		public readonly int X;

		public readonly int Y;
	}
}
