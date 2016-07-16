namespace Bridge.Html5.Xml
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("XMLSerializer")]
	public partial class XmlSerializer
	{
		public extern XmlSerializer();

		public extern string SerializeToString(XmlNode root);
	}
}
