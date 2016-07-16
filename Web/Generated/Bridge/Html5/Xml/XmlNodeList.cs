using System.Collections.Generic;

namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("NodeList")]
	public partial class XmlNodeList
	{
		internal XmlNodeList()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public XmlNode this[int index]
		{
			get {
				return default(XmlNode);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<XmlNode> GetEnumerator()
		{
			return null;
		}

		public XmlNode Item(int index)
		{
			return default(XmlNode);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}
	}
}
