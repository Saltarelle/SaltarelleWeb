namespace Bridge.Html5.Xml
{
	[External]
	public partial interface INodeFilter
	{
		NodeFilterReturn AcceptNode(XmlNode node);
	}
}
