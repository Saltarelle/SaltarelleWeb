// ClientRectList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class ClientRectList {
		internal ClientRectList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public ClientRect this[uint index] {
			get { return default(ClientRect); }
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<ClientRect> GetEnumerator() {
			return default(IEnumerator<ClientRect>);
		}

		public ClientRect Item(uint index) {
			return default(ClientRect);
		}

		[IntrinsicProperty]
		public uint Length {
			get { return 0; }
		}
	}
}
