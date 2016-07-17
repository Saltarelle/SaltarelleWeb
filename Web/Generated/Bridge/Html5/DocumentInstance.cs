using Bridge.Html5.Editing;
using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External, Name("HTMLDocument")]
	public partial class DocumentInstance : DocumentBase
	{
		internal extern DocumentInstance();

		[IndexerName("__Item"), FieldProperty]
		public object this[string name]
		{
			get;
		}

		public extern void AddEventListener(DocumentInstanceEvents type, Action listener);

		public extern void AddEventListener(DocumentInstanceEvents type, Action listener, bool capture);

		public extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public extern void AddEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public extern void AddEventListener(DocumentInstanceEvents type, IEventListener listener);

		public extern void AddEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public string AlinkColor;

		public readonly object All;

		public readonly ElementCollection Anchors;

		public readonly ElementCollection Applets;

		public string BgColor;

		public Element Body;

		public extern void CaptureEvents();

		public extern void Clear();

		public extern void Close();

		public string Cookie;

		public string DesignMode;

		public string Domain;

		public readonly ElementCollection Embeds;

		public extern bool ExecCommand(string commandId);

		public extern bool ExecCommand(string commandId, bool showUI);

		public extern bool ExecCommand(string commandId, bool showUI, string value);

		public string FgColor;

		public readonly ElementCollection Forms;

		public extern ElementNodeList GetElementsByName(string elementName);

		public extern ElementNodeList GetItems();

		public extern ElementNodeList GetItems(string typeNames);

		public extern Selection GetSelection();

		public readonly HeadElement Head;

		public readonly ElementCollection Images;

		public string LinkColor;

		public readonly ElementCollection Links;

		public extern DocumentBase Open();

		public extern DocumentBase Open(string type);

		public extern DocumentBase Open(string type, string replace);

		public extern WindowInstance Open(string url, string name, string features);

		public extern WindowInstance Open(string url, string name, string features, bool replace);

		public readonly ElementCollection Plugins;

		public extern bool QueryCommandEnabled(string commandId);

		public extern bool QueryCommandIndeterm(string commandId);

		public extern bool QueryCommandState(string commandId);

		public extern bool QueryCommandSupported(string commandId);

		public extern string QueryCommandValue(string commandId);

		public extern void ReleaseEvents();

		public extern void RemoveEventListener(DocumentInstanceEvents type, Action listener);

		public extern void RemoveEventListener(DocumentInstanceEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public extern void RemoveEventListener(DocumentInstanceEvents type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public extern void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener);

		public extern void RemoveEventListener(DocumentInstanceEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<DocumentInstance> listener, bool capture);

		public readonly ElementCollection Scripts;

		public string VlinkColor;

		[ExpandParams]
		public extern void Write(params string[] text);

		[ExpandParams]
		public extern void Writeln(params string[] text);
	}
}
