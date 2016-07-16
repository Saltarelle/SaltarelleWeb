﻿namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class AudioChannelManager : EventTarget
	{
		internal extern AudioChannelManager();

		public extern void AddEventListener(AudioChannelManagerEvents type, Action listener);

		public extern void AddEventListener(AudioChannelManagerEvents type, Action listener, bool capture);

		public extern void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener);

		public extern void AddEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture);

		public extern void AddEventListener(AudioChannelManagerEvents type, IEventListener listener);

		public extern void AddEventListener(AudioChannelManagerEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture);

		[FieldProperty]
		public extern bool Headphones
		{
			get;
		}

		[FieldProperty, Name("onheadphoneschange")]
		public extern HtmlEventHandler OnHeadphoneschange
		{
			get;
			set;
		}

		public extern void RemoveEventListener(AudioChannelManagerEvents type, Action listener);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, IEventListener listener);

		public extern void RemoveEventListener(AudioChannelManagerEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioChannelManager> listener, bool capture);

		[FieldProperty]
		public extern string VolumeControlChannel
		{
			get;
			set;
		}
	}
}
