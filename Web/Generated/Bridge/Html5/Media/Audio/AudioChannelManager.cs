namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioChannelManager : EventTarget
	{
		internal AudioChannelManager()
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, Action listener)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AudioChannelManagerEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Headphones
		{
			get {
				return false;
			}
		}

		[FieldProperty, Name("onheadphoneschange")]
		public HtmlEventHandler OnHeadphoneschange
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AudioChannelManagerEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture)
		{
		}

		[FieldProperty]
		public string VolumeControlChannel
		{
			get {
				return null;
			}
			set {
			}
		}
	}
}
