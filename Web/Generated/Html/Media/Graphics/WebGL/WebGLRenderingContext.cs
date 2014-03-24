using System.Collections.TypedArrays;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.WebGL {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebGLRenderingContext {
		internal WebGLRenderingContext() {
		}

		[ScriptName("ACTIVE_ATTRIBUTES")]
		public const int ACTIVE_ATTRIBUTES = 35721;

		[ScriptName("ACTIVE_TEXTURE")]
		public const int ACTIVE_TEXTURE = 34016;

		[ScriptName("ACTIVE_UNIFORMS")]
		public const int ACTIVE_UNIFORMS = 35718;

		public void ActiveTexture(int texture) {
		}

		[ScriptName("ALIASED_LINE_WIDTH_RANGE")]
		public const int ALIASED_LINE_WIDTH_RANGE = 33902;

		[ScriptName("ALIASED_POINT_SIZE_RANGE")]
		public const int ALIASED_POINT_SIZE_RANGE = 33901;

		public const int ALPHA = 6406;

		[ScriptName("ALPHA_BITS")]
		public const int ALPHA_BITS = 3413;

		public const int ALWAYS = 519;

		[ScriptName("ARRAY_BUFFER")]
		public const int ARRAY_BUFFER = 34962;

		[ScriptName("ARRAY_BUFFER_BINDING")]
		public const int ARRAY_BUFFER_BINDING = 34964;

		[ScriptName("ATTACHED_SHADERS")]
		public const int ATTACHED_SHADERS = 35717;

		public void AttachShader(WebGLProgram program, WebGLShader shader) {
		}

		public const int BACK = 1029;

		public void BindAttribLocation(WebGLProgram program, int index, string name) {
		}

		public void BindBuffer(int target, WebGLBuffer buffer) {
		}

		public void BindFramebuffer(int target, WebGLFramebuffer framebuffer) {
		}

		public void BindRenderbuffer(int target, WebGLRenderbuffer renderbuffer) {
		}

		public void BindTexture(int target, WebGLTexture texture) {
		}

		public const int BLEND = 3042;

		[ScriptName("BLEND_COLOR")]
		public const int BLEND_COLOR = 32773;

		[ScriptName("BLEND_DST_ALPHA")]
		public const int BLEND_DST_ALPHA = 32970;

		[ScriptName("BLEND_DST_RGB")]
		public const int BLEND_DST_RGB = 32968;

		[ScriptName("BLEND_EQUATION")]
		public const int BLEND_EQUATION = 32777;

		[ScriptName("BLEND_EQUATION_ALPHA")]
		public const int BLEND_EQUATION_ALPHA = 34877;

		[ScriptName("BLEND_EQUATION_RGB")]
		public const int BLEND_EQUATION_RGB = 32777;

		[ScriptName("BLEND_SRC_ALPHA")]
		public const int BLEND_SRC_ALPHA = 32971;

		[ScriptName("BLEND_SRC_RGB")]
		public const int BLEND_SRC_RGB = 32969;

		public void BlendColor(float red, float green, float blue, float alpha) {
		}

		public void BlendEquation(int mode) {
		}

		public void BlendEquationSeparate(int modeRGB, int modeAlpha) {
		}

		public void BlendFunc(int sfactor, int dfactor) {
		}

		public void BlendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha) {
		}

		[ScriptName("BLUE_BITS")]
		public const int BLUE_BITS = 3412;

		public const int BOOL = 35670;

		[ScriptName("BOOL_VEC2")]
		public const int BOOL_VEC2 = 35671;

		[ScriptName("BOOL_VEC3")]
		public const int BOOL_VEC3 = 35672;

		[ScriptName("BOOL_VEC4")]
		public const int BOOL_VEC4 = 35673;

		[ScriptName("BROWSER_DEFAULT_WEBGL")]
		public const int BROWSER_DEFAULT_WEBGL = 37444;

		[ScriptName("BUFFER_SIZE")]
		public const int BUFFER_SIZE = 34660;

		[ScriptName("BUFFER_USAGE")]
		public const int BUFFER_USAGE = 34661;

		public void BufferData(int target, ArrayBuffer data, int usage) {
		}

		public void BufferData(int target, ArrayBufferView data, int usage) {
		}

		public void BufferData(int target, long size, int usage) {
		}

		public void BufferSubData(int target, long offset, ArrayBuffer data) {
		}

		public void BufferSubData(int target, long offset, ArrayBufferView data) {
		}

		public const int BYTE = 5120;

		[IntrinsicProperty]
		public CanvasElement Canvas {
			get {
				return default(CanvasElement);
			}
		}

		public const int CCW = 2305;

		public int CheckFramebufferStatus(int target) {
			return 0;
		}

		[ScriptName("CLAMP_TO_EDGE")]
		public const int CLAMP_TO_EDGE = 33071;

		public void Clear(int mask) {
		}

		public void ClearColor(float red, float green, float blue, float alpha) {
		}

		public void ClearDepth(float depth) {
		}

		public void ClearStencil(int s) {
		}

		[ScriptName("COLOR_ATTACHMENT0")]
		public const int COLOR_ATTACHMENT0 = 36064;

		[ScriptName("COLOR_BUFFER_BIT")]
		public const int COLOR_BUFFER_BIT = 16384;

		[ScriptName("COLOR_CLEAR_VALUE")]
		public const int COLOR_CLEAR_VALUE = 3106;

		[ScriptName("COLOR_WRITEMASK")]
		public const int COLOR_WRITEMASK = 3107;

		public void ColorMask(bool red, bool green, bool blue, bool alpha) {
		}

		[ScriptName("COMPILE_STATUS")]
		public const int COMPILE_STATUS = 35713;

		public void CompileShader(WebGLShader shader) {
		}

		[ScriptName("COMPRESSED_TEXTURE_FORMATS")]
		public const int COMPRESSED_TEXTURE_FORMATS = 34467;

		public void CompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, ArrayBufferView data) {
		}

		public void CompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, ArrayBufferView data) {
		}

		[ScriptName("CONSTANT_ALPHA")]
		public const int CONSTANT_ALPHA = 32771;

		[ScriptName("CONSTANT_COLOR")]
		public const int CONSTANT_COLOR = 32769;

		[ScriptName("CONTEXT_LOST_WEBGL")]
		public const int CONTEXT_LOST_WEBGL = 37442;

		public void CopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border) {
		}

		public void CopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
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

		public WebGLShader CreateShader(int type) {
			return default(WebGLShader);
		}

		public WebGLTexture CreateTexture() {
			return default(WebGLTexture);
		}

		[ScriptName("CULL_FACE")]
		public const int CULL_FACE = 2884;

		[ScriptName("CULL_FACE_MODE")]
		public const int CULL_FACE_MODE = 2885;

		public void CullFace(int mode) {
		}

		[ScriptName("CURRENT_PROGRAM")]
		public const int CURRENT_PROGRAM = 35725;

		[ScriptName("CURRENT_VERTEX_ATTRIB")]
		public const int CURRENT_VERTEX_ATTRIB = 34342;

		public const int CW = 2304;

		public const int DECR = 7683;

		[ScriptName("DECR_WRAP")]
		public const int DECR_WRAP = 34056;

		[ScriptName("DELETE_STATUS")]
		public const int DELETE_STATUS = 35712;

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
		public const int DEPTH_ATTACHMENT = 36096;

		[ScriptName("DEPTH_BITS")]
		public const int DEPTH_BITS = 3414;

		[ScriptName("DEPTH_BUFFER_BIT")]
		public const int DEPTH_BUFFER_BIT = 256;

		[ScriptName("DEPTH_CLEAR_VALUE")]
		public const int DEPTH_CLEAR_VALUE = 2931;

		[ScriptName("DEPTH_COMPONENT")]
		public const int DEPTH_COMPONENT = 6402;

		[ScriptName("DEPTH_COMPONENT16")]
		public const int DEPTH_COMPONENT16 = 33189;

		[ScriptName("DEPTH_FUNC")]
		public const int DEPTH_FUNC = 2932;

		[ScriptName("DEPTH_RANGE")]
		public const int DEPTH_RANGE = 2928;

		[ScriptName("DEPTH_STENCIL")]
		public const int DEPTH_STENCIL = 34041;

		[ScriptName("DEPTH_STENCIL_ATTACHMENT")]
		public const int DEPTH_STENCIL_ATTACHMENT = 33306;

		[ScriptName("DEPTH_TEST")]
		public const int DEPTH_TEST = 2929;

		[ScriptName("DEPTH_WRITEMASK")]
		public const int DEPTH_WRITEMASK = 2930;

		public void DepthFunc(int func) {
		}

		public void DepthMask(bool flag) {
		}

		public void DepthRange(float zNear, float zFar) {
		}

		public void DetachShader(WebGLProgram program, WebGLShader shader) {
		}

		public void Disable(int cap) {
		}

		public void DisableVertexAttribArray(int index) {
		}

		public const int DITHER = 3024;

		[ScriptName("DONT_CARE")]
		public const int DONT_CARE = 4352;

		public void DrawArrays(int mode, int first, int count) {
		}

		public void DrawElements(int mode, int count, int type, long offset) {
		}

		[IntrinsicProperty]
		public int DrawingBufferHeight {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int DrawingBufferWidth {
			get {
				return 0;
			}
		}

		[ScriptName("DST_ALPHA")]
		public const int DST_ALPHA = 772;

		[ScriptName("DST_COLOR")]
		public const int DST_COLOR = 774;

		[ScriptName("DYNAMIC_DRAW")]
		public const int DYNAMIC_DRAW = 35048;

		[ScriptName("ELEMENT_ARRAY_BUFFER")]
		public const int ELEMENT_ARRAY_BUFFER = 34963;

		[ScriptName("ELEMENT_ARRAY_BUFFER_BINDING")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 34965;

		public void Enable(int cap) {
		}

		public void EnableVertexAttribArray(int index) {
		}

		public const int EQUAL = 514;

		public const int FASTEST = 4353;

		public void Finish() {
		}

		public const int FLOAT = 5126;

		[ScriptName("FLOAT_MAT2")]
		public const int FLOAT_MAT2 = 35674;

		[ScriptName("FLOAT_MAT3")]
		public const int FLOAT_MAT3 = 35675;

		[ScriptName("FLOAT_MAT4")]
		public const int FLOAT_MAT4 = 35676;

		[ScriptName("FLOAT_VEC2")]
		public const int FLOAT_VEC2 = 35664;

		[ScriptName("FLOAT_VEC3")]
		public const int FLOAT_VEC3 = 35665;

		[ScriptName("FLOAT_VEC4")]
		public const int FLOAT_VEC4 = 35666;

		public void Flush() {
		}

		[ScriptName("FRAGMENT_SHADER")]
		public const int FRAGMENT_SHADER = 35632;

		public const int FRAMEBUFFER = 36160;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 36049;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 36048;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 36051;

		[ScriptName("FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 36050;

		[ScriptName("FRAMEBUFFER_BINDING")]
		public const int FRAMEBUFFER_BINDING = 36006;

		[ScriptName("FRAMEBUFFER_COMPLETE")]
		public const int FRAMEBUFFER_COMPLETE = 36053;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 36054;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 36057;

		[ScriptName("FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 36055;

		[ScriptName("FRAMEBUFFER_UNSUPPORTED")]
		public const int FRAMEBUFFER_UNSUPPORTED = 36061;

		public void FramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, WebGLRenderbuffer renderbuffer) {
		}

		public void FramebufferTexture2D(int target, int attachment, int textarget, WebGLTexture texture, int level) {
		}

		public const int FRONT = 1028;

		[ScriptName("FRONT_AND_BACK")]
		public const int FRONT_AND_BACK = 1032;

		[ScriptName("FRONT_FACE")]
		public const int FRONT_FACE = 2886;

		public void FrontFace(int mode) {
		}

		[ScriptName("FUNC_ADD")]
		public const int FUNC_ADD = 32774;

		[ScriptName("FUNC_REVERSE_SUBTRACT")]
		public const int FUNC_REVERSE_SUBTRACT = 32779;

		[ScriptName("FUNC_SUBTRACT")]
		public const int FUNC_SUBTRACT = 32778;

		[ScriptName("GENERATE_MIPMAP_HINT")]
		public const int GENERATE_MIPMAP_HINT = 33170;

		public void GenerateMipmap(int target) {
		}

		public const int GEQUAL = 518;

		public WebGLActiveInfo GetActiveAttrib(WebGLProgram program, int index) {
			return default(WebGLActiveInfo);
		}

		public WebGLActiveInfo GetActiveUniform(WebGLProgram program, int index) {
			return default(WebGLActiveInfo);
		}

		public WebGLShader[] GetAttachedShaders(WebGLProgram program) {
			return null;
		}

		public int GetAttribLocation(WebGLProgram program, string name) {
			return 0;
		}

		public object GetBufferParameter(int target, int pname) {
			return null;
		}

		public WebGLContextAttributes GetContextAttributes() {
			return default(WebGLContextAttributes);
		}

		public int GetError() {
			return 0;
		}

		public object GetExtension(string name) {
			return null;
		}

		public object GetFramebufferAttachmentParameter(int target, int attachment, int pname) {
			return null;
		}

		public object GetParameter(int pname) {
			return null;
		}

		public string GetProgramInfoLog(WebGLProgram program) {
			return null;
		}

		public object GetProgramParameter(WebGLProgram program, int pname) {
			return null;
		}

		public object GetRenderbufferParameter(int target, int pname) {
			return null;
		}

		public string GetShaderInfoLog(WebGLShader shader) {
			return null;
		}

		public object GetShaderParameter(WebGLShader shader, int pname) {
			return null;
		}

		public WebGLShaderPrecisionFormat GetShaderPrecisionFormat(int shadertype, int precisiontype) {
			return default(WebGLShaderPrecisionFormat);
		}

		public string GetShaderSource(WebGLShader shader) {
			return null;
		}

		public string[] GetSupportedExtensions() {
			return null;
		}

		public object GetTexParameter(int target, int pname) {
			return null;
		}

		public object GetUniform(WebGLProgram program, WebGLUniformLocation location) {
			return null;
		}

		public WebGLUniformLocation GetUniformLocation(WebGLProgram program, string name) {
			return default(WebGLUniformLocation);
		}

		public object GetVertexAttrib(int index, int pname) {
			return null;
		}

		public long GetVertexAttribOffset(int index, int pname) {
			return 0;
		}

		public const int GREATER = 516;

		[ScriptName("GREEN_BITS")]
		public const int GREEN_BITS = 3411;

		[ScriptName("HIGH_FLOAT")]
		public const int HIGH_FLOAT = 36338;

		[ScriptName("HIGH_INT")]
		public const int HIGH_INT = 36341;

		public void Hint(int target, int mode) {
		}

		public const int INCR = 7682;

		[ScriptName("INCR_WRAP")]
		public const int INCR_WRAP = 34055;

		public const int INT = 5124;

		[ScriptName("INT_VEC2")]
		public const int INT_VEC2 = 35667;

		[ScriptName("INT_VEC3")]
		public const int INT_VEC3 = 35668;

		[ScriptName("INT_VEC4")]
		public const int INT_VEC4 = 35669;

		[ScriptName("INVALID_ENUM")]
		public const int INVALID_ENUM = 1280;

		[ScriptName("INVALID_FRAMEBUFFER_OPERATION")]
		public const int INVALID_FRAMEBUFFER_OPERATION = 1286;

		[ScriptName("INVALID_OPERATION")]
		public const int INVALID_OPERATION = 1282;

		[ScriptName("INVALID_VALUE")]
		public const int INVALID_VALUE = 1281;

		public const int INVERT = 5386;

		public bool IsBuffer(WebGLBuffer buffer) {
			return false;
		}

		public bool IsContextLost() {
			return false;
		}

		public bool IsEnabled(int cap) {
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

		public const int KEEP = 7680;

		public const int LEQUAL = 515;

		public const int LESS = 513;

		[ScriptName("LINE_LOOP")]
		public const int LINE_LOOP = 2;

		[ScriptName("LINE_STRIP")]
		public const int LINE_STRIP = 3;

		[ScriptName("LINE_WIDTH")]
		public const int LINE_WIDTH = 2849;

		public const int LINEAR = 9729;

		[ScriptName("LINEAR_MIPMAP_LINEAR")]
		public const int LINEAR_MIPMAP_LINEAR = 9987;

		[ScriptName("LINEAR_MIPMAP_NEAREST")]
		public const int LINEAR_MIPMAP_NEAREST = 9985;

		public const int LINES = 1;

		public void LineWidth(float width) {
		}

		[ScriptName("LINK_STATUS")]
		public const int LINK_STATUS = 35714;

		public void LinkProgram(WebGLProgram program) {
		}

		[ScriptName("LOW_FLOAT")]
		public const int LOW_FLOAT = 36336;

		[ScriptName("LOW_INT")]
		public const int LOW_INT = 36339;

		public const int LUMINANCE = 6409;

		[ScriptName("LUMINANCE_ALPHA")]
		public const int LUMINANCE_ALPHA = 6410;

		[ScriptName("MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;

		[ScriptName("MAX_CUBE_MAP_TEXTURE_SIZE")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE = 34076;

		[ScriptName("MAX_FRAGMENT_UNIFORM_VECTORS")]
		public const int MAX_FRAGMENT_UNIFORM_VECTORS = 36349;

		[ScriptName("MAX_RENDERBUFFER_SIZE")]
		public const int MAX_RENDERBUFFER_SIZE = 34024;

		[ScriptName("MAX_TEXTURE_IMAGE_UNITS")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 34930;

		[ScriptName("MAX_TEXTURE_SIZE")]
		public const int MAX_TEXTURE_SIZE = 3379;

		[ScriptName("MAX_VARYING_VECTORS")]
		public const int MAX_VARYING_VECTORS = 36348;

		[ScriptName("MAX_VERTEX_ATTRIBS")]
		public const int MAX_VERTEX_ATTRIBS = 34921;

		[ScriptName("MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;

		[ScriptName("MAX_VERTEX_UNIFORM_VECTORS")]
		public const int MAX_VERTEX_UNIFORM_VECTORS = 36347;

		[ScriptName("MAX_VIEWPORT_DIMS")]
		public const int MAX_VIEWPORT_DIMS = 3386;

		[ScriptName("MEDIUM_FLOAT")]
		public const int MEDIUM_FLOAT = 36337;

		[ScriptName("MEDIUM_INT")]
		public const int MEDIUM_INT = 36340;

		[ScriptName("MIRRORED_REPEAT")]
		public const int MIRRORED_REPEAT = 33648;

		public const int NEAREST = 9728;

		[ScriptName("NEAREST_MIPMAP_LINEAR")]
		public const int NEAREST_MIPMAP_LINEAR = 9986;

		[ScriptName("NEAREST_MIPMAP_NEAREST")]
		public const int NEAREST_MIPMAP_NEAREST = 9984;

		public const int NEVER = 512;

		public const int NICEST = 4354;

		[ScriptName("NO_ERROR")]
		public const int NO_ERROR = 0;

		public const int NONE = 0;

		public const int NOTEQUAL = 517;

		public const int ONE = 1;

		[ScriptName("ONE_MINUS_CONSTANT_ALPHA")]
		public const int ONE_MINUS_CONSTANT_ALPHA = 32772;

		[ScriptName("ONE_MINUS_CONSTANT_COLOR")]
		public const int ONE_MINUS_CONSTANT_COLOR = 32770;

		[ScriptName("ONE_MINUS_DST_ALPHA")]
		public const int ONE_MINUS_DST_ALPHA = 773;

		[ScriptName("ONE_MINUS_DST_COLOR")]
		public const int ONE_MINUS_DST_COLOR = 775;

		[ScriptName("ONE_MINUS_SRC_ALPHA")]
		public const int ONE_MINUS_SRC_ALPHA = 771;

		[ScriptName("ONE_MINUS_SRC_COLOR")]
		public const int ONE_MINUS_SRC_COLOR = 769;

		[ScriptName("OUT_OF_MEMORY")]
		public const int OUT_OF_MEMORY = 1285;

		[ScriptName("PACK_ALIGNMENT")]
		public const int PACK_ALIGNMENT = 3333;

		public void PixelStorei(int pname, int param) {
		}

		public const int POINTS = 0;

		[ScriptName("POLYGON_OFFSET_FACTOR")]
		public const int POLYGON_OFFSET_FACTOR = 32824;

		[ScriptName("POLYGON_OFFSET_FILL")]
		public const int POLYGON_OFFSET_FILL = 32823;

		[ScriptName("POLYGON_OFFSET_UNITS")]
		public const int POLYGON_OFFSET_UNITS = 10752;

		public void PolygonOffset(float factor, float units) {
		}

		public void ReadPixels(int x, int y, int width, int height, int format, int type, ArrayBufferView pixels) {
		}

		[ScriptName("RED_BITS")]
		public const int RED_BITS = 3410;

		public const int RENDERBUFFER = 36161;

		[ScriptName("RENDERBUFFER_ALPHA_SIZE")]
		public const int RENDERBUFFER_ALPHA_SIZE = 36179;

		[ScriptName("RENDERBUFFER_BINDING")]
		public const int RENDERBUFFER_BINDING = 36007;

		[ScriptName("RENDERBUFFER_BLUE_SIZE")]
		public const int RENDERBUFFER_BLUE_SIZE = 36178;

		[ScriptName("RENDERBUFFER_DEPTH_SIZE")]
		public const int RENDERBUFFER_DEPTH_SIZE = 36180;

		[ScriptName("RENDERBUFFER_GREEN_SIZE")]
		public const int RENDERBUFFER_GREEN_SIZE = 36177;

		[ScriptName("RENDERBUFFER_HEIGHT")]
		public const int RENDERBUFFER_HEIGHT = 36163;

		[ScriptName("RENDERBUFFER_INTERNAL_FORMAT")]
		public const int RENDERBUFFER_INTERNAL_FORMAT = 36164;

		[ScriptName("RENDERBUFFER_RED_SIZE")]
		public const int RENDERBUFFER_RED_SIZE = 36176;

		[ScriptName("RENDERBUFFER_STENCIL_SIZE")]
		public const int RENDERBUFFER_STENCIL_SIZE = 36181;

		[ScriptName("RENDERBUFFER_WIDTH")]
		public const int RENDERBUFFER_WIDTH = 36162;

		public void RenderbufferStorage(int target, int internalformat, int width, int height) {
		}

		public const int RENDERER = 7937;

		public const int REPEAT = 10497;

		public const int REPLACE = 7681;

		public const int RGB = 6407;

		[ScriptName("RGB5_A1")]
		public const int RGB5_A1 = 32855;

		[ScriptName("RGB565")]
		public const int RGB565 = 36194;

		public const int RGBA = 6408;

		[ScriptName("RGBA4")]
		public const int RGBA4 = 32854;

		[ScriptName("SAMPLE_ALPHA_TO_COVERAGE")]
		public const int SAMPLE_ALPHA_TO_COVERAGE = 32926;

		[ScriptName("SAMPLE_BUFFERS")]
		public const int SAMPLE_BUFFERS = 32936;

		[ScriptName("SAMPLE_COVERAGE")]
		public const int SAMPLE_COVERAGE = 32928;

		[ScriptName("SAMPLE_COVERAGE_INVERT")]
		public const int SAMPLE_COVERAGE_INVERT = 32939;

		[ScriptName("SAMPLE_COVERAGE_VALUE")]
		public const int SAMPLE_COVERAGE_VALUE = 32938;

		public void SampleCoverage(float value, bool invert) {
		}

		[ScriptName("SAMPLER_2D")]
		public const int SAMPLER_2D = 35678;

		[ScriptName("SAMPLER_CUBE")]
		public const int SAMPLER_CUBE = 35680;

		public const int SAMPLES = 32937;

		public void Scissor(int x, int y, int width, int height) {
		}

		[ScriptName("SCISSOR_BOX")]
		public const int SCISSOR_BOX = 3088;

		[ScriptName("SCISSOR_TEST")]
		public const int SCISSOR_TEST = 3089;

		[ScriptName("SHADER_TYPE")]
		public const int SHADER_TYPE = 35663;

		public void ShaderSource(WebGLShader shader, string source) {
		}

		[ScriptName("SHADING_LANGUAGE_VERSION")]
		public const int SHADING_LANGUAGE_VERSION = 35724;

		public const int SHORT = 5122;

		[ScriptName("SRC_ALPHA")]
		public const int SRC_ALPHA = 770;

		[ScriptName("SRC_ALPHA_SATURATE")]
		public const int SRC_ALPHA_SATURATE = 776;

		[ScriptName("SRC_COLOR")]
		public const int SRC_COLOR = 768;

		[ScriptName("STATIC_DRAW")]
		public const int STATIC_DRAW = 35044;

		[ScriptName("STENCIL_ATTACHMENT")]
		public const int STENCIL_ATTACHMENT = 36128;

		[ScriptName("STENCIL_BACK_FAIL")]
		public const int STENCIL_BACK_FAIL = 34817;

		[ScriptName("STENCIL_BACK_FUNC")]
		public const int STENCIL_BACK_FUNC = 34816;

		[ScriptName("STENCIL_BACK_PASS_DEPTH_FAIL")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 34818;

		[ScriptName("STENCIL_BACK_PASS_DEPTH_PASS")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 34819;

		[ScriptName("STENCIL_BACK_REF")]
		public const int STENCIL_BACK_REF = 36003;

		[ScriptName("STENCIL_BACK_VALUE_MASK")]
		public const int STENCIL_BACK_VALUE_MASK = 36004;

		[ScriptName("STENCIL_BACK_WRITEMASK")]
		public const int STENCIL_BACK_WRITEMASK = 36005;

		[ScriptName("STENCIL_BITS")]
		public const int STENCIL_BITS = 3415;

		[ScriptName("STENCIL_BUFFER_BIT")]
		public const int STENCIL_BUFFER_BIT = 1024;

		[ScriptName("STENCIL_CLEAR_VALUE")]
		public const int STENCIL_CLEAR_VALUE = 2961;

		[ScriptName("STENCIL_FAIL")]
		public const int STENCIL_FAIL = 2964;

		[ScriptName("STENCIL_FUNC")]
		public const int STENCIL_FUNC = 2962;

		[ScriptName("STENCIL_INDEX")]
		public const int STENCIL_INDEX = 6401;

		[ScriptName("STENCIL_INDEX8")]
		public const int STENCIL_INDEX8 = 36168;

		[ScriptName("STENCIL_PASS_DEPTH_FAIL")]
		public const int STENCIL_PASS_DEPTH_FAIL = 2965;

		[ScriptName("STENCIL_PASS_DEPTH_PASS")]
		public const int STENCIL_PASS_DEPTH_PASS = 2966;

		[ScriptName("STENCIL_REF")]
		public const int STENCIL_REF = 2967;

		[ScriptName("STENCIL_TEST")]
		public const int STENCIL_TEST = 2960;

		[ScriptName("STENCIL_VALUE_MASK")]
		public const int STENCIL_VALUE_MASK = 2963;

		[ScriptName("STENCIL_WRITEMASK")]
		public const int STENCIL_WRITEMASK = 2968;

		public void StencilFunc(int func, int @ref, int mask) {
		}

		public void StencilFuncSeparate(int face, int func, int @ref, int mask) {
		}

		public void StencilMask(int mask) {
		}

		public void StencilMaskSeparate(int face, int mask) {
		}

		public void StencilOp(int fail, int zfail, int zpass) {
		}

		public void StencilOpSeparate(int face, int fail, int zfail, int zpass) {
		}

		[ScriptName("STREAM_DRAW")]
		public const int STREAM_DRAW = 35040;

		[ScriptName("SUBPIXEL_BITS")]
		public const int SUBPIXEL_BITS = 3408;

		public void TexImage2D(int target, int level, int internalformat, int format, int type, CanvasElement canvas) {
		}

		public void TexImage2D(int target, int level, int internalformat, int format, int type, ImageData pixels) {
		}

		public void TexImage2D(int target, int level, int internalformat, int format, int type, ImageElement image) {
		}

		public void TexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, ArrayBufferView pixels) {
		}

		public void TexImage2D(int target, int level, int internalformat, int format, int type, VideoElement video) {
		}

		public void TexParameterf(int target, int pname, float param) {
		}

		public void TexParameteri(int target, int pname, int param) {
		}

		public void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, CanvasElement canvas) {
		}

		public void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, ImageData pixels) {
		}

		public void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, ImageElement image) {
		}

		public void TexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, ArrayBufferView pixels) {
		}

		public void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, VideoElement video) {
		}

		public const int TEXTURE = 5890;

		[ScriptName("TEXTURE_2D")]
		public const int TEXTURE_2D = 3553;

		[ScriptName("TEXTURE_BINDING_2D")]
		public const int TEXTURE_BINDING_2D = 32873;

		[ScriptName("TEXTURE_BINDING_CUBE_MAP")]
		public const int TEXTURE_BINDING_CUBE_MAP = 34068;

		[ScriptName("TEXTURE_CUBE_MAP")]
		public const int TEXTURE_CUBE_MAP = 34067;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_X")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_Y")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;

		[ScriptName("TEXTURE_CUBE_MAP_NEGATIVE_Z")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_X")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X = 34069;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_Y")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;

		[ScriptName("TEXTURE_CUBE_MAP_POSITIVE_Z")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;

		[ScriptName("TEXTURE_MAG_FILTER")]
		public const int TEXTURE_MAG_FILTER = 10240;

		[ScriptName("TEXTURE_MIN_FILTER")]
		public const int TEXTURE_MIN_FILTER = 10241;

		[ScriptName("TEXTURE_WRAP_S")]
		public const int TEXTURE_WRAP_S = 10242;

		[ScriptName("TEXTURE_WRAP_T")]
		public const int TEXTURE_WRAP_T = 10243;

		[ScriptName("TEXTURE0")]
		public const int TEXTURE0 = 33984;

		[ScriptName("TEXTURE1")]
		public const int TEXTURE1 = 33985;

		[ScriptName("TEXTURE10")]
		public const int TEXTURE10 = 33994;

		[ScriptName("TEXTURE11")]
		public const int TEXTURE11 = 33995;

		[ScriptName("TEXTURE12")]
		public const int TEXTURE12 = 33996;

		[ScriptName("TEXTURE13")]
		public const int TEXTURE13 = 33997;

		[ScriptName("TEXTURE14")]
		public const int TEXTURE14 = 33998;

		[ScriptName("TEXTURE15")]
		public const int TEXTURE15 = 33999;

		[ScriptName("TEXTURE16")]
		public const int TEXTURE16 = 34000;

		[ScriptName("TEXTURE17")]
		public const int TEXTURE17 = 34001;

		[ScriptName("TEXTURE18")]
		public const int TEXTURE18 = 34002;

		[ScriptName("TEXTURE19")]
		public const int TEXTURE19 = 34003;

		[ScriptName("TEXTURE2")]
		public const int TEXTURE2 = 33986;

		[ScriptName("TEXTURE20")]
		public const int TEXTURE20 = 34004;

		[ScriptName("TEXTURE21")]
		public const int TEXTURE21 = 34005;

		[ScriptName("TEXTURE22")]
		public const int TEXTURE22 = 34006;

		[ScriptName("TEXTURE23")]
		public const int TEXTURE23 = 34007;

		[ScriptName("TEXTURE24")]
		public const int TEXTURE24 = 34008;

		[ScriptName("TEXTURE25")]
		public const int TEXTURE25 = 34009;

		[ScriptName("TEXTURE26")]
		public const int TEXTURE26 = 34010;

		[ScriptName("TEXTURE27")]
		public const int TEXTURE27 = 34011;

		[ScriptName("TEXTURE28")]
		public const int TEXTURE28 = 34012;

		[ScriptName("TEXTURE29")]
		public const int TEXTURE29 = 34013;

		[ScriptName("TEXTURE3")]
		public const int TEXTURE3 = 33987;

		[ScriptName("TEXTURE30")]
		public const int TEXTURE30 = 34014;

		[ScriptName("TEXTURE31")]
		public const int TEXTURE31 = 34015;

		[ScriptName("TEXTURE4")]
		public const int TEXTURE4 = 33988;

		[ScriptName("TEXTURE5")]
		public const int TEXTURE5 = 33989;

		[ScriptName("TEXTURE6")]
		public const int TEXTURE6 = 33990;

		[ScriptName("TEXTURE7")]
		public const int TEXTURE7 = 33991;

		[ScriptName("TEXTURE8")]
		public const int TEXTURE8 = 33992;

		[ScriptName("TEXTURE9")]
		public const int TEXTURE9 = 33993;

		[ScriptName("TRIANGLE_FAN")]
		public const int TRIANGLE_FAN = 6;

		[ScriptName("TRIANGLE_STRIP")]
		public const int TRIANGLE_STRIP = 5;

		public const int TRIANGLES = 4;

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
		public const int UNPACK_ALIGNMENT = 3317;

		[ScriptName("UNPACK_COLORSPACE_CONVERSION_WEBGL")]
		public const int UNPACK_COLORSPACE_CONVERSION_WEBGL = 37443;

		[ScriptName("UNPACK_FLIP_Y_WEBGL")]
		public const int UNPACK_FLIP_Y_WEBGL = 37440;

		[ScriptName("UNPACK_PREMULTIPLY_ALPHA_WEBGL")]
		public const int UNPACK_PREMULTIPLY_ALPHA_WEBGL = 37441;

		[ScriptName("UNSIGNED_BYTE")]
		public const int UNSIGNED_BYTE = 5121;

		[ScriptName("UNSIGNED_INT")]
		public const int UNSIGNED_INT = 5125;

		[ScriptName("UNSIGNED_SHORT")]
		public const int UNSIGNED_SHORT = 5123;

		[ScriptName("UNSIGNED_SHORT_4_4_4_4")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 32819;

		[ScriptName("UNSIGNED_SHORT_5_5_5_1")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 32820;

		[ScriptName("UNSIGNED_SHORT_5_6_5")]
		public const int UNSIGNED_SHORT_5_6_5 = 33635;

		public void UseProgram(WebGLProgram program) {
		}

		[ScriptName("VALIDATE_STATUS")]
		public const int VALIDATE_STATUS = 35715;

		public void ValidateProgram(WebGLProgram program) {
		}

		public const int VENDOR = 7936;

		public const int VERSION = 7938;

		[ScriptName("VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;

		[ScriptName("VERTEX_ATTRIB_ARRAY_ENABLED")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 34338;

		[ScriptName("VERTEX_ATTRIB_ARRAY_NORMALIZED")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;

		[ScriptName("VERTEX_ATTRIB_ARRAY_POINTER")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 34373;

		[ScriptName("VERTEX_ATTRIB_ARRAY_SIZE")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 34339;

		[ScriptName("VERTEX_ATTRIB_ARRAY_STRIDE")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 34340;

		[ScriptName("VERTEX_ATTRIB_ARRAY_TYPE")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 34341;

		[ScriptName("VERTEX_SHADER")]
		public const int VERTEX_SHADER = 35633;

		public void VertexAttrib1f(int indx, float x) {
		}

		public void VertexAttrib1fv(int indx, float[] values) {
		}

		public void VertexAttrib1fv(int indx, Float32Array values) {
		}

		public void VertexAttrib2f(int indx, float x, float y) {
		}

		public void VertexAttrib2fv(int indx, float[] values) {
		}

		public void VertexAttrib2fv(int indx, Float32Array values) {
		}

		public void VertexAttrib3f(int indx, float x, float y, float z) {
		}

		public void VertexAttrib3fv(int indx, float[] values) {
		}

		public void VertexAttrib3fv(int indx, Float32Array values) {
		}

		public void VertexAttrib4f(int indx, float x, float y, float z, float w) {
		}

		public void VertexAttrib4fv(int indx, float[] values) {
		}

		public void VertexAttrib4fv(int indx, Float32Array values) {
		}

		public void VertexAttribPointer(int indx, int size, int type, bool normalized, int stride, long offset) {
		}

		public void Viewport(int x, int y, int width, int height) {
		}

		public const int VIEWPORT = 2978;

		public const int ZERO = 0;
	}
}
