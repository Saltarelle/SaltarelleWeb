namespace Bridge.Html5.IO
{
	[External, Name("String"), Enum(Emit.StringNameLowerCase)]
	public enum FileReaderEvents
	{
		Abort,
		Error,
		Load,
		Loadend,
		Loadstart,
		Progress
	}
}
