// MessagePort.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MessagePort : EventTarget, ITransferable {
		internal MessagePort() {
		}

		public void Close() {
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get { return default(HtmlEventHandler); }
			set { }
		}

		public void PostMessage(object message) {
		}

		public void PostMessage(object message, ITransferable[] transfer) {
		}

		public void Start() {
		}
	}
}
