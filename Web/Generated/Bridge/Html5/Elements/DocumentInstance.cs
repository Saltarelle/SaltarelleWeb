using Bridge.Html5.Editing;
using Bridge.Html5.Nodes;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("HTMLDocument")]
	public partial class DocumentInstance : DocumentBase
	{
		internal extern DocumentInstance();

		public extern object this[string name]
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

		public readonly HTMLCollection Anchors;

		public readonly HTMLCollection Applets;

		public string BgColor;

		public HTMLElement Body;

		public extern void CaptureEvents();

		public extern void Clear();

		public extern void Close();

		public string Cookie;

		public string DesignMode;

		public string Domain;

		public readonly HTMLCollection Embeds;

		public extern bool ExecCommand(string commandId);

		public extern bool ExecCommand(string commandId, bool showUI);

		public extern bool ExecCommand(string commandId, bool showUI, string value);

		public string FgColor;

		public readonly HTMLCollection Forms;

		public extern HTMLCollection GetElementsByName(string elementName);

		public extern HTMLCollection GetItems();

		public extern HTMLCollection GetItems(string typeNames);

		public extern Selection GetSelection();

		public readonly HTMLHeadElement Head;

		public readonly HTMLCollection Images;

		public string LinkColor;

		public readonly HTMLCollection Links;

		public extern DocumentBase Open();

		public extern DocumentBase Open(string type);

		public extern DocumentBase Open(string type, string replace);

		public extern WindowInstance Open(string url, string name, string features);

		public extern WindowInstance Open(string url, string name, string features, bool replace);

		public readonly HTMLCollection Plugins;

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

		public readonly HTMLCollection Scripts;

		public string VlinkColor;

		[ExpandParams]
		public extern void Write(params string[] text);

		[ExpandParams]
		public extern void Writeln(params string[] text);
	}
}
