using System.Html.Editing;
using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("HTMLDocument")]
	public partial class DocumentInstance : DocumentBase {
		internal DocumentInstance() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public object this[string name] {
			get { return null; }
		}

		[IntrinsicProperty]
		public string AlinkColor {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public object All {
			get { return null; }
		}

		[IntrinsicProperty]
		public ElementCollection Anchors {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public ElementCollection Applets {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public string BgColor {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public Element Body {
			get { return default(Element); }
			set { }
		}

		public void CaptureEvents(int eventFlags) {
		}

		public void Clear() {
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public string Cookie {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string DesignMode {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public string Domain {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public ElementCollection Embeds {
			get { return default(ElementCollection); }
		}

		public bool ExecCommand(string commandId) {
			return false;
		}

		public bool ExecCommand(string commandId, bool showUI) {
			return false;
		}

		public bool ExecCommand(string commandId, bool showUI, string value) {
			return false;
		}

		[IntrinsicProperty]
		public string FgColor {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public ElementCollection Forms {
			get { return default(ElementCollection); }
		}

		public XmlNodeList GetElementsByName(string elementName) {
			return default(XmlNodeList);
		}

		public XmlNodeList GetItems() {
			return default(XmlNodeList);
		}

		public XmlNodeList GetItems(string typeNames) {
			return default(XmlNodeList);
		}

		public Selection GetSelection() {
			return default(Selection);
		}

		[IntrinsicProperty]
		public HeadElement Head {
			get { return default(HeadElement); }
		}

		[IntrinsicProperty]
		public ElementCollection Images {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public string LinkColor {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		public ElementCollection Links {
			get { return default(ElementCollection); }
		}

		public DocumentBase Open() {
			return default(DocumentBase);
		}

		public DocumentBase Open(string type) {
			return default(DocumentBase);
		}

		public DocumentBase Open(string type, string replace) {
			return default(DocumentBase);
		}

		public WindowInstance Open(string url, string name, string features) {
			return default(WindowInstance);
		}

		public WindowInstance Open(string url, string name, string features, bool replace) {
			return default(WindowInstance);
		}

		[IntrinsicProperty]
		public ElementCollection Plugins {
			get { return default(ElementCollection); }
		}

		public bool QueryCommandEnabled(string commandId) {
			return false;
		}

		public bool QueryCommandIndeterm(string commandId) {
			return false;
		}

		public bool QueryCommandState(string commandId) {
			return false;
		}

		public bool QueryCommandSupported(string commandId) {
			return false;
		}

		public string QueryCommandValue(string commandId) {
			return null;
		}

		public void ReleaseEvents(int eventFlags) {
		}

		[IntrinsicProperty]
		public ElementCollection Scripts {
			get { return default(ElementCollection); }
		}

		[IntrinsicProperty]
		public string VlinkColor {
			get { return null; }
			set { }
		}

		[ExpandParams]
		public void Write(params string[] text) {
		}

		[ExpandParams]
		public void Writeln(params string[] text) {
		}
	}
}
