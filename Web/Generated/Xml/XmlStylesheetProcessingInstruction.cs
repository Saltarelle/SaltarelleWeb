// XmlStylesheetProcessingInstruction.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html;
using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("XMLStylesheetProcessingInstruction")]
	public partial class XmlStylesheetProcessingInstruction : XmlProcessingInstruction {
		internal XmlStylesheetProcessingInstruction() {
		}

		[IntrinsicProperty]
		public StyleSheet Sheet {
			get { return default(StyleSheet); }
		}
	}
}
