namespace Bridge.Html5.Nodes
{
	[External, Name("Object"), ExternalInterface]
	public partial interface INodeFilter
	{
		NodeFilterResult AcceptNode(Node node);
	}
}
