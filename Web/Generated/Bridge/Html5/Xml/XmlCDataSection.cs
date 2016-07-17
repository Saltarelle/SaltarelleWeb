namespace Bridge.Html5.Xml
{
	[Namespace(false), External, Name("CDATASection")]
	public partial class XmlCDataSection : XmlText
	{
		internal extern XmlCDataSection();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCDataSection> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCDataSection> listener, bool capture);

		public extern void AddEventListener(XmlCDataSectionEvents type, Action listener);

		public extern void AddEventListener(XmlCDataSectionEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlCDataSectionEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlCDataSectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlCDataSectionEvents type, HtmlEventHandlerWithTarget<XmlCDataSection> listener);

		public extern void AddEventListener(XmlCDataSectionEvents type, HtmlEventHandlerWithTarget<XmlCDataSection> listener, bool capture);

		public extern void AddEventListener(XmlCDataSectionEvents type, IEventListener listener);

		public extern void AddEventListener(XmlCDataSectionEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCDataSection> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCDataSection> listener, bool capture);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, Action listener);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, HtmlEventHandlerWithTarget<XmlCDataSection> listener);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, HtmlEventHandlerWithTarget<XmlCDataSection> listener, bool capture);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlCDataSectionEvents type, IEventListener listener, bool capture);
	}
}
