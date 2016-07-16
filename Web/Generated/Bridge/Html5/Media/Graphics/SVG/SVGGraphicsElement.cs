namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGGraphicsElement : SVGElement
	{
		internal extern SVGGraphicsElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener, bool capture);

		public extern void AddEventListener(SVGGraphicsElementEvents type, Action listener);

		public extern void AddEventListener(SVGGraphicsElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGGraphicsElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGGraphicsElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGGraphicsElementEvents type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener);

		public extern void AddEventListener(SVGGraphicsElementEvents type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener, bool capture);

		public extern void AddEventListener(SVGGraphicsElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGGraphicsElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGElement FarthestViewportElement
		{
			get;
		}

		public extern SVGRect GetBBox();

		public extern SVGMatrix GetCTM();

		public extern SVGMatrix GetScreenCTM();

		public extern SVGMatrix GetTransformToElement(SVGGraphicsElement element);

		public extern bool HasExtension(string extension);

		[FieldProperty]
		public extern SVGElement NearestViewportElement
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, HtmlEventHandlerWithTarget<SVGGraphicsElement> listener, bool capture);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGGraphicsElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGStringList RequiredExtensions
		{
			get;
		}

		[FieldProperty]
		public extern SVGStringList RequiredFeatures
		{
			get;
		}

		[FieldProperty]
		public extern SVGStringList SystemLanguage
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedTransformList Transform
		{
			get;
		}
	}
}
