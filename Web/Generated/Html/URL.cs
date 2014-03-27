using System.Html.Media;
using System.IO;
using System.Media.Source;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class URL {
		internal URL() {
		}

		public URL(string url) {
		}

		public URL(string url, string @base) {
		}

		public URL(string url, URL @base) {
		}

		public static string CreateObjectURL(Blob blob) {
			return null;
		}

		public static string CreateObjectURL(Blob blob, ObjectUrlOptions options) {
			return null;
		}

		public static string CreateObjectURL(MediaSource source) {
			return null;
		}

		public static string CreateObjectURL(MediaSource source, ObjectUrlOptions options) {
			return null;
		}

		public static string CreateObjectURL(MediaStream stream) {
			return null;
		}

		public static string CreateObjectURL(MediaStream stream, ObjectUrlOptions options) {
			return null;
		}

		[IntrinsicProperty]
		public string Hash {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Host {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Hostname {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Href {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Origin {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public string Password {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Pathname {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Port {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Protocol {
			get {
				return null;
			}
			set {
			}
		}

		public static void RevokeObjectURL(string url) {
		}

		[IntrinsicProperty]
		public string Search {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public URLSearchParams SearchParams {
			get {
				return default(URLSearchParams);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Username {
			get {
				return null;
			}
			set {
			}
		}
	}
}
