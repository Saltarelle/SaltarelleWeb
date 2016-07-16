using System;

namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBRequest")]
	public partial class Request : EventTarget
	{
		internal Request()
		{
		}

		public void AddEventListener(RequestEvents type, Action listener)
		{
		}

		public void AddEventListener(RequestEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener)
		{
		}

		public void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture)
		{
		}

		public void AddEventListener(RequestEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(RequestEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture)
		{
		}

		[FieldProperty]
		public DOMError Error
		{
			get {
				return default(DOMError);
			}
		}

		[FieldProperty, Name("onerror")]
		public HtmlEventHandler OnError
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty, Name("onsuccess")]
		public HtmlEventHandler OnSuccess
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[FieldProperty]
		public RequestReadyState ReadyState
		{
			get {
				return default(RequestReadyState);
			}
		}

		public void RemoveEventListener(RequestEvents type, Action listener)
		{
		}

		public void RemoveEventListener(RequestEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener)
		{
		}

		public void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture)
		{
		}

		public void RemoveEventListener(RequestEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(RequestEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture)
		{
		}

		[FieldProperty]
		public object Result
		{
			get {
				return null;
			}
		}

		[FieldProperty]
		public TypeOption<ObjectStore, Index, Cursor> Source
		{
			get {
				return default(TypeOption<ObjectStore, Index, Cursor>);
			}
		}

		[FieldProperty]
		public Transaction Transaction
		{
			get {
				return default(Transaction);
			}
		}
	}
}
