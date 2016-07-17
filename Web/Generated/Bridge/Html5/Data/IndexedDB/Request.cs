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

		public readonly DOMError Error;

		[Name("onerror")]
		public HtmlEventHandler OnError;

		[Name("onsuccess")]
		public HtmlEventHandler OnSuccess;

		public readonly RequestReadyState ReadyState;

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

		public readonly object Result;

		public readonly TypeOption<ObjectStore, Index, Cursor> Source;

		public readonly Transaction Transaction;
	}
}
