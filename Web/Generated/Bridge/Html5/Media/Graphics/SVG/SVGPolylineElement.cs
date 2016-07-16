﻿namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGPolylineElement : SVGGraphicsElement
	{
		internal extern SVGPolylineElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture);

		public extern void AddEventListener(SVGPolylineElementEvents type, Action listener);

		public extern void AddEventListener(SVGPolylineElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGPolylineElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGPolylineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGPolylineElementEvents type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener);

		public extern void AddEventListener(SVGPolylineElementEvents type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture);

		public extern void AddEventListener(SVGPolylineElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGPolylineElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGPointList AnimatedPoints
		{
			get;
		}

		[FieldProperty]
		public extern SVGPointList Points
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, HtmlEventHandlerWithTarget<SVGPolylineElement> listener, bool capture);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGPolylineElementEvents type, IEventListener listener, bool capture);
	}
}
