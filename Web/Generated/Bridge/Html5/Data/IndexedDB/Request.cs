using System;

namespace Bridge.Html5.Data.IndexedDB
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("IDBRequest")]
	public partial class Request : EventTarget
	{
		internal extern Request();

		public extern void AddEventListener(RequestEvents type, Action listener);

		public extern void AddEventListener(RequestEvents type, Action listener, bool capture);

		public extern void AddEventListener(RequestEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(RequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener);

		public extern void AddEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture);

		public extern void AddEventListener(RequestEvents type, IEventListener listener);

		public extern void AddEventListener(RequestEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture);

		[FieldProperty]
		public extern DOMError Error
		{
			get;
		}

		[FieldProperty, Name("onerror")]
		public extern HtmlEventHandler OnError
		{
			get;
			set;
		}

		[FieldProperty, Name("onsuccess")]
		public extern HtmlEventHandler OnSuccess
		{
			get;
			set;
		}

		[FieldProperty]
		public extern RequestReadyState ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(RequestEvents type, Action listener);

		public extern void RemoveEventListener(RequestEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(RequestEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(RequestEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener);

		public extern void RemoveEventListener(RequestEvents type, HtmlEventHandlerWithTarget<Request> listener, bool capture);

		public extern void RemoveEventListener(RequestEvents type, IEventListener listener);

		public extern void RemoveEventListener(RequestEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<Request> listener, bool capture);

		[FieldProperty]
		public extern object Result
		{
			get;
		}

		[FieldProperty]
		public extern TypeOption<ObjectStore, Index, Cursor> Source
		{
			get;
		}

		[FieldProperty]
		public extern Transaction Transaction
		{
			get;
		}
	}
}
