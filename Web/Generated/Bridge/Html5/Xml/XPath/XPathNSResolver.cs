namespace Bridge.Html5.Xml.XPath
{
	[Namespace(false), External]
	public partial class XPathNSResolver
	{
		internal extern XPathNSResolver();

		public extern string LookupNamespaceURI(string prefix);
	}
}
