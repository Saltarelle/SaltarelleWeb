using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class Plugin {
		internal Plugin() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MimeType this[string name] {
			get {
				return default(MimeType);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MimeType this[uint index] {
			get {
				return default(MimeType);
			}
		}

		[IntrinsicProperty]
		public string Description {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Filename {
			get {
				return null;
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MimeType> GetEnumerator() {
			return null;
		}

		public MimeType Item(uint index) {
			return default(MimeType);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
		}

		public MimeType NamedItem(string name) {
			return default(MimeType);
		}

		[IntrinsicProperty]
		public string Version {
			get {
				return null;
			}
		}
	}
}
