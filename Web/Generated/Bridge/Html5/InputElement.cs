using Bridge.Html5.IO;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'INPUT'"), Name("Element")]
	public partial class InputElement : Element
	{
		internal InputElement()
		{
		}

		[FieldProperty]
		public string Accept
		{
			get {
				return null;
			}
			set {
			}
		}

		public void AddEventListener(InputElementEvents type, Action listener)
		{
		}

		public void AddEventListener(InputElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener)
		{
		}

		public void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture)
		{
		}

		public void AddEventListener(InputElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(InputElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public string Align
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Alt
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Autocomplete
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Autofocus
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Checked
		{
			get {
				return false;
			}
			set {
			}
		}

		public bool CheckValidity()
		{
			return false;
		}

		[FieldProperty]
		public bool DefaultChecked
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string DefaultValue
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Disabled
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public FileList Files
		{
			get {
				return default(FileList);
			}
		}

		[FieldProperty]
		public FormElement Form
		{
			get {
				return default(FormElement);
			}
		}

		[FieldProperty]
		public string FormAction
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormEnctype
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormMethod
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool FormNoValidate
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string FormTarget
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int Height
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Indeterminate
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string InputMode
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public Element List
		{
			get {
				return default(Element);
			}
		}

		[FieldProperty]
		public string Max
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int MaxLength
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string Min
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool Multiple
		{
			get {
				return false;
			}
			set {
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
			set {
			}
		}

		public void OpenDirectoryPicker()
		{
		}

		[FieldProperty]
		public string Pattern
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Placeholder
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public bool ReadOnly
		{
			get {
				return false;
			}
			set {
			}
		}

		public void RemoveEventListener(InputElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(InputElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener)
		{
		}

		public void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(InputElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(InputElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Required
		{
			get {
				return false;
			}
			set {
			}
		}

		public void Select()
		{
		}

		[FieldProperty]
		public string SelectionDirection
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public int SelectionEnd
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int SelectionStart
		{
			get {
				return 0;
			}
			set {
			}
		}

		public void SetCustomValidity(string error)
		{
		}

		public void SetSelectionRange(int start, int end)
		{
		}

		public void SetSelectionRange(int start, int end, string direction)
		{
		}

		[FieldProperty]
		public int Size
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public string Src
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Step
		{
			get {
				return null;
			}
			set {
			}
		}

		public void StepDown()
		{
		}

		public void StepDown(int n)
		{
		}

		public void StepUp()
		{
		}

		public void StepUp(int n)
		{
		}

		[FieldProperty]
		public int TextLength
		{
			get {
				return 0;
			}
		}

		[FieldProperty]
		public string Type
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string UseMap
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string ValidationMessage
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public ValidityState Validity
		{
			get {
				return default(ValidityState);
			}
		}

		[FieldProperty]
		public string Value
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public DateTime? ValueAsDate
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public double ValueAsNumber
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public int Width
		{
			get {
				return 0;
			}
			set {
			}
		}

		[FieldProperty]
		public bool WillValidate
		{
			get {
				return false;
			}
		}
	}
}
