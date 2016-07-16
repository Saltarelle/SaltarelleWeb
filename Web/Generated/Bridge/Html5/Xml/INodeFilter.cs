namespace Bridge.Html5.Xml
{
	[External]
	public partial interface INodeFilter
	{
		extern NodeFilterReturn AcceptNode(XmlNode node);
	}
}
