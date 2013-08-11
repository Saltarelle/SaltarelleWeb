// DragEvent.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class DragEvent : MouseEvent {
		internal DragEvent() {
		}

		[IntrinsicProperty]
		public DataTransfer DataTransfer {
			get { return default(DataTransfer); }
		}
	}
}
