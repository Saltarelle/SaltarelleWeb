namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'AUDIO'"), Name("Element")]
	public partial class AudioElement : MediaElement
	{
		[Template("new Audio()")]
		public AudioElement()
		{
		}

		[Template("new Audio({src})")]
		public AudioElement(string src)
		{
		}

		public void AddEventListener(AudioElementEvents type, Action listener)
		{
		}

		public void AddEventListener(AudioElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(AudioElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(AudioElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener)
		{
		}

		public void AddEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture)
		{
		}

		public void AddEventListener(AudioElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(AudioElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(AudioElementEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<AudioElement> listener, bool capture)
		{
		}
	}
}
