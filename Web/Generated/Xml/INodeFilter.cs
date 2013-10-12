using System.Runtime.CompilerServices;

namespace System.Xml {
	[Imported]
	public partial interface INodeFilter {
		NodeFilterReturn AcceptNode(XmlNode node);
	}
}
