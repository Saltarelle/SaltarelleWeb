﻿using System.Collections.TypedArrays;
using System.Html;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("DataChannel")]
	public partial class RTCDataChannel : EventTarget {
		internal RTCDataChannel() {
		}

		public void AddEventListener(RTCDataChannelEvents type, Action listener) {
		}

		public void AddEventListener(RTCDataChannelEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener) {
		}

		public void AddEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture) {
		}

		public void AddEventListener(RTCDataChannelEvents type, IEventListener listener) {
		}

		public void AddEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture) {
		}

		[IntrinsicProperty]
		public RTCDataChannelType BinaryType {
			get {
				return default(RTCDataChannelType);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int BufferedAmount {
			get {
				return 0;
			}
		}

		public void Close() {
		}

		[IntrinsicProperty]
		public ushort Id {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public string Label {
			get {
				return null;
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onopen")]
		public HtmlEventHandler OnOpen {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public bool Ordered {
			get {
				return false;
			}
		}

		[IntrinsicProperty]
		public string Protocol {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public RTCDataChannelState ReadyState {
			get {
				return default(RTCDataChannelState);
			}
		}

		[IntrinsicProperty]
		public bool Reliable {
			get {
				return false;
			}
		}

		public void RemoveEventListener(RTCDataChannelEvents type, Action listener) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(RTCDataChannelEvents type, IEventListener listener, bool capture) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<RTCDataChannel> listener, bool capture) {
		}

		public void Send(ArrayBuffer data) {
		}

		public void Send(ArrayBufferView data) {
		}

		public void Send(Blob data) {
		}

		public void Send(string data) {
		}

		[IntrinsicProperty]
		public ushort Stream {
			get {
				return 0;
			}
		}
	}
}
