using System.IO;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'INPUT'"), ScriptName("Element")]
	public partial class InputElement : Element {
		internal InputElement() {
		}

		[IntrinsicProperty]
		public string Accept {
			get {
				return null;
			}
			set {
			}
		}

		public void AddEventListener(InputElementEvents type, Action listener) {
		}

		public void AddEventListener(InputElementEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener) {
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture) {
		}

		public void AddEventListener(InputElementEvents type, IEventListener listener) {
		}

		public void AddEventListener(InputElementEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture) {
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
		public string Autocomplete {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Autofocus {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Checked {
			get {
				return false;
			}
			set {
			}
		}

		public bool CheckValidity() {
			return false;
		}

		[IntrinsicProperty]
		public bool DefaultChecked {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string DefaultValue {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Disabled {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public FileList Files {
			get {
				return default(FileList);
			}
		}

		[IntrinsicProperty]
		public FormElement Form {
			get {
				return default(FormElement);
			}
		}

		[IntrinsicProperty]
		public string FormAction {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormEnctype {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormMethod {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool FormNoValidate {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string FormTarget {
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
		public bool Indeterminate {
			get {
				return false;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string InputMode {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public Element List {
			get {
				return default(Element);
			}
		}

		[IntrinsicProperty]
		public string Max {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int MaxLength {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Min {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Multiple {
			get {
				return false;
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

		public void OpenDirectoryPicker() {
		}

		[IntrinsicProperty]
		public string Pattern {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public string Placeholder {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool ReadOnly {
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(InputElementEvents type, Action listener) {
		}

		public void RemoveEventListener(InputElementEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener) {
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture) {
		}

		public void RemoveEventListener(InputElementEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(InputElementEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public bool Required {
			get {
				return false;
			}
			set {
			}
		}

		public void Select() {
		}

		[IntrinsicProperty]
		public string SelectionDirection {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int SelectionEnd {
			get {
				return 0;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int SelectionStart {
			get {
				return 0;
			}
			set {
			}
		}

		public void SetCustomValidity(string error) {
		}

		public void SetSelectionRange(int start, int end) {
		}

		public void SetSelectionRange(int start, int end, string direction) {
		}

		[IntrinsicProperty]
		public uint Size {
			get {
				return 0;
			}
			set {
			}
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
		public string Step {
			get {
				return null;
			}
			set {
			}
		}

		public void StepDown() {
		}

		public void StepDown(int n) {
		}

		public void StepUp() {
		}

		public void StepUp(int n) {
		}

		[IntrinsicProperty]
		public int TextLength {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Type {
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
		public string ValidationMessage {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ValidityState Validity {
			get {
				return default(ValidityState);
			}
		}

		[IntrinsicProperty]
		public string Value {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public DateTime? ValueAsDate {
			get {
				return null;
			}
			set {
			}
		}

		[IntrinsicProperty]
		public double ValueAsNumber {
			get {
				return 0;
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
		public bool WillValidate {
			get {
				return false;
			}
		}
	}
}
