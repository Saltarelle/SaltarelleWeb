namespace Bridge.Html5.Xml
{
	[External, Name("Object")]
	public partial interface INodeFilter
	{
		NodeFilterReturn AcceptNode(XmlNode node);
	}
}
