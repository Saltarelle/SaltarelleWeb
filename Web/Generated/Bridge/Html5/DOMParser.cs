using Bridge.Html5.Xml;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMParser
	{
		public extern DocumentBase ParseFromString(string str, DOMParserSupportedType type);
	}
}
