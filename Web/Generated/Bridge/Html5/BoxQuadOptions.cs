using Bridge.Html5.Xml;
using System;

namespace Bridge.Html5
{
	[External, Serializable]
	public partial class BoxQuadOptions
	{
		public extern CSSBoxType Box
		{
			get;
			set;
		}

		public extern TypeOption<XmlText, Element, DocumentBase> RelativeTo
		{
			get;
			set;
		}
	}
}
