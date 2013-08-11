// NodeFilter.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Xml {
	[Flags, Imported]
	public enum NodeFilter {
		ShowAll = -1,
		ShowElement = 1,
		ShowAttribute = 2,
		ShowText = 4,
		ShowCdataSection = 8,
		ShowEntityReference = 16,
		ShowEntity = 32,
		ShowProcessingInstruction = 64,
		ShowComment = 128,
		ShowDocument = 256,
		ShowDocumentType = 512,
		ShowDocumentFragment = 1024,
		ShowNotation = 2048,
	}
}
