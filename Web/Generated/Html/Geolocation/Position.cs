// Position.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Geolocation {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true), ScriptName("Object")]
	public partial class Position {
		internal Position() {
		}

		[IntrinsicProperty]
		public Coordinates Coords {
			get { return default(Coordinates); }
		}

		[IntrinsicProperty]
		public long Timestamp {
			get { return 0; }
		}
	}
}
