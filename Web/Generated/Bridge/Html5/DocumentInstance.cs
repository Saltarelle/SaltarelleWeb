using Bridge.Html5.Editing;
using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("HTMLDocument")]
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

		[FieldProperty]
		public extern string AlinkColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern object All
		{
			get;
		}

		[FieldProperty]
		public extern ElementCollection Anchors
		{
			get;
		}

		[FieldProperty]
		public extern ElementCollection Applets
		{
			get;
		}

		[FieldProperty]
		public extern string BgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern Element Body
		{
			get;
			set;
		}

		public extern void CaptureEvents();

		public extern void Clear();

		public extern void Close();

		[FieldProperty]
		public extern string Cookie
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string DesignMode
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Domain
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection Embeds
		{
			get;
		}

		public extern bool ExecCommand(string commandId);

		public extern bool ExecCommand(string commandId, bool showUI);

		public extern bool ExecCommand(string commandId, bool showUI, string value);

		[FieldProperty]
		public extern string FgColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection Forms
		{
			get;
		}

		public extern ElementNodeList GetElementsByName(string elementName);

		public extern ElementNodeList GetItems();

		public extern ElementNodeList GetItems(string typeNames);

		public extern Selection GetSelection();

		[FieldProperty]
		public extern HeadElement Head
		{
			get;
		}

		[FieldProperty]
		public extern ElementCollection Images
		{
			get;
		}

		[FieldProperty]
		public extern string LinkColor
		{
			get;
			set;
		}

		[FieldProperty]
		public extern ElementCollection Links
		{
			get;
		}

		public extern DocumentBase Open();

		public extern DocumentBase Open(string type);

		public extern DocumentBase Open(string type, string replace);

		public extern WindowInstance Open(string url, string name, string features);

		public extern WindowInstance Open(string url, string name, string features, bool replace);

		[FieldProperty]
		public extern ElementCollection Plugins
		{
			get;
		}

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

		[FieldProperty]
		public extern ElementCollection Scripts
		{
			get;
		}

		[FieldProperty]
		public extern string VlinkColor
		{
			get;
			set;
		}

		[ExpandParams]
		public extern void Write(params string[] text);

		[ExpandParams]
		public extern void Writeln(params string[] text);
	}
}
