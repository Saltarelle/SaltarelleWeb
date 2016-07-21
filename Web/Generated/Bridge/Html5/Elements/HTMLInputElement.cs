using Bridge.Html5.IO;
using System;

namespace Bridge.Html5.Elements
{
	[Namespace(false), External, Name("Element")]
	public partial class HTMLInputElement : HTMLElement
	{
		internal extern HTMLInputElement();

		public string Accept;

		public extern void AddEventListener(HTMLInputElementEvents type, Action listener);

		public extern void AddEventListener(HTMLInputElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(HTMLInputElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(HTMLInputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(HTMLInputElementEvents type, HtmlEventHandlerWithTarget<HTMLInputElement> listener);

		public extern void AddEventListener(HTMLInputElementEvents type, HtmlEventHandlerWithTarget<HTMLInputElement> listener, bool capture);

		public extern void AddEventListener(HTMLInputElementEvents type, IEventListener listener);

		public extern void AddEventListener(HTMLInputElementEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLInputElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<HTMLInputElement> listener, bool capture);

		public string Align;

		public string Alt;

		public string Autocomplete;

		public bool Autofocus;

		public bool Checked;

		public extern bool CheckValidity();

		public bool DefaultChecked;

		public string DefaultValue;

		public bool Disabled;

		public readonly FileList Files;

		public readonly HTMLFormElement Form;

		public string FormAction;

		public string FormEnctype;

		public string FormMethod;

		public bool FormNoValidate;

		public string FormTarget;

		public int Height;

		public bool Indeterminate;

		public string InputMode;

		public readonly HTMLElement List;

		public string Max;

		public int MaxLength;

		public string Min;

		public bool Multiple;

		public string Name;

		public extern void OpenDirectoryPicker();

		public string Pattern;

		public string Placeholder;

		public bool ReadOnly;

		public extern void RemoveEventListener(HTMLInputElementEvents type, Action listener);

		public extern void RemoveEventListener(HTMLInputElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(HTMLInputElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(HTMLInputElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(HTMLInputElementEvents type, HtmlEventHandlerWithTarget<HTMLInputElement> listener);

		public extern void RemoveEventListener(HTMLInputElementEvents type, HtmlEventHandlerWithTarget<HTMLInputElement> listener, bool capture);

		public extern void RemoveEventListener(HTMLInputElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(HTMLInputElementEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLInputElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<HTMLInputElement> listener, bool capture);

		public bool Required;

		public extern void Select();

		public string SelectionDirection;

		public int SelectionEnd;

		public int SelectionStart;

		public extern void SetCustomValidity(string error);

		public extern void SetSelectionRange(int start, int end);

		public extern void SetSelectionRange(int start, int end, string direction);

		public int Size;

		public string Src;

		public string Step;

		public extern void StepDown();

		public extern void StepDown(int n);

		public extern void StepUp();

		public extern void StepUp(int n);

		public readonly int TextLength;

		public string Type;

		public string UseMap;

		public readonly string ValidationMessage;

		public readonly ValidityState Validity;

		public string Value;

		public DateTime? ValueAsDate;

		public double ValueAsNumber;

		public int Width;

		public readonly bool WillValidate;
	}
}
