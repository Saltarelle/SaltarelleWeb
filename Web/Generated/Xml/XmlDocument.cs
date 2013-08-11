// XmlDocument.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLDocument")]
	public partial class XmlDocument : DocumentBase {
		internal XmlDocument() {
		}

		[IntrinsicProperty]
		public bool Async {
			get { return false; }
			set { }
		}

		public bool Load(string url) {
			return false;
		}
	}
}
