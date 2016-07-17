namespace Bridge.Html5
{
	[Namespace("false"), External]
	public partial class DOMStringMap
	{
		internal extern DOMStringMap();

		[IndexerName("__Item"), FieldProperty]
		public string this[string name]
		{
			get;
			set;
		}

		[Template("delete {this}[{name}]")]
		public extern void Delete(string name);
	}
}
