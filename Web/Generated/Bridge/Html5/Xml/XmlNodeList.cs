using System.Collections.Generic;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("NodeList")]
	public partial class XmlNodeList
	{
		internal extern XmlNodeList();

		[IndexerName("__Item"), FieldProperty]
		public XmlNode this[int index]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<XmlNode> GetEnumerator();

		public extern XmlNode Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
