using Bridge.Html5.Xml;
using System;

namespace Bridge.Html5
{
	[External, Serializable]
	public partial class BoxQuadOptions
	{
		public CSSBoxType Box;

		public TypeOption<XmlText, Element, DocumentBase> RelativeTo;
	}
}
