using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class PluginArray
	{
		internal extern PluginArray();

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[int index]
		{
			get;
		}

		[IndexerName("__Item"), FieldProperty]
		public Plugin this[string name]
		{
			get;
		}

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<Plugin> GetEnumerator();

		public extern Plugin Item(int index);

		[FieldProperty]
		public extern int Length
		{
			get;
		}

		public extern Plugin NamedItem(string name);

		public extern void Refresh();

		public extern void Refresh(bool reloadDocuments);
	}
}
