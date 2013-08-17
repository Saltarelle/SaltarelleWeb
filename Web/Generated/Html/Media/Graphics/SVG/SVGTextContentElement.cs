using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGTextContentElement : SVGGraphicsElement {
		internal SVGTextContentElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture) {
		}

		public int GetCharNumAtPosition(SVGPoint point) {
			return 0;
		}

		public float GetComputedTextLength() {
			return 0;
		}

		public SVGPoint GetEndPositionOfChar(uint charnum) {
			return default(SVGPoint);
		}

		public SVGRect GetExtentOfChar(uint charnum) {
			return default(SVGRect);
		}

		public int GetNumberOfChars() {
			return 0;
		}

		public float GetRotationOfChar(uint charnum) {
			return 0;
		}

		public SVGPoint GetStartPositionOfChar(uint charnum) {
			return default(SVGPoint);
		}

		public float GetSubStringLength(uint charnum, uint nchars) {
			return 0;
		}

		[IntrinsicProperty]
		public SVGAnimatedEnumeration<SVGLengthAdjust> LengthAdjust {
			get {
				return default(SVGAnimatedEnumeration<SVGLengthAdjust>);
			}
		}

		[ScriptName("LENGTHADJUST_SPACING")]
		public const ushort LENGTHADJUST_SPACING = 1;

		[ScriptName("LENGTHADJUST_SPACINGANDGLYPHS")]
		public const ushort LENGTHADJUST_SPACINGANDGLYPHS = 2;

		[ScriptName("LENGTHADJUST_UNKNOWN")]
		public const ushort LENGTHADJUST_UNKNOWN = 0;

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGTextContentElement> listener, bool capture) {
		}

		public void SelectSubString(uint charnum, uint nchars) {
		}

		[IntrinsicProperty]
		public SVGAnimatedLength TextLength {
			get {
				return default(SVGAnimatedLength);
			}
		}
	}
}
