namespace Bridge.Html5.Xml
{
	[External, Name("Object"), ExternalInterface]
	public partial interface INodeFilter
	{
		NodeFilterReturn AcceptNode(XmlNode node);
	}
}
