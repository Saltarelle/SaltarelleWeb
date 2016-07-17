using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Element")]
	public partial class EmbedElement : Element
	{
		internal extern EmbedElement();

		public extern void AddEventListener(EmbedElementEvents type, Action listener);

		public extern void AddEventListener(EmbedElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(EmbedElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(EmbedElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(EmbedElementEvents type, HtmlEventHandlerWithTarget<EmbedElement> listener);

		public extern void AddEventListener(EmbedElementEvents type, HtmlEventHandlerWithTarget<EmbedElement> listener, bool capture);

		public extern void AddEventListener(EmbedElementEvents type, IEventListener listener);

		public extern void AddEventListener(EmbedElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<EmbedElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<EmbedElement> listener, bool capture);

		public string Align;

		[Template("{this}({*arguments})")]
		public extern object Call(params object[] arguments);

		public extern DocumentBase GetSVGDocument();

		public string Height;

		public string Name;

		public extern void RemoveEventListener(EmbedElementEvents type, Action listener);

		public extern void RemoveEventListener(EmbedElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(EmbedElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(EmbedElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(EmbedElementEvents type, HtmlEventHandlerWithTarget<EmbedElement> listener);

		public extern void RemoveEventListener(EmbedElementEvents type, HtmlEventHandlerWithTarget<EmbedElement> listener, bool capture);

		public extern void RemoveEventListener(EmbedElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(EmbedElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EmbedElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<EmbedElement> listener, bool capture);

		public string Src;

		public string Type;

		public string Width;
	}
}
