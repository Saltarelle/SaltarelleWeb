namespace Bridge.Html5.Nodes
{
	[Namespace(false), External]
	public partial class CharacterData : Node
	{
		internal extern CharacterData();

		public extern void AddEventListener(CharacterDataEvents type, Action listener);

		public extern void AddEventListener(CharacterDataEvents type, Action listener, bool capture);

		public extern void AddEventListener(CharacterDataEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(CharacterDataEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(CharacterDataEvents type, HtmlEventHandlerWithTarget<CharacterData> listener);

		public extern void AddEventListener(CharacterDataEvents type, HtmlEventHandlerWithTarget<CharacterData> listener, bool capture);

		public extern void AddEventListener(CharacterDataEvents type, IEventListener listener);

		public extern void AddEventListener(CharacterDataEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CharacterData> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<CharacterData> listener, bool capture);

		public extern void AppendData(string data);

		public string Data;

		public extern void DeleteData(int offset, int count);

		public extern void InsertData(int offset, string data);

		public readonly int Length;

		public readonly Node NextElementSibling;

		public readonly Node PreviousElementSibling;

		public extern void Remove();

		public extern void RemoveEventListener(CharacterDataEvents type, Action listener);

		public extern void RemoveEventListener(CharacterDataEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(CharacterDataEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(CharacterDataEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(CharacterDataEvents type, HtmlEventHandlerWithTarget<CharacterData> listener);

		public extern void RemoveEventListener(CharacterDataEvents type, HtmlEventHandlerWithTarget<CharacterData> listener, bool capture);

		public extern void RemoveEventListener(CharacterDataEvents type, IEventListener listener);

		public extern void RemoveEventListener(CharacterDataEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CharacterData> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<CharacterData> listener, bool capture);

		public extern void ReplaceData(int offset, int count, string data);

		public extern string SubstringData(int offset, int count);
	}
}
