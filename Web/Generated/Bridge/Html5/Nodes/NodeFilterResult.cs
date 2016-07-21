namespace Bridge.Html5.Nodes
{
	[External, Name("Number"), Enum(Emit.Value)]
	public enum NodeFilterResult
	{
		Accept = 1,
		Reject = 2,
		Skip = 3
	}
}
