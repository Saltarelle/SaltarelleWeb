using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5
{
	[Namespace(false), External]
	public partial class PluginArray : IEnumerable<Plugin>
	{
		internal extern PluginArray();

		public extern Plugin this[int index]
		{
			get;
		}

		public extern Plugin this[string name]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<Plugin> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern Plugin Item(int index);

		public readonly int Length;

		public extern Plugin NamedItem(string name);

		public extern void Refresh();

		public extern void Refresh(bool reloadDocuments);
	}
}
