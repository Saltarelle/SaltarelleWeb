// NavigatorInstance.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Html.Media;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class NavigatorInstance {
		[InlineCode("({this}.getUserMedia || {this}.webkitGetUserMedia || {this}.mozUserMedia || {this}.msGetUserMedia)({params}, {onsuccess})")]
		public void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess) {}

		[InlineCode("({this}.getUserMedia || {this}.webkitGetUserMedia || {this}.mozUserMedia || {this}.msGetUserMedia)({params}, {onsuccess}, {onerror})")]
		public void GetUserMedia(MediaStreamOptions @params, Action<LocalMediaStream> onsuccess, Action<string> onerror) {}
	}
}