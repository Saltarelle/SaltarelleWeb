// WebGLRenderingContext.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebGLRenderingContext {
		internal WebGLRenderingContext() {
		}

		[ScriptName("ACTIVE_ATTRIBUTES")]
		public const uint ACTIVE_ATTRIBUTES = 35721;

		[ScriptName("ACTIVE_TEXTURE")]
		public const uint ACTIVE_TEXTURE = 34016;

		[ScriptName("ACTIVE_UNIFORMS")]
		public const uint ACTIVE_UNIFORMS = 35718;

		public void ActiveTexture(uint texture) {
		}

		[ScriptName("ALIASED_LINE_WIDTH_RANGE")]
		public const uint ALIASED_LINE_WIDTH_RANGE = 33902;

		[ScriptName("ALIASED_POINT_SIZE_RANGE")]
		public const uint ALIASED_POINT_SIZE_RANGE = 33901;

		public const uint ALPHA = 6406;

		[ScriptName("ALPHA_BITS")]
		public const uint ALPHA_BITS = 3413;

		public const uint ALWAYS = 519;

		[ScriptName("ARRAY_BUFFER")]
		public const uint ARRAY_BUFFER = 34962;

		[ScriptName("ARRAY_BUFFER_BINDING")]
		public const uint ARRAY_BUFFER_BINDING = 34964;

		[ScriptName("ATTACHED_SHADERS")]
		public const uint ATTACHED_SHADERS = 35717;

		public void AttachShader(WebGLProgram program, WebGLShader shader) {
		}

		public const uint BACK = 1029;

		public void BindAttribLocation(WebGLProgram program, uint index, string name) {
		}

		public void BindBuffer(uint target, WebGLBuffer buffer) {
		}

		public void BindFramebuffer(uint target, WebGLFramebuffer framebuffer) {
		}

		public void BindRenderbuffer(uint target, WebGLRenderbuffer renderbuffer) {
		}

		public void BindTexture(uint target, WebGLTexture texture) {
		}

		public const uint BLEND = 3042;

		[ScriptName("BLEND_COLOR")]
		public const uint BLEND_COLOR = 32773;

		[ScriptName("BLEND_DST_ALPHA")]
		public const uint BLEND_DST_ALPHA = 32970;

		[ScriptName("BLEND_DST_RGB")]
		public const uint BLEND_DST_RGB = 32968;

		[ScriptName("BLEND_EQUATION")]
		public const uint BLEND_EQUATION = 32777;

		[ScriptName("BLEND_EQUATION_ALPHA")]
		public const uint BLEND_EQUATION_ALPHA = 34877;

		[ScriptName("BLEND_EQUATION_RGB")]
		public const uint BLEND_EQUATION_RGB = 32777;

		[ScriptName("BLEND_SRC_ALPHA")]
		public const uint BLEND_SRC_ALPHA = 32971;

		[ScriptName("BLEND_SRC_RGB")]
		public const uint BLEND_SRC_RGB = 32969;

		public void BlendColor(float red, float green, float blue, float alpha) {
		}

		public void BlendEquation(uint mode) {
		}

		public void BlendEquationSeparate(uint modeRGB, uint modeAlpha) {
		}

		public void BlendFunc(uint sfactor, uint dfactor) {
		}

		public void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		}

		[ScriptName("BLUE_BITS")]
		public const uint BLUE_BITS = 3412;

		public const uint BOOL = 35670;

		[ScriptName("BOOL_VEC2")]
		public const uint BOOL_VEC2 = 35671;

		[ScriptName("BOOL_VEC3")]
		public const uint BOOL_VEC3 = 35672;

		[ScriptName("BOOL_VEC4")]
		public const uint BOOL_VEC4 = 35673;

		[ScriptName("BROWSER_DEFAULT_WEBGL")]
		public const uint BROWSER_DEFAULT_WEBGL = 37444;

		[ScriptName("BUFFER_SIZE")]
		public const uint BUFFER_SIZE = 34660;

		[ScriptName("BUFFER_USAGE")]
		public const uint BUFFER_USAGE = 34661;

		public void BufferData(uint target, ArrayBuffer data, uint usage) {
		}

		public void BufferData(uint target, ArrayBufferView data, uint usage) {
		}

		public void BufferData(uint target, long size, uint usage) {
		}

		public void BufferSubData(uint target, long offset, ArrayBuffer data) {
		}

		public void BufferSubData(uint target, long offset, ArrayBufferView data) {
		}

		public const uint BYTE = 5120;

		[IntrinsicProperty]
		public CanvasElement Canvas {
			get { return default(CanvasElement); }
		}

		public const uint CCW = 2305;

		public uint CheckFramebufferStatus(uint target) {
			return 0;
		}

		[ScriptName("CLAMP_TO_EDGE")]
		public const uint CLAMP_TO_EDGE = 33071;

		public void Clear(uint mask) {
		}

		public void ClearColor(float red, float green, float blue, float alpha) {
		}

		public void ClearDepth(float depth) {
		}

		public void ClearStencil(int s) {
		}

		[ScriptName("COLOR_ATTACHMENT0")]
		public const uint COLOR_ATTACHMENT0 = 36064;

		[ScriptName("COLOR_BUFFER_BIT")]
		public const uint COLOR_BUFFER_BIT = 16384;

		[ScriptName("COLOR_CLEAR_VALUE")]
		public const uint COLOR_CLEAR_VALUE = 3106;

		[ScriptName("COLOR_WRITEMASK")]
		public const uint COLOR_WRITEMASK = 3107;

		public void ColorMask(bool red, bool green, bool blue, bool alpha) {
		}

		[ScriptName("COMPILE_STATUS")]
		public const uint COMPILE_STATUS = 35713;

		public void CompileShader(WebGLShader shader) {
		}

		[ScriptName("COMPRESSED_TEXTURE_FORMATS")]
		public const uint COMPRESSED_TEXTURE_FORMATS = 34467;

		public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, ArrayBufferView data) {
		}

		public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, ArrayBufferView data) {
		}

		[ScriptName("CONSTANT_ALPHA")]
		public const uint CONSTANT_ALPHA = 32771;

		[ScriptName("CONSTANT_COLOR")]
		public const uint CONSTANT_COLOR = 32769;

		[ScriptName("CONTEXT_LOST_WEBGL")]
		public const uint CONTEXT_LOST_WEBGL = 37442;

		public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) {
		}

		public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		}

		public WebGLBuffer CreateBuffer() {
			return default(WebGLBuffer);
		}

		public WebGLFramebuffer CreateFramebuffer() {
			return default(WebGLFramebuffer);
		}

		public WebGLProgram CreateProgram() {
			return default(WebGLProgram);
		}

		public WebGLRenderbuffer CreateRenderbuffer() {
			return default(WebGLRenderbuffer);
		}

		public WebGLShader CreateShader(uint type) {
			return default(WebGLShader);
		}

		public WebGLTexture CreateTexture() {
			return default(WebGLTexture);
		}

		[ScriptName("CULL_FACE")]
		public const uint CULL_FACE = 2884;

		[ScriptName("CULL_FACE_MODE")]
		public const uint CULL_FACE_MODE = 2885;

		public void CullFace(uint mode) {
		}

		[ScriptName("CURRENT_PROGRAM")]
		public const uint CURRENT_PROGRAM = 35725;

		[ScriptName("CURRENT_VERTEX_ATTRIB")]
		public const uint CURRENT_VERTEX_ATTRIB = 34342;

		public const uint CW = 2304;

		public const uint DECR = 7683;

		[ScriptName("DECR_WRAP")]
		public const uint DECR_WRAP = 34056;

		[ScriptName("DELETE_STATUS")]
		public const uint DELETE_STATUS = 35712;

		public void DeleteBuffer(WebGLBuffer buffer) {
		}

		public void DeleteFramebuffer(WebGLFramebuffer framebuffer) {
		}

		public void DeleteProgram(WebGLProgram program) {
		}

		public void DeleteRenderbuffer(WebGLRenderbuffer renderbuffer) {
		}

		public void DeleteShader(WebGLShader shader) {
		}

		public void DeleteTexture(WebGLTexture texture) {
		}

		[ScriptName("DEPTH_ATTACHMENT")]
		public const uint DEPTH_ATTACHMENT = 36096;

		[ScriptName("DEPTH_BITS")]
		public const uint DEPTH_BITS = 3414;

		[ScriptName("DEPTH_BUFFER_BIT")]
		public const uint DEPTH_BUFFER_BIT = 256;

		[ScriptName("DEPTH_CLEAR_VALUE")]
		public const uint DEPTH_CLEAR_VALUE = 2931;

		[ScriptName("DEPTH_COMPONENT")]
		public const uint DEPTH_COMPONENT = 6402;

		[ScriptName("DEPTH_COMPONENT16")]
		public const uint DEPTH_COMPONENT16 = 33189;

		[ScriptName("DEPTH_FUNC")]
		public const uint DEPTH_FUNC = 2932;

		[ScriptName("DEPTH_RANGE")]
		public const uint DEPTH_RANGE = 2928;

		[ScriptName("DEPTH_STENCIL")]
		public const uint DEPTH_STENCIL = 34041;

		[ScriptName("DEPTH_STENCIL_ATTACHMENT")]
		public const uint DEPTH_STENCIL_ATTACHMENT = 33306;

		[ScriptName("DEPTH_TEST")]
		public const uint DEPTH_TEST = 2929;

		[ScriptName("DEPTH_WRITEMASK")]
		public const uint DEPTH_WRITEMASK = 2930;

		public void DepthFunc(uint func) {
		}

		public void DepthMask(bool flag) {
		}

		public void DepthRange(float zNear, float zFar) {
		}

		public void DetachShader(WebGLProgram program, WebGLShader shader) {
		}

		public void Disable(uint cap) {
		}

		public void DisableVertexAttribArray(uint index) {
		}

		public const uint DITHER = 3024;

		[ScriptName("DONT_CARE")]
		public const uint DONT_CARE = 4352;

		public void DrawArrays(uint mode, int first, int count) {
		}

		public void DrawElements(uint mode, int count, uint type, long offset) {
		}

		[IntrinsicProperty]
		public int DrawingBufferHeight {
			get { return 0; }
		}

		[IntrinsicProperty]
		public int DrawingBufferWidth {
			get { return 0; }
		}

		[ScriptName("DST_ALPHA")]
		public const uint DST_ALPHA = 772;

		[ScriptName("DST_COLOR")]
		public const uint DST_COLOR = 774;

		[ScriptName("DYNAMIC_DRAW")]
		public const uint DYNAMIC_DRAW = 35048;

		[ScriptName("ELEMENT_ARRAY_BUFFER")]
		public const uint ELEMENT_ARRAY_BUFFER = 34963;

		[ScriptName("ELEMENT_ARRAY_BUFFER_BINDING")]
		public const uint ELEMENT_ARRAY_BUFFER_BINDING = 34965;

		public void Enable(uint cap) {
		}

		public void EnableVertexAttribArray(uint index) {
		}

		public const uint EQUAL = 514;

		public const uint FASTEST = 4353;

		public void Finish() {
		}

		public const uint FLOAT = 5126;

		[ScriptName("FLOAT_MAT2")]
		public const uint FLOAT_MAT2 = 35674;

		[ScriptName("FLOAT_MAT3")]
		public const uint FLOAT_MAT3 = 35675;

		[ScriptName("FLOAT_MAT4")]
		public const uint FLOAT_MAT4 = 35676;

		[ScriptName("FLOAT_VEC2")]
		public const uint FLOAT_VEC2 = 35664;

		[ScriptName("FLOAT_VEC3")]
		public const uint FLOAT_VEC3 = 35665;

		[ScriptName("FLOAT_VEC4")]
		public const uint FLOAT_VEC4 = 35666;

		public void Flush() {
		}

		[ScriptName("FRAGMENT_SHADER")]
		public const uint FRAGMENT_SHADER = 35632;

		public const uint FRAMEBUFFER = 36160;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 36049;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
		public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 36048;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 36051;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
		public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 36050;

		[ScriptName("FRAMEBUFFER_BINDING")]
		public const uint FRAMEBUFFER_BINDING = 36006;

		[ScriptName("FRAMEBUFFER_COMPLETE")]
		public const uint FRAMEBUFFER_COMPLETE = 36053;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
		public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 36054;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
		public const uint FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 36057;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
		public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 36055;

		[ScriptName("FRAMEBUFFER_UNSUPPORTED")]
		public const uint FRAMEBUFFER_UNSUPPORTED = 36061;

		public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, WebGLRenderbuffer renderbuffer) {
		}

		public void FramebufferTexture2D(uint target, uint attachment, uint textarget, WebGLTexture texture, int level) {
		}

		public const uint FRONT = 1028;

		[ScriptName("FRONT_AND_BACK")]
		public const uint FRONT_AND_BACK = 1032;

		[ScriptName("FRONT_FACE")]
		public const uint FRONT_FACE = 2886;

		public void FrontFace(uint mode) {
		}

		[ScriptName("FUNC_ADD")]
		public const uint FUNC_ADD = 32774;

		[ScriptName("FUNC_REVERSE_SUBTRACT")]
		public const uint FUNC_REVERSE_SUBTRACT = 32779;

		[ScriptName("FUNC_SUBTRACT")]
		public const uint FUNC_SUBTRACT = 32778;

		[ScriptName("GENERATE_MIPMAP_HINT")]
		public const uint GENERATE_MIPMAP_HINT = 33170;

		public void GenerateMipmap(uint target) {
		}

		public const uint GEQUAL = 518;

		public WebGLActiveInfo GetActiveAttrib(WebGLProgram program, uint index) {
			return default(WebGLActiveInfo);
		}

		public WebGLActiveInfo GetActiveUniform(WebGLProgram program, uint index) {
			return default(WebGLActiveInfo);
		}

		public WebGLShader[] GetAttachedShaders(WebGLProgram program) {
			return null;
		}

		public int GetAttribLocation(WebGLProgram program, string name) {
			return 0;
		}

		public object GetBufferParameter(uint target, uint pname) {
			return null;
		}

		public WebGLContextAttributes GetContextAttributes() {
			return default(WebGLContextAttributes);
		}

		public uint GetError() {
			return 0;
		}

		public object GetExtension(string name) {
			return null;
		}

		public object GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname) {
			return null;
		}

		public object GetParameter(uint pname) {
			return null;
		}

		public string GetProgramInfoLog(WebGLProgram program) {
			return null;
		}

		public object GetProgramParameter(WebGLProgram program, uint pname) {
			return null;
		}

		public object GetRenderbufferParameter(uint target, uint pname) {
			return null;
		}

		public string GetShaderInfoLog(WebGLShader shader) {
			return null;
		}

		public object GetShaderParameter(WebGLShader shader, uint pname) {
			return null;
		}

		public WebGLShaderPrecisionFormat GetShaderPrecisionFormat(uint shadertype, uint precisiontype) {
			return default(WebGLShaderPrecisionFormat);
		}

		public string GetShaderSource(WebGLShader shader) {
			return null;
		}

		public string[] GetSupportedExtensions() {
			return null;
		}

		public object GetTexParameter(uint target, uint pname) {
			return null;
		}

		public object GetUniform(WebGLProgram program, WebGLUniformLocation location) {
			return null;
		}

		public WebGLUniformLocation GetUniformLocation(WebGLProgram program, string name) {
			return default(WebGLUniformLocation);
		}

		public object GetVertexAttrib(uint index, uint pname) {
			return null;
		}

		public long GetVertexAttribOffset(uint index, uint pname) {
			return 0;
		}

		public const uint GREATER = 516;

		[ScriptName("GREEN_BITS")]
		public const uint GREEN_BITS = 3411;

		[ScriptName("HIGH_FLOAT")]
		public const uint HIGH_FLOAT = 36338;

		[ScriptName("HIGH_INT")]
		public const uint HIGH_INT = 36341;

		public void Hint(uint target, uint mode) {
		}

		public const uint INCR = 7682;

		[ScriptName("INCR_WRAP")]
		public const uint INCR_WRAP = 34055;

		public const uint INT = 5124;

		[ScriptName("INT_VEC2")]
		public const uint INT_VEC2 = 35667;

		[ScriptName("INT_VEC3")]
		public const uint INT_VEC3 = 35668;

		[ScriptName("INT_VEC4")]
		public const uint INT_VEC4 = 35669;

		[ScriptName("INVALID_ENUM")]
		public const uint INVALID_ENUM = 1280;

		[ScriptName("INVALID_FRAMEBUFFER_OPERATION")]
		public const uint INVALID_FRAMEBUFFER_OPERATION = 1286;

		[ScriptName("INVALID_OPERATION")]
		public const uint INVALID_OPERATION = 1282;

		[ScriptName("INVALID_VALUE")]
		public const uint INVALID_VALUE = 1281;

		public const uint INVERT = 5386;

		public bool IsBuffer(WebGLBuffer buffer) {
			return false;
		}

		public bool IsContextLost() {
			return false;
		}

		public bool IsEnabled(uint cap) {
			return false;
		}

		public bool IsFramebuffer(WebGLFramebuffer framebuffer) {
			return false;
		}

		public bool IsProgram(WebGLProgram program) {
			return false;
		}

		public bool IsRenderbuffer(WebGLRenderbuffer renderbuffer) {
			return false;
		}

		public bool IsShader(WebGLShader shader) {
			return false;
		}

		public bool IsTexture(WebGLTexture texture) {
			return false;
		}

		public const uint KEEP = 7680;

		public const uint LEQUAL = 515;

		public const uint LESS = 513;

		[ScriptName("LINE_LOOP")]
		public const uint LINE_LOOP = 2;

		[ScriptName("LINE_STRIP")]
		public const uint LINE_STRIP = 3;

		[ScriptName("LINE_WIDTH")]
		public const uint LINE_WIDTH = 2849;

		public const uint LINEAR = 9729;

		[ScriptName("LINEAR_MIPMAP_LINEAR")]
		public const uint LINEAR_MIPMAP_LINEAR = 9987;

		[ScriptName("LINEAR_MIPMAP_NEAREST")]
		public const uint LINEAR_MIPMAP_NEAREST = 9985;

		public const uint LINES = 1;

		public void LineWidth(float width) {
		}

		[ScriptName("LINK_STATUS")]
		public const uint LINK_STATUS = 35714;

		public void LinkProgram(WebGLProgram program) {
		}

		[ScriptName("LOW_FLOAT")]
		public const uint LOW_FLOAT = 36336;

		[ScriptName("LOW_INT")]
		public const uint LOW_INT = 36339;

		public const uint LUMINANCE = 6409;

		[ScriptName("LUMINANCE_ALPHA")]
		public const uint LUMINANCE_ALPHA = 6410;

		[ScriptName("MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
		public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;

		[ScriptName("MAX_CUBE_MAP_TEXTURE_SIZE")]
		public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 34076;

		[ScriptName("MAX_FRAGMENT_UNIFORM_VECTORS")]
		public const uint MAX_FRAGMENT_UNIFORM_VECTORS = 36349;

		[ScriptName("MAX_RENDERBUFFER_SIZE")]
		public const uint MAX_RENDERBUFFER_SIZE = 34024;

		[ScriptName("MAX_TEXTURE_IMAGE_UNITS")]
		public const uint MAX_TEXTURE_IMAGE_UNITS = 34930;

		[ScriptName("MAX_TEXTURE_SIZE")]
		public const uint MAX_TEXTURE_SIZE = 3379;

		[ScriptName("MAX_VARYING_VECTORS")]
		public const uint MAX_VARYING_VECTORS = 36348;

		[ScriptName("MAX_VERTEX_ATTRIBS")]
		public const uint MAX_VERTEX_ATTRIBS = 34921;

		[ScriptName("MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
		public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;

		[ScriptName("MAX_VERTEX_UNIFORM_VECTORS")]
		public const uint MAX_VERTEX_UNIFORM_VECTORS = 36347;

		[ScriptName("MAX_VIEWPORT_DIMS")]
		public const uint MAX_VIEWPORT_DIMS = 3386;

		[ScriptName("MEDIUM_FLOAT")]
		public const uint MEDIUM_FLOAT = 36337;

		[ScriptName("MEDIUM_INT")]
		public const uint MEDIUM_INT = 36340;

		[ScriptName("MIRRORED_REPEAT")]
		public const uint MIRRORED_REPEAT = 33648;

		public const uint NEAREST = 9728;

		[ScriptName("NEAREST_MIPMAP_LINEAR")]
		public const uint NEAREST_MIPMAP_LINEAR = 9986;

		[ScriptName("NEAREST_MIPMAP_NEAREST")]
		public const uint NEAREST_MIPMAP_NEAREST = 9984;

		public const uint NEVER = 512;

		public const uint NICEST = 4354;

		[ScriptName("NO_ERROR")]
		public const uint NO_ERROR = 0;

		public const uint NONE = 0;

		public const uint NOTEQUAL = 517;

		public const uint ONE = 1;

		[ScriptName("ONE_MINUS_CONSTANT_ALPHA")]
		public const uint ONE_MINUS_CONSTANT_ALPHA = 32772;

		[ScriptName("ONE_MINUS_CONSTANT_COLOR")]
		public const uint ONE_MINUS_CONSTANT_COLOR = 32770;

		[ScriptName("ONE_MINUS_DST_ALPHA")]
		public const uint ONE_MINUS_DST_ALPHA = 773;

		[ScriptName("ONE_MINUS_DST_COLOR")]
		public const uint ONE_MINUS_DST_COLOR = 775;

		[ScriptName("ONE_MINUS_SRC_ALPHA")]
		public const uint ONE_MINUS_SRC_ALPHA = 771;

		[ScriptName("ONE_MINUS_SRC_COLOR")]
		public const uint ONE_MINUS_SRC_COLOR = 769;

		[ScriptName("OUT_OF_MEMORY")]
		public const uint OUT_OF_MEMORY = 1285;

		[ScriptName("PACK_ALIGNMENT")]
		public const uint PACK_ALIGNMENT = 3333;

		public void PixelStorei(uint pname, int param) {
		}

		public const uint POINTS = 0;

		[ScriptName("POLYGON_OFFSET_FACTOR")]
		public const uint POLYGON_OFFSET_FACTOR = 32824;

		[ScriptName("POLYGON_OFFSET_FILL")]
		public const uint POLYGON_OFFSET_FILL = 32823;

		[ScriptName("POLYGON_OFFSET_UNITS")]
		public const uint POLYGON_OFFSET_UNITS = 10752;

		public void PolygonOffset(float factor, float units) {
		}

		public void ReadPixels(int x, int y, int width, int height, uint format, uint type, ArrayBufferView pixels) {
		}

		[ScriptName("RED_BITS")]
		public const uint RED_BITS = 3410;

		public const uint RENDERBUFFER = 36161;

		[ScriptName("RENDERBUFFER_ALPHA_SIZE")]
		public const uint RENDERBUFFER_ALPHA_SIZE = 36179;

		[ScriptName("RENDERBUFFER_BINDING")]
		public const uint RENDERBUFFER_BINDING = 36007;

		[ScriptName("RENDERBUFFER_BLUE_SIZE")]
		public const uint RENDERBUFFER_BLUE_SIZE = 36178;

		[ScriptName("RENDERBUFFER_DEPTH_SIZE")]
		public const uint RENDERBUFFER_DEPTH_SIZE = 36180;

		[ScriptName("RENDERBUFFER_GREEN_SIZE")]
		public const uint RENDERBUFFER_GREEN_SIZE = 36177;

		[ScriptName("RENDERBUFFER_HEIGHT")]
		public const uint RENDERBUFFER_HEIGHT = 36163;

		[ScriptName("RENDERBUFFER_INTERNAL_FORMAT")]
		public const uint RENDERBUFFER_INTERNAL_FORMAT = 36164;

		[ScriptName("RENDERBUFFER_RED_SIZE")]
		public const uint RENDERBUFFER_RED_SIZE = 36176;

		[ScriptName("RENDERBUFFER_STENCIL_SIZE")]
		public const uint RENDERBUFFER_STENCIL_SIZE = 36181;

		[ScriptName("RENDERBUFFER_WIDTH")]
		public const uint RENDERBUFFER_WIDTH = 36162;

		public void RenderbufferStorage(uint target, uint internalformat, int width, int height) {
		}

		public const uint RENDERER = 7937;

		public const uint REPEAT = 10497;

		public const uint REPLACE = 7681;

		public const uint RGB = 6407;

		[ScriptName("RGB5_A1")]
		public const uint RGB5_A1 = 32855;

		[ScriptName("RGB565")]
		public const uint RGB565 = 36194;

		public const uint RGBA = 6408;

		[ScriptName("RGBA4")]
		public const uint RGBA4 = 32854;

		[ScriptName("SAMPLE_ALPHA_TO_COVERAGE")]
		public const uint SAMPLE_ALPHA_TO_COVERAGE = 32926;

		[ScriptName("SAMPLE_BUFFERS")]
		public const uint SAMPLE_BUFFERS = 32936;

		[ScriptName("SAMPLE_COVERAGE")]
		public const uint SAMPLE_COVERAGE = 32928;

		[ScriptName("SAMPLE_COVERAGE_INVERT")]
		public const uint SAMPLE_COVERAGE_INVERT = 32939;

		[ScriptName("SAMPLE_COVERAGE_VALUE")]
		public const uint SAMPLE_COVERAGE_VALUE = 32938;

		public void SampleCoverage(float value, bool invert) {
		}

		[ScriptName("SAMPLER_2D")]
		public const uint SAMPLER_2D = 35678;

		[ScriptName("SAMPLER_CUBE")]
		public const uint SAMPLER_CUBE = 35680;

		public const uint SAMPLES = 32937;

		public void Scissor(int x, int y, int width, int height) {
		}

		[ScriptName("SCISSOR_BOX")]
		public const uint SCISSOR_BOX = 3088;

		[ScriptName("SCISSOR_TEST")]
		public const uint SCISSOR_TEST = 3089;

		[ScriptName("SHADER_TYPE")]
		public const uint SHADER_TYPE = 35663;

		public void ShaderSource(WebGLShader shader, string source) {
		}

		[ScriptName("SHADING_LANGUAGE_VERSION")]
		public const uint SHADING_LANGUAGE_VERSION = 35724;

		public const uint SHORT = 5122;

		[ScriptName("SRC_ALPHA")]
		public const uint SRC_ALPHA = 770;

		[ScriptName("SRC_ALPHA_SATURATE")]
		public const uint SRC_ALPHA_SATURATE = 776;

		[ScriptName("SRC_COLOR")]
		public const uint SRC_COLOR = 768;

		[ScriptName("STATIC_DRAW")]
		public const uint STATIC_DRAW = 35044;

		[ScriptName("STENCIL_ATTACHMENT")]
		public const uint STENCIL_ATTACHMENT = 36128;

		[ScriptName("STENCIL_BACK_FAIL")]
		public const uint STENCIL_BACK_FAIL = 34817;

		[ScriptName("STENCIL_BACK_FUNC")]
		public const uint STENCIL_BACK_FUNC = 34816;

		[ScriptName("STENCIL_BACK_PASS_DEPTH_FAIL")]
		public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 34818;

		[ScriptName("STENCIL_BACK_PASS_DEPTH_PASS")]
		public const uint STENCIL_BACK_PASS_DEPTH_PASS = 34819;

		[ScriptName("STENCIL_BACK_REF")]
		public const uint STENCIL_BACK_REF = 36003;

		[ScriptName("STENCIL_BACK_VALUE_MASK")]
		public const uint STENCIL_BACK_VALUE_MASK = 36004;

		[ScriptName("STENCIL_BACK_WRITEMASK")]
		public const uint STENCIL_BACK_WRITEMASK = 36005;

		[ScriptName("STENCIL_BITS")]
		public const uint STENCIL_BITS = 3415;

		[ScriptName("STENCIL_BUFFER_BIT")]
		public const uint STENCIL_BUFFER_BIT = 1024;

		[ScriptName("STENCIL_CLEAR_VALUE")]
		public const uint STENCIL_CLEAR_VALUE = 2961;

		[ScriptName("STENCIL_FAIL")]
		public const uint STENCIL_FAIL = 2964;

		[ScriptName("STENCIL_FUNC")]
		public const uint STENCIL_FUNC = 2962;

		[ScriptName("STENCIL_INDEX")]
		public const uint STENCIL_INDEX = 6401;

		[ScriptName("STENCIL_INDEX8")]
		public const uint STENCIL_INDEX8 = 36168;

		[ScriptName("STENCIL_PASS_DEPTH_FAIL")]
		public const uint STENCIL_PASS_DEPTH_FAIL = 2965;

		[ScriptName("STENCIL_PASS_DEPTH_PASS")]
		public const uint STENCIL_PASS_DEPTH_PASS = 2966;

		[ScriptName("STENCIL_REF")]
		public const uint STENCIL_REF = 2967;

		[ScriptName("STENCIL_TEST")]
		public const uint STENCIL_TEST = 2960;

		[ScriptName("STENCIL_VALUE_MASK")]
		public const uint STENCIL_VALUE_MASK = 2963;

		[ScriptName("STENCIL_WRITEMASK")]
		public const uint STENCIL_WRITEMASK = 2968;

		public void StencilFunc(uint func, int @ref, uint mask) {
		}

		public void StencilFuncSeparate(uint face, uint func, int @ref, uint mask) {
		}

		public void StencilMask(uint mask) {
		}

		public void StencilMaskSeparate(uint face, uint mask) {
		}

		public void StencilOp(uint fail, uint zfail, uint zpass) {
		}

		public void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass) {
		}

		[ScriptName("STREAM_DRAW")]
		public const uint STREAM_DRAW = 35040;

		[ScriptName("SUBPIXEL_BITS")]
		public const uint SUBPIXEL_BITS = 3408;

		public void TexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, ArrayBufferView pixels) {
		}

		public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, CanvasElement canvas) {
		}

		public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, ImageData pixels) {
		}

		public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, ImageElement image) {
		}

		public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, VideoElement video) {
		}

		public void TexParameterf(uint target, uint pname, float param) {
		}

		public void TexParameteri(uint target, uint pname, int param) {
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, ArrayBufferView pixels) {
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, CanvasElement canvas) {
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, ImageData pixels) {
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, ImageElement image) {
		}

		public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, VideoElement video) {
		}

		public const uint TEXTURE = 5890;

		[ScriptName("TEXTURE_2D")]
		public const uint TEXTURE_2D = 3553;

		[ScriptName("TEXTURE_BINDING_2D")]
		public const uint TEXTURE_BINDING_2D = 32873;

		[ScriptName("TEXTURE_BINDING_CUBE_MAP")]
		public const uint TEXTURE_BINDING_CUBE_MAP = 34068;

		[ScriptName("TEXTURE_CUBE_MAP")]
		public const uint TEXTURE_CUBE_MAP = 34067;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_X")]
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_Y")]
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_Z")]
		public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_X")]
		public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 34069;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_Y")]
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_Z")]
		public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;

		[ScriptName("TEXTURE_MAG_FILTER")]
		public const uint TEXTURE_MAG_FILTER = 10240;

		[ScriptName("TEXTURE_MIN_FILTER")]
		public const uint TEXTURE_MIN_FILTER = 10241;

		[ScriptName("TEXTURE_WRAP_S")]
		public const uint TEXTURE_WRAP_S = 10242;

		[ScriptName("TEXTURE_WRAP_T")]
		public const uint TEXTURE_WRAP_T = 10243;

		[ScriptName("TEXTURE0")]
		public const uint TEXTURE0 = 33984;

		[ScriptName("TEXTURE1")]
		public const uint TEXTURE1 = 33985;

		[ScriptName("TEXTURE10")]
		public const uint TEXTURE10 = 33994;

		[ScriptName("TEXTURE11")]
		public const uint TEXTURE11 = 33995;

		[ScriptName("TEXTURE12")]
		public const uint TEXTURE12 = 33996;

		[ScriptName("TEXTURE13")]
		public const uint TEXTURE13 = 33997;

		[ScriptName("TEXTURE14")]
		public const uint TEXTURE14 = 33998;

		[ScriptName("TEXTURE15")]
		public const uint TEXTURE15 = 33999;

		[ScriptName("TEXTURE16")]
		public const uint TEXTURE16 = 34000;

		[ScriptName("TEXTURE17")]
		public const uint TEXTURE17 = 34001;

		[ScriptName("TEXTURE18")]
		public const uint TEXTURE18 = 34002;

		[ScriptName("TEXTURE19")]
		public const uint TEXTURE19 = 34003;

		[ScriptName("TEXTURE2")]
		public const uint TEXTURE2 = 33986;

		[ScriptName("TEXTURE20")]
		public const uint TEXTURE20 = 34004;

		[ScriptName("TEXTURE21")]
		public const uint TEXTURE21 = 34005;

		[ScriptName("TEXTURE22")]
		public const uint TEXTURE22 = 34006;

		[ScriptName("TEXTURE23")]
		public const uint TEXTURE23 = 34007;

		[ScriptName("TEXTURE24")]
		public const uint TEXTURE24 = 34008;

		[ScriptName("TEXTURE25")]
		public const uint TEXTURE25 = 34009;

		[ScriptName("TEXTURE26")]
		public const uint TEXTURE26 = 34010;

		[ScriptName("TEXTURE27")]
		public const uint TEXTURE27 = 34011;

		[ScriptName("TEXTURE28")]
		public const uint TEXTURE28 = 34012;

		[ScriptName("TEXTURE29")]
		public const uint TEXTURE29 = 34013;

		[ScriptName("TEXTURE3")]
		public const uint TEXTURE3 = 33987;

		[ScriptName("TEXTURE30")]
		public const uint TEXTURE30 = 34014;

		[ScriptName("TEXTURE31")]
		public const uint TEXTURE31 = 34015;

		[ScriptName("TEXTURE4")]
		public const uint TEXTURE4 = 33988;

		[ScriptName("TEXTURE5")]
		public const uint TEXTURE5 = 33989;

		[ScriptName("TEXTURE6")]
		public const uint TEXTURE6 = 33990;

		[ScriptName("TEXTURE7")]
		public const uint TEXTURE7 = 33991;

		[ScriptName("TEXTURE8")]
		public const uint TEXTURE8 = 33992;

		[ScriptName("TEXTURE9")]
		public const uint TEXTURE9 = 33993;

		[ScriptName("TRIANGLE_FAN")]
		public const uint TRIANGLE_FAN = 6;

		[ScriptName("TRIANGLE_STRIP")]
		public const uint TRIANGLE_STRIP = 5;

		public const uint TRIANGLES = 4;

		public void Uniform1f(WebGLUniformLocation location, float x) {
		}

		public void Uniform1fv(WebGLUniformLocation location, float[] v) {
		}

		public void Uniform1fv(WebGLUniformLocation location, Float32Array v) {
		}

		public void Uniform1i(WebGLUniformLocation location, int x) {
		}

		public void Uniform1iv(WebGLUniformLocation location, int[] v) {
		}

		public void Uniform1iv(WebGLUniformLocation location, Int32Array v) {
		}

		public void Uniform2f(WebGLUniformLocation location, float x, float y) {
		}

		public void Uniform2fv(WebGLUniformLocation location, float[] v) {
		}

		public void Uniform2fv(WebGLUniformLocation location, Float32Array v) {
		}

		public void Uniform2i(WebGLUniformLocation location, int x, int y) {
		}

		public void Uniform2iv(WebGLUniformLocation location, int[] v) {
		}

		public void Uniform2iv(WebGLUniformLocation location, Int32Array v) {
		}

		public void Uniform3f(WebGLUniformLocation location, float x, float y, float z) {
		}

		public void Uniform3fv(WebGLUniformLocation location, float[] v) {
		}

		public void Uniform3fv(WebGLUniformLocation location, Float32Array v) {
		}

		public void Uniform3i(WebGLUniformLocation location, int x, int y, int z) {
		}

		public void Uniform3iv(WebGLUniformLocation location, int[] v) {
		}

		public void Uniform3iv(WebGLUniformLocation location, Int32Array v) {
		}

		public void Uniform4f(WebGLUniformLocation location, float x, float y, float z, float w) {
		}

		public void Uniform4fv(WebGLUniformLocation location, float[] v) {
		}

		public void Uniform4fv(WebGLUniformLocation location, Float32Array v) {
		}

		public void Uniform4i(WebGLUniformLocation location, int x, int y, int z, int w) {
		}

		public void Uniform4iv(WebGLUniformLocation location, int[] v) {
		}

		public void Uniform4iv(WebGLUniformLocation location, Int32Array v) {
		}

		public void UniformMatrix2fv(WebGLUniformLocation location, bool transpose, float[] value) {
		}

		public void UniformMatrix2fv(WebGLUniformLocation location, bool transpose, Float32Array value) {
		}

		public void UniformMatrix3fv(WebGLUniformLocation location, bool transpose, float[] value) {
		}

		public void UniformMatrix3fv(WebGLUniformLocation location, bool transpose, Float32Array value) {
		}

		public void UniformMatrix4fv(WebGLUniformLocation location, bool transpose, float[] value) {
		}

		public void UniformMatrix4fv(WebGLUniformLocation location, bool transpose, Float32Array value) {
		}

		[ScriptName("UNPACK_ALIGNMENT")]
		public const uint UNPACK_ALIGNMENT = 3317;

		[ScriptName("UNPACK_COLORSPACE_CONVERSION_WEBGL")]
		public const uint UNPACK_COLORSPACE_CONVERSION_WEBGL = 37443;

		[ScriptName("UNPACK_FLIP_Y_WEBGL")]
		public const uint UNPACK_FLIP_Y_WEBGL = 37440;

		[ScriptName("UNPACK_PREMULTIPLY_ALPHA_WEBGL")]
		public const uint UNPACK_PREMULTIPLY_ALPHA_WEBGL = 37441;

		[ScriptName("UNSIGNED_BYTE")]
		public const uint UNSIGNED_BYTE = 5121;

		[ScriptName("UNSIGNED_INT")]
		public const uint UNSIGNED_INT = 5125;

		[ScriptName("UNSIGNED_SHORT")]
		public const uint UNSIGNED_SHORT = 5123;

		[ScriptName("UNSIGNED_SHORT_4_4_4_4")]
		public const uint UNSIGNED_SHORT_4_4_4_4 = 32819;

		[ScriptName("UNSIGNED_SHORT_5_5_5_1")]
		public const uint UNSIGNED_SHORT_5_5_5_1 = 32820;

		[ScriptName("UNSIGNED_SHORT_5_6_5")]
		public const uint UNSIGNED_SHORT_5_6_5 = 33635;

		public void UseProgram(WebGLProgram program) {
		}

		[ScriptName("VALIDATE_STATUS")]
		public const uint VALIDATE_STATUS = 35715;

		public void ValidateProgram(WebGLProgram program) {
		}

		public const uint VENDOR = 7936;

		public const uint VERSION = 7938;

		[ScriptName("VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
		public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;

		[ScriptName("VERTEX_ATTRIB_ARRAY_ENABLED")]
		public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 34338;

		[ScriptName("VERTEX_ATTRIB_ARRAY_NORMALIZED")]
		public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;

		[ScriptName("VERTEX_ATTRIB_ARRAY_POINTER")]
		public const uint VERTEX_ATTRIB_ARRAY_POINTER = 34373;

		[ScriptName("VERTEX_ATTRIB_ARRAY_SIZE")]
		public const uint VERTEX_ATTRIB_ARRAY_SIZE = 34339;

		[ScriptName("VERTEX_ATTRIB_ARRAY_STRIDE")]
		public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 34340;

		[ScriptName("VERTEX_ATTRIB_ARRAY_TYPE")]
		public const uint VERTEX_ATTRIB_ARRAY_TYPE = 34341;

		[ScriptName("VERTEX_SHADER")]
		public const uint VERTEX_SHADER = 35633;

		public void VertexAttrib1f(uint indx, float x) {
		}

		public void VertexAttrib1fv(uint indx, float[] values) {
		}

		public void VertexAttrib1fv(uint indx, Float32Array values) {
		}

		public void VertexAttrib2f(uint indx, float x, float y) {
		}

		public void VertexAttrib2fv(uint indx, float[] values) {
		}

		public void VertexAttrib2fv(uint indx, Float32Array values) {
		}

		public void VertexAttrib3f(uint indx, float x, float y, float z) {
		}

		public void VertexAttrib3fv(uint indx, float[] values) {
		}

		public void VertexAttrib3fv(uint indx, Float32Array values) {
		}

		public void VertexAttrib4f(uint indx, float x, float y, float z, float w) {
		}

		public void VertexAttrib4fv(uint indx, float[] values) {
		}

		public void VertexAttrib4fv(uint indx, Float32Array values) {
		}

		public void VertexAttribPointer(uint indx, int size, uint type, bool normalized, int stride, long offset) {
		}

		public void Viewport(int x, int y, int width, int height) {
		}

		public const uint VIEWPORT = 2978;

		public const uint ZERO = 0;
	}
}
