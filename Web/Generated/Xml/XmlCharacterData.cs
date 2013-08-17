using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("CharacterData")]
	public partial class XmlCharacterData : XmlNode {
		internal XmlCharacterData() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture) {
		}

		public void AppendData(string data) {
		}

		[IntrinsicProperty]
		public string Data {
			get {
				return null;
			}
			set {
			}
		}

		public void DeleteData(uint offset, uint count) {
		}

		public void InsertData(uint offset, string data) {
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public XmlElement NextElementSibling {
			get {
				return default(XmlElement);
			}
		}

		[IntrinsicProperty]
		public XmlElement PreviousElementSibling {
			get {
				return default(XmlElement);
			}
		}

		public void Remove() {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<XmlCharacterData> listener, bool capture) {
		}

		public void ReplaceData(uint offset, uint count, string data) {
		}

		public string SubstringData(uint offset, uint count) {
			return null;
		}
	}
}
