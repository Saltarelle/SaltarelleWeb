using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathElement : SVGGraphicsElement {
		internal SVGPathElement() {
		}

		[IntrinsicProperty]
		public SVGPathSegList AnimatedPathSegList {
			get { return default(SVGPathSegList); }
		}

		public SVGPathSegArcAbs CreateSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag) {
			return default(SVGPathSegArcAbs);
		}

		public SVGPathSegArcRel CreateSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag) {
			return default(SVGPathSegArcRel);
		}

		public SVGPathSegClosePath CreateSVGPathSegClosePath() {
			return default(SVGPathSegClosePath);
		}

		public SVGPathSegCurvetoCubicAbs CreateSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2) {
			return default(SVGPathSegCurvetoCubicAbs);
		}

		public SVGPathSegCurvetoCubicRel CreateSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2) {
			return default(SVGPathSegCurvetoCubicRel);
		}

		public SVGPathSegCurvetoCubicSmoothAbs CreateSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2) {
			return default(SVGPathSegCurvetoCubicSmoothAbs);
		}

		public SVGPathSegCurvetoCubicSmoothRel CreateSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2) {
			return default(SVGPathSegCurvetoCubicSmoothRel);
		}

		public SVGPathSegCurvetoQuadraticAbs CreateSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1) {
			return default(SVGPathSegCurvetoQuadraticAbs);
		}

		public SVGPathSegCurvetoQuadraticRel CreateSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1) {
			return default(SVGPathSegCurvetoQuadraticRel);
		}

		public SVGPathSegCurvetoQuadraticSmoothAbs CreateSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y) {
			return default(SVGPathSegCurvetoQuadraticSmoothAbs);
		}

		public SVGPathSegCurvetoQuadraticSmoothRel CreateSVGPathSegCurvetoQuadraticSmoothRel(float x, float y) {
			return default(SVGPathSegCurvetoQuadraticSmoothRel);
		}

		public SVGPathSegLinetoAbs CreateSVGPathSegLinetoAbs(float x, float y) {
			return default(SVGPathSegLinetoAbs);
		}

		public SVGPathSegLinetoHorizontalAbs CreateSVGPathSegLinetoHorizontalAbs(float x) {
			return default(SVGPathSegLinetoHorizontalAbs);
		}

		public SVGPathSegLinetoHorizontalRel CreateSVGPathSegLinetoHorizontalRel(float x) {
			return default(SVGPathSegLinetoHorizontalRel);
		}

		public SVGPathSegLinetoRel CreateSVGPathSegLinetoRel(float x, float y) {
			return default(SVGPathSegLinetoRel);
		}

		public SVGPathSegLinetoVerticalAbs CreateSVGPathSegLinetoVerticalAbs(float y) {
			return default(SVGPathSegLinetoVerticalAbs);
		}

		public SVGPathSegLinetoVerticalRel CreateSVGPathSegLinetoVerticalRel(float y) {
			return default(SVGPathSegLinetoVerticalRel);
		}

		public SVGPathSegMovetoAbs CreateSVGPathSegMovetoAbs(float x, float y) {
			return default(SVGPathSegMovetoAbs);
		}

		public SVGPathSegMovetoRel CreateSVGPathSegMovetoRel(float x, float y) {
			return default(SVGPathSegMovetoRel);
		}

		public uint GetPathSegAtLength(float distance) {
			return 0;
		}

		public SVGPoint GetPointAtLength(float distance) {
			return default(SVGPoint);
		}

		public float GetTotalLength() {
			return 0;
		}

		[IntrinsicProperty]
		public SVGAnimatedNumber PathLength {
			get { return default(SVGAnimatedNumber); }
		}

		[IntrinsicProperty]
		public SVGPathSegList PathSegList {
			get { return default(SVGPathSegList); }
		}
	}
}
