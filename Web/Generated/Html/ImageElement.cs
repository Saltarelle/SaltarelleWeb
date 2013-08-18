using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'IMG'"), ScriptName("Element")]
	public partial class ImageElement : Element {
		[InlineCode("new Image()")]
		public ImageElement() {
		}

		[InlineCode("new Image({width})")]
		public ImageElement(uint width) {
		}

		[InlineCode("new Image({width}, {height})")]
		public ImageElement(uint width, uint height) {
		}

		public void AddEventListener(ImageElementEvents type, Action listener) {
		}

		public void AddEventListener(ImageElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener) {
		}

		public void AddEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture) {
		}

		public void AddEventListener(ImageElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(ImageElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Align {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Alt {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Border {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Complete {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string CrossOrigin {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint Height {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint Hspace {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool IsMap {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string LongDesc {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Lowsrc {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Name {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint NaturalHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint NaturalWidth {
			get {
				return 0;
			}
		}

		public void RemoveEventListener(ImageElementEvents type, Action listener) {
		}

		public void RemoveEventListener(ImageElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener) {
		}

		public void RemoveEventListener(ImageElementEvents type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture) {
		}

		public void RemoveEventListener(ImageElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(ImageElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ImageElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public string Src {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string UseMap {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint Width {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public uint Vspace {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int X {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int Y {
			get {
				return 0;
			}
		}
	}
}
