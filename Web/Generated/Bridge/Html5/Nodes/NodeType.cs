namespace Bridge.Html5.Nodes
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum NodeType
	{
		Element = 1,
		Attribute = 2,
		Text = 3,
		CDATA = 4,
		EntityReference = 5,
		Entity = 6,
		ProcessingInstruction = 7,
		Comment = 8,
		Document = 9,
		DocumentType = 10,
		DocumentFragment = 11,
		Notation = 12
	}
}
