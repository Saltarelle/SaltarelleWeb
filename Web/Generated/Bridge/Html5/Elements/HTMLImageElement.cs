namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLImageElement : HTMLElement
	{
		[Template("new Image()")]
		public extern HTMLImageElement();

		[Template("new Image({width})")]
		public extern HTMLImageElement(int width);

		[Template("new Image({width}, {height})")]
		public extern HTMLImageElement(int width, int height);

		public extern void AddEventListener(HTMLImageElementEvents type, Action listener);

		public extern void AddEventListener(HTMLImageElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLImageElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLImageElementEvents type, HtmlEventHandlerWithTarget<HTMLImageElement> listener);

		public extern void AddEventListener(HTMLImageElementEvents type, HtmlEventHandlerWithTarget<HTMLImageElement> listener, bool capture);

		public extern void AddEventListener(HTMLImageElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLImageElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLImageElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLImageElement> listener, bool capture);

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

		public extern void RemoveEventListener(HTMLImageElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLImageElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLImageElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLImageElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLImageElementEvents type, HtmlEventHandlerWithTarget<HTMLImageElement> listener);

		public extern void RemoveEventListener(HTMLImageElementEvents type, HtmlEventHandlerWithTarget<HTMLImageElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLImageElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLImageElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLImageElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLImageElement> listener, bool capture);

		public string Src;

		public string UseMap;

		public int Vspace;

		public int Width;

		public readonly int X;

		public readonly int Y;
	}
}
