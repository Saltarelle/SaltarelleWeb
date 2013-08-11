// AudioSourceNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This is an abstract interface representing an audio source, an AudioNode which has no
	/// inputs and a single output:
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioSourceNode</reference>
	[IgnoreNamespace, Imported]
	public abstract class AudioSourceNode : AudioNode {
		protected AudioSourceNode() {
		}
	}
}