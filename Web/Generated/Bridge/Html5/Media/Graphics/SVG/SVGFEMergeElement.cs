namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFEMergeElement : SVGElement
	{
		internal extern SVGFEMergeElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener, bool capture);

		public extern void AddEventListener(SVGFEMergeElementEvents type, Action listener);

		public extern void AddEventListener(SVGFEMergeElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFEMergeElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFEMergeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFEMergeElementEvents type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener);

		public extern void AddEventListener(SVGFEMergeElementEvents type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener, bool capture);

		public extern void AddEventListener(SVGFEMergeElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFEMergeElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedLength Height
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, HtmlEventHandlerWithTarget<SVGFEMergeElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFEMergeElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedString Result
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Width
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedLength Y
		{
			get;
		}
	}
}
