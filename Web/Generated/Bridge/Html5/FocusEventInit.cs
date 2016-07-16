namespace Bridge.Html5
{
	[External, Serializable]
	public partial class FocusEventInit : UIEventInit
	{
		public extern EventTarget RelatedTarget
		{
			get;
			set;
		}
	}
}
