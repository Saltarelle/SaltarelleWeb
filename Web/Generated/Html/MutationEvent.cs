// MutationEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MutationEvent : Event {
		internal MutationEvent() {
		}

		public const ushort ADDITION = 2;

		[IntrinsicProperty]
		public ushort AttrChange {
			get { return 0; }
		}

		[IntrinsicProperty]
		public string AttrName {
			get { return null; }
		}

		public const ushort MODIFICATION = 1;

		[IntrinsicProperty]
		public string NewValue {
			get { return null; }
		}

		[IntrinsicProperty]
		public string PrevValue {
			get { return null; }
		}

		[IntrinsicProperty]
		public XmlNode RelatedNode {
			get { return default(XmlNode); }
		}

		public const ushort REMOVAL = 3;
	}
}
