namespace Bridge.Html5
{
	[Namespace(false), External, Name("Object")]
	public partial interface IWindowBase64
	{
		string Atob(string atob);

		string Btoa(string btoa);
	}
}
