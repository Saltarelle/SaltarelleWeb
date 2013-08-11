// WebGL2RenderingContext.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebGL2RenderingContext : WebGLRenderingContext {
		internal WebGL2RenderingContext() {
		}

		[ScriptName("ANY_SAMPLES_PASSED")]
		public const uint ANY_SAMPLES_PASSED = 35887;

		[ScriptName("ANY_SAMPLES_PASSED_CONSERVATIVE")]
		public const uint ANY_SAMPLES_PASSED_CONSERVATIVE = 36202;

		public void BeginQuery(uint target, WebGLQuery queryObject) {
		}

		public void BindVertexArray(WebGLVertexArray arrayObject) {
		}

		[ScriptName("COLOR_ATTACHMENT1")]
		public const uint COLOR_ATTACHMENT1 = 36065;

		[ScriptName("COLOR_ATTACHMENT10")]
		public const uint COLOR_ATTACHMENT10 = 36074;

		[ScriptName("COLOR_ATTACHMENT11")]
		public const uint COLOR_ATTACHMENT11 = 36075;

		[ScriptName("COLOR_ATTACHMENT12")]
		public const uint COLOR_ATTACHMENT12 = 36076;

		[ScriptName("COLOR_ATTACHMENT13")]
		public const uint COLOR_ATTACHMENT13 = 36077;

		[ScriptName("COLOR_ATTACHMENT14")]
		public const uint COLOR_ATTACHMENT14 = 36078;

		[ScriptName("COLOR_ATTACHMENT15")]
		public const uint COLOR_ATTACHMENT15 = 36079;

		[ScriptName("COLOR_ATTACHMENT2")]
		public const uint COLOR_ATTACHMENT2 = 36066;

		[ScriptName("COLOR_ATTACHMENT3")]
		public const uint COLOR_ATTACHMENT3 = 36067;

		[ScriptName("COLOR_ATTACHMENT4")]
		public const uint COLOR_ATTACHMENT4 = 36068;

		[ScriptName("COLOR_ATTACHMENT5")]
		public const uint COLOR_ATTACHMENT5 = 36069;

		[ScriptName("COLOR_ATTACHMENT6")]
		public const uint COLOR_ATTACHMENT6 = 36070;

		[ScriptName("COLOR_ATTACHMENT7")]
		public const uint COLOR_ATTACHMENT7 = 36071;

		[ScriptName("COLOR_ATTACHMENT8")]
		public const uint COLOR_ATTACHMENT8 = 36072;

		[ScriptName("COLOR_ATTACHMENT9")]
		public const uint COLOR_ATTACHMENT9 = 36073;

		public WebGLQuery CreateQuery() {
			return default(WebGLQuery);
		}

		public WebGLVertexArray CreateVertexArray() {
			return default(WebGLVertexArray);
		}

		[ScriptName("CURRENT_QUERY")]
		public const uint CURRENT_QUERY = 34917;

		public void DeleteQuery(WebGLQuery queryObject) {
		}

		public void DeleteVertexArray(WebGLVertexArray arrayObject) {
		}

		[ScriptName("DRAW_BUFFER0")]
		public const uint DRAW_BUFFER0 = 34853;

		[ScriptName("DRAW_BUFFER1")]
		public const uint DRAW_BUFFER1 = 34854;

		[ScriptName("DRAW_BUFFER10")]
		public const uint DRAW_BUFFER10 = 34863;

		[ScriptName("DRAW_BUFFER11")]
		public const uint DRAW_BUFFER11 = 34864;

		[ScriptName("DRAW_BUFFER12")]
		public const uint DRAW_BUFFER12 = 34865;

		[ScriptName("DRAW_BUFFER13")]
		public const uint DRAW_BUFFER13 = 34866;

		[ScriptName("DRAW_BUFFER14")]
		public const uint DRAW_BUFFER14 = 34867;

		[ScriptName("DRAW_BUFFER15")]
		public const uint DRAW_BUFFER15 = 34868;

		[ScriptName("DRAW_BUFFER2")]
		public const uint DRAW_BUFFER2 = 34855;

		[ScriptName("DRAW_BUFFER3")]
		public const uint DRAW_BUFFER3 = 34856;

		[ScriptName("DRAW_BUFFER4")]
		public const uint DRAW_BUFFER4 = 34857;

		[ScriptName("DRAW_BUFFER5")]
		public const uint DRAW_BUFFER5 = 34858;

		[ScriptName("DRAW_BUFFER6")]
		public const uint DRAW_BUFFER6 = 34859;

		[ScriptName("DRAW_BUFFER7")]
		public const uint DRAW_BUFFER7 = 34860;

		[ScriptName("DRAW_BUFFER8")]
		public const uint DRAW_BUFFER8 = 34861;

		[ScriptName("DRAW_BUFFER9")]
		public const uint DRAW_BUFFER9 = 34862;

		public void DrawArraysInstanced(uint mode, int first, int count, int primcount) {
		}

		public void DrawBuffers(uint[] buffers) {
		}

		public void DrawElementsInstanced(uint mode, int count, uint type, long offset, int primcount) {
		}

		public void EndQuery(uint target) {
		}

		public WebGLQuery GetQuery(uint target, uint pname) {
			return default(WebGLQuery);
		}

		public object GetQueryObject(WebGLQuery queryObject, uint pname) {
			return null;
		}

		public bool IsQuery(WebGLQuery queryObject) {
			return false;
		}

		public bool IsVertexArray(WebGLVertexArray arrayObject) {
			return false;
		}

		public const uint MAX = 32776;

		[ScriptName("MAX_COLOR_ATTACHMENTS")]
		public const uint MAX_COLOR_ATTACHMENTS = 36063;

		[ScriptName("MAX_DRAW_BUFFERS")]
		public const uint MAX_DRAW_BUFFERS = 34852;

		public const uint MIN = 32775;

		[ScriptName("QUERY_RESULT")]
		public const uint QUERY_RESULT = 34918;

		[ScriptName("QUERY_RESULT_AVAILABLE")]
		public const uint QUERY_RESULT_AVAILABLE = 34919;

		[ScriptName("VERTEX_ARRAY_BINDING")]
		public const uint VERTEX_ARRAY_BINDING = 34229;

		[ScriptName("VERTEX_ATTRIB_ARRAY_DIVISOR")]
		public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 35070;

		public void VertexAttribDivisor(uint index, uint divisor) {
		}
	}
}
