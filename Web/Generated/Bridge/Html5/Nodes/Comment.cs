namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class Comment : CharacterData
	{
		public extern Comment();

		public extern Comment(string data);

		public extern void AddEventListener(CommentEvents type, Action listener);

		public extern void AddEventListener(CommentEvents type, Action listener, bool capture);

		public extern void AddEventListener(CommentEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(CommentEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(CommentEvents type, HtmlEventHandlerWithTarget<Comment> listener);

		public extern void AddEventListener(CommentEvents type, HtmlEventHandlerWithTarget<Comment> listener, bool capture);

		public extern void AddEventListener(CommentEvents type, IEventListener listener);

		public extern void AddEventListener(CommentEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Comment> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Comment> listener, bool capture);

		public extern void RemoveEventListener(CommentEvents type, Action listener);

		public extern void RemoveEventListener(CommentEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(CommentEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(CommentEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(CommentEvents type, HtmlEventHandlerWithTarget<Comment> listener);

		public extern void RemoveEventListener(CommentEvents type, HtmlEventHandlerWithTarget<Comment> listener, bool capture);

		public extern void RemoveEventListener(CommentEvents type, IEventListener listener);

		public extern void RemoveEventListener(CommentEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Comment> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Comment> listener, bool capture);
	}
}
