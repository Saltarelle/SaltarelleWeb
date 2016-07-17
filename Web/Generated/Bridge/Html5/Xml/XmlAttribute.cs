namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Attr")]
	public partial class XmlAttribute : XmlNode
	{
		internal extern XmlAttribute();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture);

		public extern void AddEventListener(XmlAttributeEvents type, Action listener);

		public extern void AddEventListener(XmlAttributeEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlAttributeEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlAttributeEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlAttributeEvents type, HtmlEventHandlerWithTarget<XmlAttribute> listener);

		public extern void AddEventListener(XmlAttributeEvents type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture);

		public extern void AddEventListener(XmlAttributeEvents type, IEventListener listener);

		public extern void AddEventListener(XmlAttributeEvents type, IEventListener listener, bool capture);

		public readonly string LocalName;

		public readonly string Name;

		public readonly string NamespaceURI;

		public readonly XmlElement OwnerElement;

		public readonly string Prefix;

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture);

		public extern void RemoveEventListener(XmlAttributeEvents type, Action listener);

		public extern void RemoveEventListener(XmlAttributeEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlAttributeEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlAttributeEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlAttributeEvents type, HtmlEventHandlerWithTarget<XmlAttribute> listener);

		public extern void RemoveEventListener(XmlAttributeEvents type, HtmlEventHandlerWithTarget<XmlAttribute> listener, bool capture);

		public extern void RemoveEventListener(XmlAttributeEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlAttributeEvents type, IEventListener listener, bool capture);

		public readonly bool Specified;

		public string Value;
	}
}
