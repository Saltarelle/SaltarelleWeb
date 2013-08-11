// XmlHttpRequest.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Net {
	[IgnoreNamespace]
	[Imported]
	[ScriptName("XMLHttpRequest")]
	public sealed class XmlHttpRequest {
		public void Abort() {
		}

		public string GetAllResponseHeaders() {
			return null;
		}

		public string GetResponseHeader(string name) {
			return null;
		}

		[IntrinsicProperty]
		[ScriptName("onreadystatechange")]
		public Action OnReadyStateChange {
			get { return null; }
			set { }
		}

		public void Open(string method, string url) {
		}

		public void Open(HttpVerb verb, string url) {
		}

		public void Open(string method, string url, bool @async) {
		}

		public void Open(HttpVerb verb, string url, bool @async) {
		}

		public void Open(string method, string url, bool @async, string userName, string password) {
		}

		public void Open(HttpVerb verb, string url, bool @async, string userName, string password) {
		}

		public void OverrideMimeType(string mimetype) {
		}

		[IntrinsicProperty]
		public ReadyState ReadyState {
			get { return ReadyState.Uninitialized; }
		}

		[IntrinsicProperty]
		public object Response {
			get { return null; }
		}

		[IntrinsicProperty]
		public string ResponseText {
			get { return null; }
		}

		[IntrinsicProperty]
		public string ResponseType {
			get { return null; }
			set { }
		}

		[IntrinsicProperty]
		[ScriptName("responseXML")]
		public XmlDocument ResponseXml {
			get { return null; }
		}

		public void Send() {
		}

		public void Send(string body) {
		}

		public void SetRequestHeader(string name, string value) {
		}

		[IntrinsicProperty]
		public int Status {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string StatusText {
			get { return null; }
		}

		[IntrinsicProperty]
		public uint Timeout {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public bool WithCredentials {
			get { return false; }
			set { }
		}
	}
}