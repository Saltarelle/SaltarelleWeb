using Bridge.Html5.IO;
using System;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'INPUT'"), Name("Element")]
	public partial class InputElement : Element
	{
		internal extern InputElement();

		[FieldProperty]
		public extern string Accept
		{
			get;
			set;
		}

		public extern void AddEventListener(InputElementEvents type, Action listener);

		public extern void AddEventListener(InputElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(InputElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener);

		public extern void AddEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture);

		public extern void AddEventListener(InputElementEvents type, IEventListener listener);

		public extern void AddEventListener(InputElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture);

		[FieldProperty]
		public extern string Align
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Alt
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Autocomplete
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Autofocus
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Checked
		{
			get;
			set;
		}

		public extern bool CheckValidity();

		[FieldProperty]
		public extern bool DefaultChecked
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string DefaultValue
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Disabled
		{
			get;
			set;
		}

		[FieldProperty]
		public extern FileList Files
		{
			get;
		}

		[FieldProperty]
		public extern FormElement Form
		{
			get;
		}

		[FieldProperty]
		public extern string FormAction
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormEnctype
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormMethod
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool FormNoValidate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string FormTarget
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Height
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Indeterminate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string InputMode
		{
			get;
			set;
		}

		[FieldProperty]
		public extern Element List
		{
			get;
		}

		[FieldProperty]
		public extern string Max
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int MaxLength
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Min
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Multiple
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
			set;
		}

		public extern void OpenDirectoryPicker();

		[FieldProperty]
		public extern string Pattern
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Placeholder
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool ReadOnly
		{
			get;
			set;
		}

		public extern void RemoveEventListener(InputElementEvents type, Action listener);

		public extern void RemoveEventListener(InputElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(InputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener);

		public extern void RemoveEventListener(InputElementEvents type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture);

		public extern void RemoveEventListener(InputElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(InputElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<InputElement> listener, bool capture);

		[FieldProperty]
		public extern bool Required
		{
			get;
			set;
		}

		public extern void Select();

		[FieldProperty]
		public extern string SelectionDirection
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int SelectionEnd
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int SelectionStart
		{
			get;
			set;
		}

		public extern void SetCustomValidity(string error);

		public extern void SetSelectionRange(int start, int end);

		public extern void SetSelectionRange(int start, int end, string direction);

		[FieldProperty]
		public extern int Size
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Step
		{
			get;
			set;
		}

		public extern void StepDown();

		public extern void StepDown(int n);

		public extern void StepUp();

		public extern void StepUp(int n);

		[FieldProperty]
		public extern int TextLength
		{
			get;
		}

		[FieldProperty]
		public extern string Type
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string UseMap
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string ValidationMessage
		{
			get;
		}

		[FieldProperty]
		public extern ValidityState Validity
		{
			get;
		}

		[FieldProperty]
		public extern string Value
		{
			get;
			set;
		}

		[FieldProperty]
		public extern DateTime? ValueAsDate
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double ValueAsNumber
		{
			get;
			set;
		}

		[FieldProperty]
		public extern int Width
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool WillValidate
		{
			get;
		}
	}
}
