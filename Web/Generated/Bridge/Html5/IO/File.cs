using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class File : Blob
	{
		internal extern File();

		[FieldProperty]
		public extern DateTime LastModifiedDate
		{
			get;
		}

		[FieldProperty]
		public extern string Name
		{
			get;
		}
	}
}
