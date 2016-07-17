using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class File : Blob
	{
		internal extern File();

		public readonly DateTime LastModifiedDate;

		public readonly string Name;
	}
}
