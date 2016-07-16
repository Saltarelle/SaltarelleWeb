using Bridge.Html5.Media;

namespace Bridge.Html5
{
	[Namespace("false"), External(TypeCheckCode = "{$System.Script}.isInstanceOfType({this}, Element) && {this}.tagName === 'TRACK'"), Name("Element")]
	public partial class TrackElement : Element
	{
		internal extern TrackElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, Action listener);

		public extern void AddEventListener(TrackElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void AddEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void AddEventListener(TrackElementEvents type, IEventListener listener);

		public extern void AddEventListener(TrackElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern bool Default
		{
			get;
			set;
		}

		public const ushort ERROR = 3;

		[FieldProperty]
		public extern string Kind
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Label
		{
			get;
			set;
		}

		public const ushort LOADED = 2;

		public const ushort LOADING = 1;

		public const ushort NONE = 0;

		[FieldProperty]
		public extern ushort ReadyState
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, Action listener);

		public extern void RemoveEventListener(TrackElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener);

		public extern void RemoveEventListener(TrackElementEvents type, HtmlEventHandlerWithTarget<TrackElement> listener, bool capture);

		public extern void RemoveEventListener(TrackElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(TrackElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern string Src
		{
			get;
			set;
		}

		[FieldProperty]
		public extern string Srclang
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TextTrack Track
		{
			get;
		}
	}
}
