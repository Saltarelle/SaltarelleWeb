using System.Collections;
using System.Collections.Generic;

namespace Bridge.Html5.IO
{
	[Namespace(false), External]
	public partial class FileList : IEnumerable<File>
	{
		internal extern FileList();

		public extern File this[int index]
		{
			get;
		}

		[Template("Bridge.getEnumerator({this})")]
		public extern IEnumerator<File> GetEnumerator();

		[Template("Bridge.getEnumerator({this})")]
		extern IEnumerator IEnumerable.GetEnumerator();

		public extern File Item(int index);

		public readonly int Length;
	}
}
