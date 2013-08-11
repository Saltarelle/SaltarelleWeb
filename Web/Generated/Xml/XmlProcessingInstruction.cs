// XmlProcessingInstruction.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("ProcessingInstruction")]
	public partial class XmlProcessingInstruction : XmlCharacterData {
		internal XmlProcessingInstruction() {
		}

		[IntrinsicProperty]
		public string Target {
			get { return null; }
		}
	}
}
