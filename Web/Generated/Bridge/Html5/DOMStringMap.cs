namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class DOMStringMap
	{
		internal DOMStringMap()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public string this[string name]
		{
			get {
				return null;
			}
			set {
			}
		}

		[Template("delete {this}[{name}]")]
		public void Delete(string name)
		{
		}
	}
}
