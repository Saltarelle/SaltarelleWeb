using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External]
	public partial class File : Blob
	{
		internal extern File();

		public readonly DateTime LastModifiedDate;

		public readonly string Name;
	}
}
