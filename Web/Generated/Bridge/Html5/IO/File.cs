using System;

namespace Bridge.Html5.IO
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class File : Blob
	{
		internal File()
		{
		}

		[FieldProperty]
		public DateTime LastModifiedDate
		{
			get {
				return default(DateTime);
			}
		}

		[FieldProperty]
		public string Name
		{
			get {
				return null;
			}
		}
	}
}
