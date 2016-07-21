using Bridge.Html5.CSS;
using Bridge.Html5.Elements;
using Bridge.Html5.Nodes;
using System;

namespace Bridge.Html5
{
	[External]
	public partial class BoxQuadOptions
	{
		public CSSBoxType Box;

		public TypeOption<Text, Element, DocumentBase> RelativeTo;
	}
}
