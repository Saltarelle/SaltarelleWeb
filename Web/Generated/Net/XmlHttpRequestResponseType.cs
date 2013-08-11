// XmlHttpRequestResponseType.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Net {
	[Imported, NamedValues]
	public enum XmlHttpRequestResponseType {
		[ScriptName("")]
		String,
		Arraybuffer,
		Blob,
		Document,
		Json,
		Text,
	}
}
