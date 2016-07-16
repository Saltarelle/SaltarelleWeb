namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class ScriptProcessorNode : AudioNode
	{
		internal ScriptProcessorNode()
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, Action listener)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(ScriptProcessorNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture)
		{
		}

		[FieldProperty]
		public int BufferSize
		{
			get {
				return 0;
			}
		}

		[FieldProperty, Name("onaudioprocess")]
		public HtmlEventHandler OnAudioprocess
		{
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, Action listener)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(ScriptProcessorNodeEvents type, IEventListener listener, bool capture)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<ScriptProcessorNode> listener, bool capture)
		{
		}
	}
}
