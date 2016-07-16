using Bridge.Html5.Media;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TRACK'"), Name("Element")]
	public partial class TrackElement : Element
	{
		internal TrackElement()
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener)
		{
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture)
		{
		}

		public void AddEventListener(TrackElementEvents type, Action listener)
		{
		}

		public void AddEventListener(TrackElementEvents type, Action listener, bool capture)
		{
		}

		public void AddEventListener(TrackElementEvents type, HtmlEventHandler listener)
		{
		}

		public void AddEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener)
		{
		}

		public void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture)
		{
		}

		public void AddEventListener(TrackElementEvents type, IEventListener listener)
		{
		}

		public void AddEventListener(TrackElementEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public bool Default
		{
			get {
				return false;
			}
			set {
			}
		}

		public const ushort ERROR = 3;

		[FieldProperty]
		public string Kind
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Label
		{
			get {
				return null;
			}
			set {
			}
		}

		public const ushort LOADED = 2;

		public const ushort LOADING = 1;

		public const ushort NONE = 0;

		[FieldProperty]
		public ushort ReadyState
		{
			get {
				return 0;
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener)
		{
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, Action listener)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, Action listener, bool capture)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, IEventListener listener)
		{
		}

		public void RemoveEventListener(TrackElementEvents type, IEventListener listener, bool capture)
		{
		}

		[FieldProperty]
		public string Src
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public string Srclang
		{
			get {
				return null;
			}
			set {
			}
		}

		[FieldProperty]
		public TextTrack Track
		{
			get {
				return default(TextTrack);
			}
		}
	}
}
