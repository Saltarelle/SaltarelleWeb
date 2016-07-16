namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("CharacterData")]
	public partial class XmlCharacterData : XmlNode
	{
		internal extern XmlCharacterData();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture);

		public extern void AddEventListener(XmlCharacterDataEvents type, Action listener);

		public extern void AddEventListener(XmlCharacterDataEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlCharacterDataEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlCharacterDataEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlCharacterDataEvents type, HtmlEventHandlerWithTarget<XmlCharacterData> listener);

		public extern void AddEventListener(XmlCharacterDataEvents type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture);

		public extern void AddEventListener(XmlCharacterDataEvents type, IEventListener listener);

		public extern void AddEventListener(XmlCharacterDataEvents type, IEventListener listener, bool capture);

		public extern void AppendData(string data);

		[FieldProperty]
		public extern string Data
		{
			get;
			set;
		}

		public extern void DeleteData(int offset, int count);

		public extern void InsertData(int offset, string data);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement NextElementSibling
		{
			get;
		}

		[FieldProperty]
		public extern XmlElement PreviousElementSibling
		{
			get;
		}

		public extern void Remove();

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, Action listener);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, HtmlEventHandlerWithTarget<XmlCharacterData> listener);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlCharacterDataEvents type, IEventListener listener, bool capture);

		public extern void ReplaceData(int offset, int count, string data);

		public extern string SubstringData(int offset, int count);
	}
}
