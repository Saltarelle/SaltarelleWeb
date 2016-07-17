namespace Bridge.Html5.Xml
{
	[External, Flags, Name("Number"), Enum(Emit.Value)]
	public enum NodeFilter
	{
		ShowAll = -1,
		ShowAttribute = 2,
		ShowCdataSection = 8,
		ShowComment = 128,
		ShowDocument = 256,
		ShowDocumentFragment = 1024,
		ShowDocumentType = 512,
		ShowElement = 1,
		ShowEntity = 32,
		ShowEntityReference = 16,
		ShowNotation = 2048,
		ShowProcessingInstruction = 64,
		ShowText = 4
	}
}
