// Request.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Data.IndexedDB {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("IDBRequest")]
	public partial class Request : EventTarget {
		internal Request() {
		}

		[IntrinsicProperty]
		public DOMError Error {
			get { return default(DOMError); }
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty, ScriptName("onsuccess")]
		public HtmlEventHandler OnSuccess {
			get { return default(HtmlEventHandler); }
			set { }
		}

		[IntrinsicProperty]
		public RequestReadyState ReadyState {
			get { return default(RequestReadyState); }
		}

		[IntrinsicProperty]
		public object Result {
			get { return null; }
		}

		[IntrinsicProperty]
		public TypeOption<ObjectStore, Index, Cursor> Source {
			get { return default(TypeOption<ObjectStore, Index, Cursor>); }
		}

		[IntrinsicProperty]
		public Transaction Transaction {
			get { return default(Transaction); }
		}
	}
}
