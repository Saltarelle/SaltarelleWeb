using Bridge.Html5.Nodes;

namespace Bridge.Html5.Xml
{
	[Namespace(false), External, Name("XMLSerializer")]
	public partial class XmlSerializer
	{
		public extern XmlSerializer();

		public extern string SerializeToString(Node root);
	}
}
