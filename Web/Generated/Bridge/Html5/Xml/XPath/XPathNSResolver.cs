namespace Bridge.Html5.Xml.XPath
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class XPathNSResolver
	{
		internal extern XPathNSResolver();

		public extern string LookupNamespaceURI(string prefix);
	}
}
