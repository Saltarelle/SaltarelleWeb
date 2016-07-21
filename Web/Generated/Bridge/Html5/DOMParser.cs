using Bridge.Html5.Elements;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class DOMParser
	{
		public extern DocumentBase ParseFromString(string str, DOMParserSupportedType type);
	}
}
