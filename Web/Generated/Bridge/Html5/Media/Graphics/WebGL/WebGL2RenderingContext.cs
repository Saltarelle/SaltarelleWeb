namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace(false), External]
	public partial class WebGL2RenderingContext : WebGLRenderingContext
	{
		internal extern WebGL2RenderingContext();

		[Name("ANY_SAMPLES_PASSED")]
		public const int ANY_SAMPLES_PASSED = 35887;

		[Name("ANY_SAMPLES_PASSED_CONSERVATIVE")]
		public const int ANY_SAMPLES_PASSED_CONSERVATIVE = 36202;

		public extern void BeginQuery(int target, WebGLQuery queryObject);

		public extern void BindBufferBase(int target, int index, WebGLBuffer buffer);

		public extern void BindBufferRange(int target, int index, WebGLBuffer buffer, long offset, long size);

		public extern void BindVertexArray(WebGLVertexArray arrayObject);

		[Name("COLOR_ATTACHMENT1")]
		public const int COLOR_ATTACHMENT1 = 36065;

		[Name("COLOR_ATTACHMENT10")]
		public const int COLOR_ATTACHMENT10 = 36074;

		[Name("COLOR_ATTACHMENT11")]
		public const int COLOR_ATTACHMENT11 = 36075;

		[Name("COLOR_ATTACHMENT12")]
		public const int COLOR_ATTACHMENT12 = 36076;

		[Name("COLOR_ATTACHMENT13")]
		public const int COLOR_ATTACHMENT13 = 36077;

		[Name("COLOR_ATTACHMENT14")]
		public const int COLOR_ATTACHMENT14 = 36078;

		[Name("COLOR_ATTACHMENT15")]
		public const int COLOR_ATTACHMENT15 = 36079;

		[Name("COLOR_ATTACHMENT2")]
		public const int COLOR_ATTACHMENT2 = 36066;

		[Name("COLOR_ATTACHMENT3")]
		public const int COLOR_ATTACHMENT3 = 36067;

		[Name("COLOR_ATTACHMENT4")]
		public const int COLOR_ATTACHMENT4 = 36068;

		[Name("COLOR_ATTACHMENT5")]
		public const int COLOR_ATTACHMENT5 = 36069;

		[Name("COLOR_ATTACHMENT6")]
		public const int COLOR_ATTACHMENT6 = 36070;

		[Name("COLOR_ATTACHMENT7")]
		public const int COLOR_ATTACHMENT7 = 36071;

		[Name("COLOR_ATTACHMENT8")]
		public const int COLOR_ATTACHMENT8 = 36072;

		[Name("COLOR_ATTACHMENT9")]
		public const int COLOR_ATTACHMENT9 = 36073;

		public extern WebGLQuery CreateQuery();

		public extern WebGLVertexArray CreateVertexArray();

		[Name("CURRENT_QUERY")]
		public const int CURRENT_QUERY = 34917;

		public extern void DeleteQuery(WebGLQuery queryObject);

		public extern void DeleteVertexArray(WebGLVertexArray arrayObject);

		[Name("DRAW_BUFFER0")]
		public const int DRAW_BUFFER0 = 34853;

		[Name("DRAW_BUFFER1")]
		public const int DRAW_BUFFER1 = 34854;

		[Name("DRAW_BUFFER10")]
		public const int DRAW_BUFFER10 = 34863;

		[Name("DRAW_BUFFER11")]
		public const int DRAW_BUFFER11 = 34864;

		[Name("DRAW_BUFFER12")]
		public const int DRAW_BUFFER12 = 34865;

		[Name("DRAW_BUFFER13")]
		public const int DRAW_BUFFER13 = 34866;

		[Name("DRAW_BUFFER14")]
		public const int DRAW_BUFFER14 = 34867;

		[Name("DRAW_BUFFER15")]
		public const int DRAW_BUFFER15 = 34868;

		[Name("DRAW_BUFFER2")]
		public const int DRAW_BUFFER2 = 34855;

		[Name("DRAW_BUFFER3")]
		public const int DRAW_BUFFER3 = 34856;

		[Name("DRAW_BUFFER4")]
		public const int DRAW_BUFFER4 = 34857;

		[Name("DRAW_BUFFER5")]
		public const int DRAW_BUFFER5 = 34858;

		[Name("DRAW_BUFFER6")]
		public const int DRAW_BUFFER6 = 34859;

		[Name("DRAW_BUFFER7")]
		public const int DRAW_BUFFER7 = 34860;

		[Name("DRAW_BUFFER8")]
		public const int DRAW_BUFFER8 = 34861;

		[Name("DRAW_BUFFER9")]
		public const int DRAW_BUFFER9 = 34862;

		public extern void DrawArraysInstanced(int mode, int first, int count, int primcount);

		public extern void DrawBuffers(int[] buffers);

		public extern void DrawElementsInstanced(int mode, int count, int type, long offset, int primcount);

		public extern void EndQuery(int target);

		[Name("FRAGMENT_SHADER_DERIVATIVE_HINT")]
		public const int FRAGMENT_SHADER_DERIVATIVE_HINT = 35723;

		public extern object GetParameterIndexed(int pname, int index);

		public extern WebGLQuery GetQuery(int target, int pname);

		public extern object GetQueryObject(WebGLQuery queryObject, int pname);

		public extern bool IsQuery(WebGLQuery queryObject);

		public extern bool IsVertexArray(WebGLVertexArray arrayObject);

		public const int MAX = 32776;

		[Name("MAX_COLOR_ATTACHMENTS")]
		public const int MAX_COLOR_ATTACHMENTS = 36063;

		[Name("MAX_DRAW_BUFFERS")]
		public const int MAX_DRAW_BUFFERS = 34852;

		[Name("MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 35979;

		public const int MIN = 32775;

		[Name("QUERY_RESULT")]
		public const int QUERY_RESULT = 34918;

		[Name("QUERY_RESULT_AVAILABLE")]
		public const int QUERY_RESULT_AVAILABLE = 34919;

		[Name("RASTERIZER_DISCARD")]
		public const int RASTERIZER_DISCARD = 35977;

		[Name("TRANSFORM_FEEDBACK_BUFFER")]
		public const int TRANSFORM_FEEDBACK_BUFFER = 35982;

		[Name("TRANSFORM_FEEDBACK_BUFFER_BINDING")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 35983;

		[Name("TRANSFORM_FEEDBACK_BUFFER_SIZE")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 35973;

		[Name("TRANSFORM_FEEDBACK_BUFFER_START")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START = 35972;

		[Name("TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 35976;

		[Name("UNSIGNED_INT_24_8")]
		public const int UNSIGNED_INT_24_8 = 34042;

		[Name("VERTEX_ARRAY_BINDING")]
		public const int VERTEX_ARRAY_BINDING = 34229;

		[Name("VERTEX_ATTRIB_ARRAY_DIVISOR")]
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 35070;

		public extern void VertexAttribDivisor(int index, int divisor);
	}
}
