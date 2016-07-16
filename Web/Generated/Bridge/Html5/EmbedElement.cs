using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'EMBED'"), Name("Element")]
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

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[Template("{this}({*arguments})")]
		public extern object Call(params object[] arguments);

		public extern DocumentBase GetSVGDocument();

		[FieldProperty]
		public extern string Height
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

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Width
		{
			get;
			set;
		}
	}
}
