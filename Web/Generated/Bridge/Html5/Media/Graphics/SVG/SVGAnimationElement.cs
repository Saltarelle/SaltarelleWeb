namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGAnimationElement : SVGElement
	{
		internal extern SVGAnimationElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture);

		public extern void AddEventListener(SVGAnimationElementEvents type, Action listener);

		public extern void AddEventListener(SVGAnimationElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGAnimationElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGAnimationElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGAnimationElementEvents type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener);

		public extern void AddEventListener(SVGAnimationElementEvents type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture);

		public extern void AddEventListener(SVGAnimationElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGAnimationElementEvents type, IEventListener listener, bool capture);

		public extern void BeginElement();

		public extern void BeginElementAt(double offset);

		public extern void EndElement();

		public extern void EndElementAt(double offset);

		public extern double GetCurrentTime();

		public extern double GetSimpleDuration();

		public extern double GetStartTime();

		public extern bool HasExtension(string extension);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGAnimationElementEvents type, IEventListener listener, bool capture);

		public readonly SVGStringList RequiredExtensions;

		public readonly SVGStringList RequiredFeatures;

		public readonly SVGStringList SystemLanguage;

		public readonly SVGElement TargetElement;
	}
}
