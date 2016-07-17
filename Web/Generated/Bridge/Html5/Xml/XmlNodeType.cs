namespace Bridge.Html5.Xml
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum XmlNodeType
	{
		Attribute = 2,
		CDATA = 4,
		Comment = 8,
		Document = 9,
		DocumentFragment = 11,
		DocumentType = 10,
		Element = 1,
		Entity = 6,
		EntityReference = 5,
		Notation = 12,
		ProcessingInstruction = 7,
		Text = 3
	}
}
