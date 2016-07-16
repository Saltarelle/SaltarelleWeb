using System.Runtime.CompilerServices;
using System.Xml;

namespace System.Html {
	[IgnoreNamespace, Imported]
	public partial interface IGeometryUtils {
		DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from);

		DOMPoint ConvertPointFromNode(DOMPointInit point, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from);

		DOMQuad ConvertQuadFromNode(DOMQuad quad, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from);

		DOMQuad ConvertRectFromNode(DOMRectReadOnly rect, TypeOption<XmlText, Element, DocumentBase> from, ConvertCoordinateOptions options);

		DOMQuad[] GetBoxQuads();

		DOMQuad[] GetBoxQuads(BoxQuadOptions options);
	}
}
