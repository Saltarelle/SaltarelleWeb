using Bridge.Html5.Elements;
using Bridge.Html5.Nodes;
using System;

namespace Bridge.Html5
{
	[Namespace(false), External, Name("Object")]
	public partial interface IGeometryUtils
	{
		DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from);

		DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from);

		DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from);

		DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<Text, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad[] GetBoxQuads();

		DOMQuad[] GetBoxQuads(BoxQuadOptions options);
	}
}
