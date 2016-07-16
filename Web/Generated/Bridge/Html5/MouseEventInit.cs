namespace Bridge.Html5
{
	[External, Serializable]
	public partial class MouseEventInit
	{
		public extern bool AltKey
		{
			get;
			set;
		}

		public extern bool Bubbles
		{
			get;
			set;
		}

		public extern short Button
		{
			get;
			set;
		}

		public extern ushort Buttons
		{
			get;
			set;
		}

		public extern bool Cancelable
		{
			get;
			set;
		}

		public extern int ClientX
		{
			get;
			set;
		}

		public extern int ClientY
		{
			get;
			set;
		}

		public extern bool CtrlKey
		{
			get;
			set;
		}

		public extern int Detail
		{
			get;
			set;
		}

		public extern bool MetaKey
		{
			get;
			set;
		}

		public extern EventTarget RelatedTarget
		{
			get;
			set;
		}

		public extern int ScreenX
		{
			get;
			set;
		}

		public extern int ScreenY
		{
			get;
			set;
		}

		public extern bool ShiftKey
		{
			get;
			set;
		}

		public extern WindowInstance View
		{
			get;
			set;
		}
	}
}
