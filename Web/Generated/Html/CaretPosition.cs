// CaretPosition.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class CaretPosition {
		internal CaretPosition() {
		}

		public ClientRect GetClientRect() {
			return default(ClientRect);
		}

		[IntrinsicProperty]
		public uint Offset {
			get { return 0; }
		}

		[IntrinsicProperty]
		public XmlNode OffsetNode {
			get { return default(XmlNode); }
		}
	}
}
