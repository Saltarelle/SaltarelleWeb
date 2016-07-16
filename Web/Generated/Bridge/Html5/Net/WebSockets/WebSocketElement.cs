namespace Bridge.Html5.Net.WebSockets
{
	[External, Serializable]
	public partial class WebSocketElement
	{
		public extern bool Encrypted
		{
			get;
			set;
		}

		public extern string Hostport
		{
			get;
			set;
		}

		public extern int Msgreceived
		{
			get;
			set;
		}

		public extern int Msgsent
		{
			get;
			set;
		}

		public extern double Receivedsize
		{
			get;
			set;
		}

		public extern double Sentsize
		{
			get;
			set;
		}
	}
}
