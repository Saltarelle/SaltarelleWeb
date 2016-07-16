namespace Bridge.Html5.IO
{
	[External, Enum(Emit.StringNamePreserveCase)]
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
