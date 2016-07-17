namespace Bridge.Html5.Xml
{
	[Namespace("false"), External, Name("Comment")]
	public partial class XmlComment : XmlCharacterData
	{
		public extern XmlComment();

		public extern XmlComment(string data);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture);

		public extern void AddEventListener(XmlCommentEvents type, Action listener);

		public extern void AddEventListener(XmlCommentEvents type, Action listener, bool capture);

		public extern void AddEventListener(XmlCommentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(XmlCommentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(XmlCommentEvents type, HtmlEventHandlerWithTarget<XmlComment> listener);

		public extern void AddEventListener(XmlCommentEvents type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture);

		public extern void AddEventListener(XmlCommentEvents type, IEventListener listener);

		public extern void AddEventListener(XmlCommentEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture);

		public extern void RemoveEventListener(XmlCommentEvents type, Action listener);

		public extern void RemoveEventListener(XmlCommentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(XmlCommentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(XmlCommentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(XmlCommentEvents type, HtmlEventHandlerWithTarget<XmlComment> listener);

		public extern void RemoveEventListener(XmlCommentEvents type, HtmlEventHandlerWithTarget<XmlComment> listener, bool capture);

		public extern void RemoveEventListener(XmlCommentEvents type, IEventListener listener);

		public extern void RemoveEventListener(XmlCommentEvents type, IEventListener listener, bool capture);
	}
}
