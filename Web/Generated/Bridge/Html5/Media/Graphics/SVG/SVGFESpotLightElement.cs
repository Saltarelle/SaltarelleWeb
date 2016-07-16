﻿namespace Bridge.Html5.Media.Graphics.SVG
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class SVGFESpotLightElement : SVGElement
	{
		internal extern SVGFESpotLightElement();

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener);

		public extern void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener, bool capture);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, Action listener);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, Action listener, bool capture);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, HtmlEventHandler listener);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener, bool capture);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, IEventListener listener);

		public extern void AddEventListener(SVGFESpotLightElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber LimitingConeAngle
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber PointsAtX
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber PointsAtY
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber PointsAtZ
		{
			get;
		}

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener);

		public extern void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, Action listener);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, Action listener, bool capture);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, HtmlEventHandler listener);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, HtmlEventHandler listener, bool capture);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, HtmlEventHandlerWithTarget<SVGFESpotLightElement> listener, bool capture);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, IEventListener listener);

		public extern void RemoveEventListener(SVGFESpotLightElementEvents type, IEventListener listener, bool capture);

		[FieldProperty]
		public extern SVGAnimatedNumber SpecularExponent
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber X
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Y
		{
			get;
		}

		[FieldProperty]
		public extern SVGAnimatedNumber Z
		{
			get;
		}
	}
}
