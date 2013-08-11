// XmlCharacterData.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("CharacterData")]
	public partial class XmlCharacterData : XmlNode {
		internal XmlCharacterData() {
		}

		public void AppendData(string data) {
		}

		[IntrinsicProperty]
		public string Data {
			get { return null; }
			set { }
		}

		public void DeleteData(uint offset, uint count) {
		}

		public void InsertData(uint offset, string data) {
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}

		[IntrinsicProperty]
		public XmlElement NextElementSibling {
			get { return default(XmlElement); }
		}

		[IntrinsicProperty]
		public XmlElement PreviousElementSibling {
			get { return default(XmlElement); }
		}

		public void Remove() {
		}

		public void ReplaceData(uint offset, uint count, string data) {
		}

		public string SubstringData(uint offset, uint count) {
			return null;
		}
	}
}
