namespace Bridge.Html5.Nodes
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum DocumentPosition
	{
		Disconnected = 1,
		Preceding = 2,
		Following = 4,
		Contains = 8,
		ContainedBy = 16,
		ImplementationSpecific = 32
	}
}
