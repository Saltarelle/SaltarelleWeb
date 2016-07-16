using Bridge.Html5.Collections.TypedArrays;

namespace Bridge.Html5.Media.Audio
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SourceBuffer : EventTarget
	{
		internal extern SourceBuffer();

		public extern void Abort();

		public extern void AddEventListener(SourceBufferEvents type, Action listener);

		public extern void AddEventListener(SourceBufferEvents type, Action listener, bool capture);

		public extern void AddEventListener(SourceBufferEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SourceBufferEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener);

		public extern void AddEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture);

		public extern void AddEventListener(SourceBufferEvents type, IEventListener listener);

		public extern void AddEventListener(SourceBufferEvents type, IEventListener listener, bool capture);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture);

		public extern void AppendBuffer(ArrayBuffer data);

		public extern void AppendBuffer(ArrayBufferView data);

		[FieldProperty]
		public extern double AppendWindowEnd
		{
			get;
			set;
		}

		[FieldProperty]
		public extern double AppendWindowStart
		{
			get;
			set;
		}

		[FieldProperty]
		public extern TimeRanges Buffered
		{
			get;
		}

		[FieldProperty]
		public extern SourceBufferAppendMode Mode
		{
			get;
			set;
		}

		public extern void Remove(double start, double end);

		public extern void RemoveEventListener(SourceBufferEvents type, Action listener);

		public extern void RemoveEventListener(SourceBufferEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SourceBufferEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SourceBufferEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener);

		public extern void RemoveEventListener(SourceBufferEvents type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture);

		public extern void RemoveEventListener(SourceBufferEvents type, IEventListener listener);

		public extern void RemoveEventListener(SourceBufferEvents type, IEventListener listener, bool capture);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SourceBuffer> listener, bool capture);

		[FieldProperty]
		public extern double TimestampOffset
		{
			get;
			set;
		}

		[FieldProperty]
		public extern bool Updating
		{
			get;
		}
	}
}
