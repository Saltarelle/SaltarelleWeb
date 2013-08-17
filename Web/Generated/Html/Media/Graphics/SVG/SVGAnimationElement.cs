using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGAnimationElement : SVGElement {
		internal SVGAnimationElement() {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener) {
		}

		void AddEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture) {
		}

		public void BeginElement() {
		}

		public void BeginElementAt(float offset) {
		}

		public void EndElement() {
		}

		public void EndElementAt(float offset) {
		}

		public float GetCurrentTime() {
			return 0;
		}

		public float GetSimpleDuration() {
			return 0;
		}

		public float GetStartTime() {
			return 0;
		}

		public bool HasExtension(string extension) {
			return false;
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener) {
		}

		void RemoveEventListener(string type, HtmlEventHandlerWithTarget<SVGAnimationElement> listener, bool capture) {
		}

		[IntrinsicProperty]
		public SVGStringList RequiredExtensions {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGStringList RequiredFeatures {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGStringList SystemLanguage {
			get {
				return default(SVGStringList);
			}
		}

		[IntrinsicProperty]
		public SVGElement TargetElement {
			get {
				return default(SVGElement);
			}
		}
	}
}
