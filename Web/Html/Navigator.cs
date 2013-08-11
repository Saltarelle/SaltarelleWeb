// Navigator.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Navigator {
		[InlineCode("(navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozUserMedia || navigator.msGetUserMedia)({params}, {onsuccess})")]
		public static void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess) {}

		[InlineCode("(navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozUserMedia || navigator.msGetUserMedia)({params}, {onsuccess}, {onerror})")]
		public static void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess, Action<string> onerror) {}
	}
}