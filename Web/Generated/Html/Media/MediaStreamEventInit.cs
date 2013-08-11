// MediaStreamEventInit.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media {
	[Imported, Serializable]
	public partial class MediaStreamEventInit : EventInit {
		public MediaStream Stream {
			get { return default(MediaStream); }
			set { }
		}
	}
}
