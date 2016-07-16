using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TEMPLATE'"), Name("Element")]
	public partial class TemplateElement : Element
	{
		internal extern TemplateElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture);

		public extern void AddEventListener(TemplateElementEvents type, Action listener);

		public extern void AddEventListener(TemplateElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TemplateElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TemplateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TemplateElementEvents type, HtmlEventHandlerWithTarget<TemplateElement> listener);

		public extern void AddEventListener(TemplateElementEvents type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture);

		public extern void AddEventListener(TemplateElementEvents type, IEventListener listener);

		public extern void AddEventListener(TemplateElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern XmlDocumentFragment Content
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture);

		public extern void RemoveEventListener(TemplateElementEvents type, Action listener);

		public extern void RemoveEventListener(TemplateElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TemplateElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TemplateElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TemplateElementEvents type, HtmlEventHandlerWithTarget<TemplateElement> listener);

		public extern void RemoveEventListener(TemplateElementEvents type, HtmlEventHandlerWithTarget<TemplateElement> listener, bool capture);

		public extern void RemoveEventListener(TemplateElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TemplateElementEvents type, IEventListener listener, bool capture);
	}
}
