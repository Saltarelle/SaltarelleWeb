using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PluginArray
	{
		internal PluginArray()
		{
		}

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[int index]
		{
			get {
				return default(Plugin);
			}
		}

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[string name]
		{
			get {
				return default(Plugin);
			}
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<Plugin> GetEnumerator()
		{
			return null;
		}

		public Plugin Item(int index)
		{
			return default(Plugin);
		}

		[FieldProperty]
		public int Length
		{
			get {
				return 0;
			}
		}

		public Plugin NamedItem(string name)
		{
			return default(Plugin);
		}

		public void Refresh()
		{
		}

		public void Refresh(bool reloadDocuments)
		{
		}
	}
}
