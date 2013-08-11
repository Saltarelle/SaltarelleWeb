using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[Imported, NamedValues]
	public enum CanvasContextId {
		[ScriptName("2d")]
		Render2D,
		[ScriptName("webgl")]
		RenderWebGL,
	}
}
