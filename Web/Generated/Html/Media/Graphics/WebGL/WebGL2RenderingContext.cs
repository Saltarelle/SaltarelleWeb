using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebGL2RenderingContext : WebGLRenderingContext {
		internal WebGL2RenderingContext() {
		}

		[ScriptName("ANY_SAMPLES_PASSED")]
		public const int ANY_SAMPLES_PASSED = 35887;

		[ScriptName("ANY_SAMPLES_PASSED_CONSERVATIVE")]
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 36202;

		public void BeginQuery(int target, WebGLQuery queryObject) {
		}

		public void BindBufferBase(int target, int index, WebGLBuffer buffer) {
		}

		public void BindBufferRange(int target, int index, WebGLBuffer buffer, long offset, long size) {
		}

		public void BindVertexArray(WebGLVertexArray arrayObject) {
		}

		[ScriptName("COLOR_ATTACHMENT1")]
		public const int COLOR_ATTACHMENT1 = 36065;

		[ScriptName("COLOR_ATTACHMENT10")]
		public const int COLOR_ATTACHMENT10 = 36074;

		[ScriptName("COLOR_ATTACHMENT11")]
		public const int COLOR_ATTACHMENT11 = 36075;

		[ScriptName("COLOR_ATTACHMENT12")]
		public const int COLOR_ATTACHMENT12 = 36076;

		[ScriptName("COLOR_ATTACHMENT13")]
		public const int COLOR_ATTACHMENT13 = 36077;

		[ScriptName("COLOR_ATTACHMENT14")]
		public const int COLOR_ATTACHMENT14 = 36078;

		[ScriptName("COLOR_ATTACHMENT15")]
		public const int COLOR_ATTACHMENT15 = 36079;

		[ScriptName("COLOR_ATTACHMENT2")]
		public const int COLOR_ATTACHMENT2 = 36066;

		[ScriptName("COLOR_ATTACHMENT3")]
		public const int COLOR_ATTACHMENT3 = 36067;

		[ScriptName("COLOR_ATTACHMENT4")]
		public const int COLOR_ATTACHMENT4 = 36068;

		[ScriptName("COLOR_ATTACHMENT5")]
		public const int COLOR_ATTACHMENT5 = 36069;

		[ScriptName("COLOR_ATTACHMENT6")]
		public const int COLOR_ATTACHMENT6 = 36070;

		[ScriptName("COLOR_ATTACHMENT7")]
		public const int COLOR_ATTACHMENT7 = 36071;

		[ScriptName("COLOR_ATTACHMENT8")]
		public const int COLOR_ATTACHMENT8 = 36072;

		[ScriptName("COLOR_ATTACHMENT9")]
		public const int COLOR_ATTACHMENT9 = 36073;

		public WebGLQuery CreateQuery() {
			return default(WebGLQuery);
		}

		public WebGLVertexArray CreateVertexArray() {
			return default(WebGLVertexArray);
		}

		[ScriptName("CURRENT_QUERY")]
		public const int CURRENT_QUERY = 34917;

		public void DeleteQuery(WebGLQuery queryObject) {
		}

		public void DeleteVertexArray(WebGLVertexArray arrayObject) {
		}

		[ScriptName("DRAW_BUFFER0")]
		public const int DRAW_BUFFER0 = 34853;

		[ScriptName("DRAW_BUFFER1")]
		public const int DRAW_BUFFER1 = 34854;

		[ScriptName("DRAW_BUFFER10")]
		public const int DRAW_BUFFER10 = 34863;

		[ScriptName("DRAW_BUFFER11")]
		public const int DRAW_BUFFER11 = 34864;

		[ScriptName("DRAW_BUFFER12")]
		public const int DRAW_BUFFER12 = 34865;

		[ScriptName("DRAW_BUFFER13")]
		public const int DRAW_BUFFER13 = 34866;

		[ScriptName("DRAW_BUFFER14")]
		public const int DRAW_BUFFER14 = 34867;

		[ScriptName("DRAW_BUFFER15")]
		public const int DRAW_BUFFER15 = 34868;

		[ScriptName("DRAW_BUFFER2")]
		public const int DRAW_BUFFER2 = 34855;

		[ScriptName("DRAW_BUFFER3")]
		public const int DRAW_BUFFER3 = 34856;

		[ScriptName("DRAW_BUFFER4")]
		public const int DRAW_BUFFER4 = 34857;

		[ScriptName("DRAW_BUFFER5")]
		public const int DRAW_BUFFER5 = 34858;

		[ScriptName("DRAW_BUFFER6")]
		public const int DRAW_BUFFER6 = 34859;

		[ScriptName("DRAW_BUFFER7")]
		public const int DRAW_BUFFER7 = 34860;

		[ScriptName("DRAW_BUFFER8")]
		public const int DRAW_BUFFER8 = 34861;

		[ScriptName("DRAW_BUFFER9")]
		public const int DRAW_BUFFER9 = 34862;

		public void DrawArraysInstanced(int mode, int first, int count, int primcount) {
		}

		public void DrawBuffers(int[] buffers) {
		}

		public void DrawElementsInstanced(int mode, int count, int type, long offset, int primcount) {
		}

		public void EndQuery(int target) {
		}

		[ScriptName("FRAGMENT_SHADER_DERIVATIVE_HINT")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 35723;

		public object GetParameterIndexed(int pname, int index) {
			return null;
		}

		public WebGLQuery GetQuery(int target, int pname) {
			return default(WebGLQuery);
		}

		public object GetQueryObject(WebGLQuery queryObject, int pname) {
			return null;
		}

		public bool IsQuery(WebGLQuery queryObject) {
			return false;
		}

		public bool IsVertexArray(WebGLVertexArray arrayObject) {
			return false;
		}

		public const int MAX = 32776;

		[ScriptName("MAX_COLOR_ATTACHMENTS")]
		public const int MAX_COLOR_ATTACHMENTS = 36063;

		[ScriptName("MAX_DRAW_BUFFERS")]
		public const int MAX_DRAW_BUFFERS = 34852;

		[ScriptName("MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 35979;

		public const int MIN = 32775;

		[ScriptName("QUERY_RESULT")]
		public const int QUERY_RESULT = 34918;

		[ScriptName("QUERY_RESULT_AVAILABLE")]
		public const int QUERY_RESULT_AVAILABLE = 34919;

		[ScriptName("RASTERIZER_DISCARD")]
		public const int RASTERIZER_DISCARD = 35977;

		[ScriptName("TRANSFORM_FEEDBACK_BUFFER")]
		public const int TRANSFORM_FEEDBACK_BUFFER = 35982;

		[ScriptName("TRANSFORM_FEEDBACK_BUFFER_BINDING")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 35983;

		[ScriptName("TRANSFORM_FEEDBACK_BUFFER_SIZE")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 35973;

		[ScriptName("TRANSFORM_FEEDBACK_BUFFER_START")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START = 35972;

		[ScriptName("TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 35976;

		[ScriptName("UNSIGNED_INT_24_8")]
		public const int UNSIGNED_INT_24_8 = 34042;

		[ScriptName("VERTEX_ARRAY_BINDING")]
		public const int VERTEX_ARRAY_BINDING = 34229;

		[ScriptName("VERTEX_ATTRIB_ARRAY_DIVISOR")]
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 35070;

		public void VertexAttribDivisor(int index, int divisor) {
		}
	}
}
