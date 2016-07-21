using Bridge.Html5.Collections.TypedArrays;
using Bridge.Html5.Elements;

namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace(false), External]
	public partial class WebGLRenderingContext
	{
		internal extern WebGLRenderingContext();

		[Name("ACTIVE_ATTRIBUTES")]
		public const int ACTIVE_ATTRIBUTES = 35721;

		[Name("ACTIVE_TEXTURE")]
		public const int ACTIVE_TEXTURE = 34016;

		[Name("ACTIVE_UNIFORMS")]
		public const int ACTIVE_UNIFORMS = 35718;

		public extern void ActiveTexture(int texture);

		[Name("ALIASED_LINE_WIDTH_RANGE")]
		public const int ALIASED_LINE_WIDTH_RANGE = 33902;

		[Name("ALIASED_POINT_SIZE_RANGE")]
		public const int ALIASED_POINT_SIZE_RANGE = 33901;

		public const int ALPHA = 6406;

		[Name("ALPHA_BITS")]
		public const int ALPHA_BITS = 3413;

		public const int ALWAYS = 519;

		[Name("ARRAY_BUFFER")]
		public const int ARRAY_BUFFER = 34962;

		[Name("ARRAY_BUFFER_BINDING")]
		public const int ARRAY_BUFFER_BINDING = 34964;

		[Name("ATTACHED_SHADERS")]
		public const int ATTACHED_SHADERS = 35717;

		public extern void AttachShader(WebGLProgram program, WebGLShader shader);

		public const int BACK = 1029;

		public extern void BindAttribLocation(WebGLProgram program, int index, string name);

		public extern void BindBuffer(int target, WebGLBuffer buffer);

		public extern void BindFramebuffer(int target, WebGLFramebuffer framebuffer);

		public extern void BindRenderbuffer(int target, WebGLRenderbuffer renderbuffer);

		public extern void BindTexture(int target, WebGLTexture texture);

		public const int BLEND = 3042;

		[Name("BLEND_COLOR")]
		public const int BLEND_COLOR = 32773;

		[Name("BLEND_DST_ALPHA")]
		public const int BLEND_DST_ALPHA = 32970;

		[Name("BLEND_DST_RGB")]
		public const int BLEND_DST_RGB = 32968;

		[Name("BLEND_EQUATION")]
		public const int BLEND_EQUATION = 32777;

		[Name("BLEND_EQUATION_ALPHA")]
		public const int BLEND_EQUATION_ALPHA = 34877;

		[Name("BLEND_EQUATION_RGB")]
		public const int BLEND_EQUATION_RGB = 32777;

		[Name("BLEND_SRC_ALPHA")]
		public const int BLEND_SRC_ALPHA = 32971;

		[Name("BLEND_SRC_RGB")]
		public const int BLEND_SRC_RGB = 32969;

		public extern void BlendColor(double red, double green, double blue, double alpha);

		public extern void BlendEquation(int mode);

		public extern void BlendEquationSeparate(int modeRGB, int modeAlpha);

		public extern void BlendFunc(int sfactor, int dfactor);

		public extern void BlendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);

		[Name("BLUE_BITS")]
		public const int BLUE_BITS = 3412;

		public const int BOOL = 35670;

		[Name("BOOL_VEC2")]
		public const int BOOL_VEC2 = 35671;

		[Name("BOOL_VEC3")]
		public const int BOOL_VEC3 = 35672;

		[Name("BOOL_VEC4")]
		public const int BOOL_VEC4 = 35673;

		[Name("BROWSER_DEFAULT_WEBGL")]
		public const int BROWSER_DEFAULT_WEBGL = 37444;

		[Name("BUFFER_SIZE")]
		public const int BUFFER_SIZE = 34660;

		[Name("BUFFER_USAGE")]
		public const int BUFFER_USAGE = 34661;

		public extern void BufferData(int target, ArrayBuffer data, int usage);

		public extern void BufferData(int target, ArrayBufferView data, int usage);

		public extern void BufferData(int target, long size, int usage);

		public extern void BufferSubData(int target, long offset, ArrayBuffer data);

		public extern void BufferSubData(int target, long offset, ArrayBufferView data);

		public const int BYTE = 5120;

		public readonly HTMLCanvasElement Canvas;

		public const int CCW = 2305;

		public extern int CheckFramebufferStatus(int target);

		[Name("CLAMP_TO_EDGE")]
		public const int CLAMP_TO_EDGE = 33071;

		public extern void Clear(int mask);

		public extern void ClearColor(double red, double green, double blue, double alpha);

		public extern void ClearDepth(double depth);

		public extern void ClearStencil(int s);

		[Name("COLOR_ATTACHMENT0")]
		public const int COLOR_ATTACHMENT0 = 36064;

		[Name("COLOR_BUFFER_BIT")]
		public const int COLOR_BUFFER_BIT = 16384;

		[Name("COLOR_CLEAR_VALUE")]
		public const int COLOR_CLEAR_VALUE = 3106;

		[Name("COLOR_WRITEMASK")]
		public const int COLOR_WRITEMASK = 3107;

		public extern void ColorMask(bool red, bool green, bool blue, bool alpha);

		[Name("COMPILE_STATUS")]
		public const int COMPILE_STATUS = 35713;

		public extern void CompileShader(WebGLShader shader);

		[Name("COMPRESSED_TEXTURE_FORMATS")]
		public const int COMPRESSED_TEXTURE_FORMATS = 34467;

		public extern void CompressedTexImage2D(int target, int level, int internalformat, int width, int height, int border, ArrayBufferView data);

		public extern void CompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, ArrayBufferView data);

		[Name("CONSTANT_ALPHA")]
		public const int CONSTANT_ALPHA = 32771;

		[Name("CONSTANT_COLOR")]
		public const int CONSTANT_COLOR = 32769;

		[Name("CONTEXT_LOST_WEBGL")]
		public const int CONTEXT_LOST_WEBGL = 37442;

		public extern void CopyTexImage2D(int target, int level, int internalformat, int x, int y, int width, int height, int border);

		public extern void CopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		public extern WebGLBuffer CreateBuffer();

		public extern WebGLFramebuffer CreateFramebuffer();

		public extern WebGLProgram CreateProgram();

		public extern WebGLRenderbuffer CreateRenderbuffer();

		public extern WebGLShader CreateShader(int type);

		public extern WebGLTexture CreateTexture();

		[Name("CULL_FACE")]
		public const int CULL_FACE = 2884;

		[Name("CULL_FACE_MODE")]
		public const int CULL_FACE_MODE = 2885;

		public extern void CullFace(int mode);

		[Name("CURRENT_PROGRAM")]
		public const int CURRENT_PROGRAM = 35725;

		[Name("CURRENT_VERTEX_ATTRIB")]
		public const int CURRENT_VERTEX_ATTRIB = 34342;

		public const int CW = 2304;

		public const int DECR = 7683;

		[Name("DECR_WRAP")]
		public const int DECR_WRAP = 34056;

		[Name("DELETE_STATUS")]
		public const int DELETE_STATUS = 35712;

		public extern void DeleteBuffer(WebGLBuffer buffer);

		public extern void DeleteFramebuffer(WebGLFramebuffer framebuffer);

		public extern void DeleteProgram(WebGLProgram program);

		public extern void DeleteRenderbuffer(WebGLRenderbuffer renderbuffer);

		public extern void DeleteShader(WebGLShader shader);

		public extern void DeleteTexture(WebGLTexture texture);

		[Name("DEPTH_ATTACHMENT")]
		public const int DEPTH_ATTACHMENT = 36096;

		[Name("DEPTH_BITS")]
		public const int DEPTH_BITS = 3414;

		[Name("DEPTH_BUFFER_BIT")]
		public const int DEPTH_BUFFER_BIT = 256;

		[Name("DEPTH_CLEAR_VALUE")]
		public const int DEPTH_CLEAR_VALUE = 2931;

		[Name("DEPTH_COMPONENT")]
		public const int DEPTH_COMPONENT = 6402;

		[Name("DEPTH_COMPONENT16")]
		public const int DEPTH_COMPONENT16 = 33189;

		[Name("DEPTH_FUNC")]
		public const int DEPTH_FUNC = 2932;

		[Name("DEPTH_RANGE")]
		public const int DEPTH_RANGE = 2928;

		[Name("DEPTH_STENCIL")]
		public const int DEPTH_STENCIL = 34041;

		[Name("DEPTH_STENCIL_ATTACHMENT")]
		public const int DEPTH_STENCIL_ATTACHMENT = 33306;

		[Name("DEPTH_TEST")]
		public const int DEPTH_TEST = 2929;

		[Name("DEPTH_WRITEMASK")]
		public const int DEPTH_WRITEMASK = 2930;

		public extern void DepthFunc(int func);

		public extern void DepthMask(bool flag);

		public extern void DepthRange(double zNear, double zFar);

		public extern void DetachShader(WebGLProgram program, WebGLShader shader);

		public extern void Disable(int cap);

		public extern void DisableVertexAttribArray(int index);

		public const int DITHER = 3024;

		[Name("DONT_CARE")]
		public const int DONT_CARE = 4352;

		public extern void DrawArrays(int mode, int first, int count);

		public extern void DrawElements(int mode, int count, int type, long offset);

		public readonly int DrawingBufferHeight;

		public readonly int DrawingBufferWidth;

		[Name("DST_ALPHA")]
		public const int DST_ALPHA = 772;

		[Name("DST_COLOR")]
		public const int DST_COLOR = 774;

		[Name("DYNAMIC_DRAW")]
		public const int DYNAMIC_DRAW = 35048;

		[Name("ELEMENT_ARRAY_BUFFER")]
		public const int ELEMENT_ARRAY_BUFFER = 34963;

		[Name("ELEMENT_ARRAY_BUFFER_BINDING")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 34965;

		public extern void Enable(int cap);

		public extern void EnableVertexAttribArray(int index);

		public const int EQUAL = 514;

		public const int FASTEST = 4353;

		public extern void Finish();

		public const int FLOAT = 5126;

		[Name("FLOAT_MAT2")]
		public const int FLOAT_MAT2 = 35674;

		[Name("FLOAT_MAT3")]
		public const int FLOAT_MAT3 = 35675;

		[Name("FLOAT_MAT4")]
		public const int FLOAT_MAT4 = 35676;

		[Name("FLOAT_VEC2")]
		public const int FLOAT_VEC2 = 35664;

		[Name("FLOAT_VEC3")]
		public const int FLOAT_VEC3 = 35665;

		[Name("FLOAT_VEC4")]
		public const int FLOAT_VEC4 = 35666;

		public extern void Flush();

		[Name("FRAGMENT_SHADER")]
		public const int FRAGMENT_SHADER = 35632;

		public const int FRAMEBUFFER = 36160;

		[Name("FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 36049;

		[Name("FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 36048;

		[Name("FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 36051;

		[Name("FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 36050;

		[Name("FRAMEBUFFER_BINDING")]
		public const int FRAMEBUFFER_BINDING = 36006;

		[Name("FRAMEBUFFER_COMPLETE")]
		public const int FRAMEBUFFER_COMPLETE = 36053;

		[Name("FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 36054;

		[Name("FRAMEBUFFER_INCOMPLETE_DIMENSIONS")]
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 36057;

		[Name("FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 36055;

		[Name("FRAMEBUFFER_UNSUPPORTED")]
		public const int FRAMEBUFFER_UNSUPPORTED = 36061;

		public extern void FramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, WebGLRenderbuffer renderbuffer);

		public extern void FramebufferTexture2D(int target, int attachment, int textarget, WebGLTexture texture, int level);

		public const int FRONT = 1028;

		[Name("FRONT_AND_BACK")]
		public const int FRONT_AND_BACK = 1032;

		[Name("FRONT_FACE")]
		public const int FRONT_FACE = 2886;

		public extern void FrontFace(int mode);

		[Name("FUNC_ADD")]
		public const int FUNC_ADD = 32774;

		[Name("FUNC_REVERSE_SUBTRACT")]
		public const int FUNC_REVERSE_SUBTRACT = 32779;

		[Name("FUNC_SUBTRACT")]
		public const int FUNC_SUBTRACT = 32778;

		[Name("GENERATE_MIPMAP_HINT")]
		public const int GENERATE_MIPMAP_HINT = 33170;

		public extern void GenerateMipmap(int target);

		public const int GEQUAL = 518;

		public extern WebGLActiveInfo GetActiveAttrib(WebGLProgram program, int index);

		public extern WebGLActiveInfo GetActiveUniform(WebGLProgram program, int index);

		public extern WebGLShader[] GetAttachedShaders(WebGLProgram program);

		public extern int GetAttribLocation(WebGLProgram program, string name);

		public extern object GetBufferParameter(int target, int pname);

		public extern WebGLContextAttributes GetContextAttributes();

		public extern int GetError();

		public extern object GetExtension(string name);

		public extern object GetFramebufferAttachmentParameter(int target, int attachment, int pname);

		public extern object GetParameter(int pname);

		public extern string GetProgramInfoLog(WebGLProgram program);

		public extern object GetProgramParameter(WebGLProgram program, int pname);

		public extern object GetRenderbufferParameter(int target, int pname);

		public extern string GetShaderInfoLog(WebGLShader shader);

		public extern object GetShaderParameter(WebGLShader shader, int pname);

		public extern WebGLShaderPrecisionFormat GetShaderPrecisionFormat(int shadertype, int precisiontype);

		public extern string GetShaderSource(WebGLShader shader);

		public extern string[] GetSupportedExtensions();

		public extern object GetTexParameter(int target, int pname);

		public extern object GetUniform(WebGLProgram program, WebGLUniformLocation location);

		public extern WebGLUniformLocation GetUniformLocation(WebGLProgram program, string name);

		public extern object GetVertexAttrib(int index, int pname);

		public extern long GetVertexAttribOffset(int index, int pname);

		public const int GREATER = 516;

		[Name("GREEN_BITS")]
		public const int GREEN_BITS = 3411;

		[Name("HIGH_FLOAT")]
		public const int HIGH_FLOAT = 36338;

		[Name("HIGH_INT")]
		public const int HIGH_INT = 36341;

		public extern void Hint(int target, int mode);

		public const int INCR = 7682;

		[Name("INCR_WRAP")]
		public const int INCR_WRAP = 34055;

		public const int INT = 5124;

		[Name("INT_VEC2")]
		public const int INT_VEC2 = 35667;

		[Name("INT_VEC3")]
		public const int INT_VEC3 = 35668;

		[Name("INT_VEC4")]
		public const int INT_VEC4 = 35669;

		[Name("INVALID_ENUM")]
		public const int INVALID_ENUM = 1280;

		[Name("INVALID_FRAMEBUFFER_OPERATION")]
		public const int INVALID_FRAMEBUFFER_OPERATION = 1286;

		[Name("INVALID_OPERATION")]
		public const int INVALID_OPERATION = 1282;

		[Name("INVALID_VALUE")]
		public const int INVALID_VALUE = 1281;

		public const int INVERT = 5386;

		public extern bool IsBuffer(WebGLBuffer buffer);

		public extern bool IsContextLost();

		public extern bool IsEnabled(int cap);

		public extern bool IsFramebuffer(WebGLFramebuffer framebuffer);

		public extern bool IsProgram(WebGLProgram program);

		public extern bool IsRenderbuffer(WebGLRenderbuffer renderbuffer);

		public extern bool IsShader(WebGLShader shader);

		public extern bool IsTexture(WebGLTexture texture);

		public const int KEEP = 7680;

		public const int LEQUAL = 515;

		public const int LESS = 513;

		[Name("LINE_LOOP")]
		public const int LINE_LOOP = 2;

		[Name("LINE_STRIP")]
		public const int LINE_STRIP = 3;

		[Name("LINE_WIDTH")]
		public const int LINE_WIDTH = 2849;

		public const int LINEAR = 9729;

		[Name("LINEAR_MIPMAP_LINEAR")]
		public const int LINEAR_MIPMAP_LINEAR = 9987;

		[Name("LINEAR_MIPMAP_NEAREST")]
		public const int LINEAR_MIPMAP_NEAREST = 9985;

		public const int LINES = 1;

		public extern void LineWidth(double width);

		[Name("LINK_STATUS")]
		public const int LINK_STATUS = 35714;

		public extern void LinkProgram(WebGLProgram program);

		[Name("LOW_FLOAT")]
		public const int LOW_FLOAT = 36336;

		[Name("LOW_INT")]
		public const int LOW_INT = 36339;

		public const int LUMINANCE = 6409;

		[Name("LUMINANCE_ALPHA")]
		public const int LUMINANCE_ALPHA = 6410;

		[Name("MAX_COMBINED_TEXTURE_IMAGE_UNITS")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 35661;

		[Name("MAX_CUBE_MAP_TEXTURE_SIZE")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE = 34076;

		[Name("MAX_FRAGMENT_UNIFORM_VECTORS")]
		public const int MAX_FRAGMENT_UNIFORM_VECTORS = 36349;

		[Name("MAX_RENDERBUFFER_SIZE")]
		public const int MAX_RENDERBUFFER_SIZE = 34024;

		[Name("MAX_TEXTURE_IMAGE_UNITS")]
		public const int MAX_TEXTURE_IMAGE_UNITS = 34930;

		[Name("MAX_TEXTURE_SIZE")]
		public const int MAX_TEXTURE_SIZE = 3379;

		[Name("MAX_VARYING_VECTORS")]
		public const int MAX_VARYING_VECTORS = 36348;

		[Name("MAX_VERTEX_ATTRIBS")]
		public const int MAX_VERTEX_ATTRIBS = 34921;

		[Name("MAX_VERTEX_TEXTURE_IMAGE_UNITS")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 35660;

		[Name("MAX_VERTEX_UNIFORM_VECTORS")]
		public const int MAX_VERTEX_UNIFORM_VECTORS = 36347;

		[Name("MAX_VIEWPORT_DIMS")]
		public const int MAX_VIEWPORT_DIMS = 3386;

		[Name("MEDIUM_FLOAT")]
		public const int MEDIUM_FLOAT = 36337;

		[Name("MEDIUM_INT")]
		public const int MEDIUM_INT = 36340;

		[Name("MIRRORED_REPEAT")]
		public const int MIRRORED_REPEAT = 33648;

		public const int NEAREST = 9728;

		[Name("NEAREST_MIPMAP_LINEAR")]
		public const int NEAREST_MIPMAP_LINEAR = 9986;

		[Name("NEAREST_MIPMAP_NEAREST")]
		public const int NEAREST_MIPMAP_NEAREST = 9984;

		public const int NEVER = 512;

		public const int NICEST = 4354;

		[Name("NO_ERROR")]
		public const int NO_ERROR = 0;

		public const int NONE = 0;

		public const int NOTEQUAL = 517;

		public const int ONE = 1;

		[Name("ONE_MINUS_CONSTANT_ALPHA")]
		public const int ONE_MINUS_CONSTANT_ALPHA = 32772;

		[Name("ONE_MINUS_CONSTANT_COLOR")]
		public const int ONE_MINUS_CONSTANT_COLOR = 32770;

		[Name("ONE_MINUS_DST_ALPHA")]
		public const int ONE_MINUS_DST_ALPHA = 773;

		[Name("ONE_MINUS_DST_COLOR")]
		public const int ONE_MINUS_DST_COLOR = 775;

		[Name("ONE_MINUS_SRC_ALPHA")]
		public const int ONE_MINUS_SRC_ALPHA = 771;

		[Name("ONE_MINUS_SRC_COLOR")]
		public const int ONE_MINUS_SRC_COLOR = 769;

		[Name("OUT_OF_MEMORY")]
		public const int OUT_OF_MEMORY = 1285;

		[Name("PACK_ALIGNMENT")]
		public const int PACK_ALIGNMENT = 3333;

		public extern void PixelStorei(int pname, int param);

		public const int POINTS = 0;

		[Name("POLYGON_OFFSET_FACTOR")]
		public const int POLYGON_OFFSET_FACTOR = 32824;

		[Name("POLYGON_OFFSET_FILL")]
		public const int POLYGON_OFFSET_FILL = 32823;

		[Name("POLYGON_OFFSET_UNITS")]
		public const int POLYGON_OFFSET_UNITS = 10752;

		public extern void PolygonOffset(double factor, double units);

		public extern void ReadPixels(int x, int y, int width, int height, int format, int type, ArrayBufferView pixels);

		[Name("RED_BITS")]
		public const int RED_BITS = 3410;

		public const int RENDERBUFFER = 36161;

		[Name("RENDERBUFFER_ALPHA_SIZE")]
		public const int RENDERBUFFER_ALPHA_SIZE = 36179;

		[Name("RENDERBUFFER_BINDING")]
		public const int RENDERBUFFER_BINDING = 36007;

		[Name("RENDERBUFFER_BLUE_SIZE")]
		public const int RENDERBUFFER_BLUE_SIZE = 36178;

		[Name("RENDERBUFFER_DEPTH_SIZE")]
		public const int RENDERBUFFER_DEPTH_SIZE = 36180;

		[Name("RENDERBUFFER_GREEN_SIZE")]
		public const int RENDERBUFFER_GREEN_SIZE = 36177;

		[Name("RENDERBUFFER_HEIGHT")]
		public const int RENDERBUFFER_HEIGHT = 36163;

		[Name("RENDERBUFFER_INTERNAL_FORMAT")]
		public const int RENDERBUFFER_INTERNAL_FORMAT = 36164;

		[Name("RENDERBUFFER_RED_SIZE")]
		public const int RENDERBUFFER_RED_SIZE = 36176;

		[Name("RENDERBUFFER_STENCIL_SIZE")]
		public const int RENDERBUFFER_STENCIL_SIZE = 36181;

		[Name("RENDERBUFFER_WIDTH")]
		public const int RENDERBUFFER_WIDTH = 36162;

		public extern void RenderbufferStorage(int target, int internalformat, int width, int height);

		public const int RENDERER = 7937;

		public const int REPEAT = 10497;

		public const int REPLACE = 7681;

		public const int RGB = 6407;

		[Name("RGB5_A1")]
		public const int RGB5_A1 = 32855;

		[Name("RGB565")]
		public const int RGB565 = 36194;

		public const int RGBA = 6408;

		[Name("RGBA4")]
		public const int RGBA4 = 32854;

		[Name("SAMPLE_ALPHA_TO_COVERAGE")]
		public const int SAMPLE_ALPHA_TO_COVERAGE = 32926;

		[Name("SAMPLE_BUFFERS")]
		public const int SAMPLE_BUFFERS = 32936;

		[Name("SAMPLE_COVERAGE")]
		public const int SAMPLE_COVERAGE = 32928;

		[Name("SAMPLE_COVERAGE_INVERT")]
		public const int SAMPLE_COVERAGE_INVERT = 32939;

		[Name("SAMPLE_COVERAGE_VALUE")]
		public const int SAMPLE_COVERAGE_VALUE = 32938;

		public extern void SampleCoverage(double value, bool invert);

		[Name("SAMPLER_2D")]
		public const int SAMPLER_2D = 35678;

		[Name("SAMPLER_CUBE")]
		public const int SAMPLER_CUBE = 35680;

		public const int SAMPLES = 32937;

		public extern void Scissor(int x, int y, int width, int height);

		[Name("SCISSOR_BOX")]
		public const int SCISSOR_BOX = 3088;

		[Name("SCISSOR_TEST")]
		public const int SCISSOR_TEST = 3089;

		[Name("SHADER_TYPE")]
		public const int SHADER_TYPE = 35663;

		public extern void ShaderSource(WebGLShader shader, string source);

		[Name("SHADING_LANGUAGE_VERSION")]
		public const int SHADING_LANGUAGE_VERSION = 35724;

		public const int SHORT = 5122;

		[Name("SRC_ALPHA")]
		public const int SRC_ALPHA = 770;

		[Name("SRC_ALPHA_SATURATE")]
		public const int SRC_ALPHA_SATURATE = 776;

		[Name("SRC_COLOR")]
		public const int SRC_COLOR = 768;

		[Name("STATIC_DRAW")]
		public const int STATIC_DRAW = 35044;

		[Name("STENCIL_ATTACHMENT")]
		public const int STENCIL_ATTACHMENT = 36128;

		[Name("STENCIL_BACK_FAIL")]
		public const int STENCIL_BACK_FAIL = 34817;

		[Name("STENCIL_BACK_FUNC")]
		public const int STENCIL_BACK_FUNC = 34816;

		[Name("STENCIL_BACK_PASS_DEPTH_FAIL")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL = 34818;

		[Name("STENCIL_BACK_PASS_DEPTH_PASS")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS = 34819;

		[Name("STENCIL_BACK_REF")]
		public const int STENCIL_BACK_REF = 36003;

		[Name("STENCIL_BACK_VALUE_MASK")]
		public const int STENCIL_BACK_VALUE_MASK = 36004;

		[Name("STENCIL_BACK_WRITEMASK")]
		public const int STENCIL_BACK_WRITEMASK = 36005;

		[Name("STENCIL_BITS")]
		public const int STENCIL_BITS = 3415;

		[Name("STENCIL_BUFFER_BIT")]
		public const int STENCIL_BUFFER_BIT = 1024;

		[Name("STENCIL_CLEAR_VALUE")]
		public const int STENCIL_CLEAR_VALUE = 2961;

		[Name("STENCIL_FAIL")]
		public const int STENCIL_FAIL = 2964;

		[Name("STENCIL_FUNC")]
		public const int STENCIL_FUNC = 2962;

		[Name("STENCIL_INDEX")]
		public const int STENCIL_INDEX = 6401;

		[Name("STENCIL_INDEX8")]
		public const int STENCIL_INDEX8 = 36168;

		[Name("STENCIL_PASS_DEPTH_FAIL")]
		public const int STENCIL_PASS_DEPTH_FAIL = 2965;

		[Name("STENCIL_PASS_DEPTH_PASS")]
		public const int STENCIL_PASS_DEPTH_PASS = 2966;

		[Name("STENCIL_REF")]
		public const int STENCIL_REF = 2967;

		[Name("STENCIL_TEST")]
		public const int STENCIL_TEST = 2960;

		[Name("STENCIL_VALUE_MASK")]
		public const int STENCIL_VALUE_MASK = 2963;

		[Name("STENCIL_WRITEMASK")]
		public const int STENCIL_WRITEMASK = 2968;

		public extern void StencilFunc(int func, int @ref, int mask);

		public extern void StencilFuncSeparate(int face, int func, int @ref, int mask);

		public extern void StencilMask(int mask);

		public extern void StencilMaskSeparate(int face, int mask);

		public extern void StencilOp(int fail, int zfail, int zpass);

		public extern void StencilOpSeparate(int face, int fail, int zfail, int zpass);

		[Name("STREAM_DRAW")]
		public const int STREAM_DRAW = 35040;

		[Name("SUBPIXEL_BITS")]
		public const int SUBPIXEL_BITS = 3408;

		public extern void TexImage2D(int target, int level, int internalformat, int format, int type, HTMLCanvasElement canvas);

		public extern void TexImage2D(int target, int level, int internalformat, int format, int type, HTMLImageElement image);

		public extern void TexImage2D(int target, int level, int internalformat, int format, int type, HTMLVideoElement video);

		public extern void TexImage2D(int target, int level, int internalformat, int format, int type, ImageData pixels);

		public extern void TexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, ArrayBufferView pixels);

		public extern void TexParameterf(int target, int pname, double param);

		public extern void TexParameteri(int target, int pname, int param);

		public extern void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, HTMLCanvasElement canvas);

		public extern void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, HTMLImageElement image);

		public extern void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, HTMLVideoElement video);

		public extern void TexSubImage2D(int target, int level, int xoffset, int yoffset, int format, int type, ImageData pixels);

		public extern void TexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, ArrayBufferView pixels);

		public const int TEXTURE = 5890;

		[Name("TEXTURE_2D")]
		public const int TEXTURE_2D = 3553;

		[Name("TEXTURE_BINDING_2D")]
		public const int TEXTURE_BINDING_2D = 32873;

		[Name("TEXTURE_BINDING_CUBE_MAP")]
		public const int TEXTURE_BINDING_CUBE_MAP = 34068;

		[Name("TEXTURE_CUBE_MAP")]
		public const int TEXTURE_CUBE_MAP = 34067;

		[Name("TEXTURE_CUBE_MAP_NEGATIVE_X")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 34070;

		[Name("TEXTURE_CUBE_MAP_NEGATIVE_Y")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 34072;

		[Name("TEXTURE_CUBE_MAP_NEGATIVE_Z")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 34074;

		[Name("TEXTURE_CUBE_MAP_POSITIVE_X")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X = 34069;

		[Name("TEXTURE_CUBE_MAP_POSITIVE_Y")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 34071;

		[Name("TEXTURE_CUBE_MAP_POSITIVE_Z")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 34073;

		[Name("TEXTURE_MAG_FILTER")]
		public const int TEXTURE_MAG_FILTER = 10240;

		[Name("TEXTURE_MIN_FILTER")]
		public const int TEXTURE_MIN_FILTER = 10241;

		[Name("TEXTURE_WRAP_S")]
		public const int TEXTURE_WRAP_S = 10242;

		[Name("TEXTURE_WRAP_T")]
		public const int TEXTURE_WRAP_T = 10243;

		[Name("TEXTURE0")]
		public const int TEXTURE0 = 33984;

		[Name("TEXTURE1")]
		public const int TEXTURE1 = 33985;

		[Name("TEXTURE10")]
		public const int TEXTURE10 = 33994;

		[Name("TEXTURE11")]
		public const int TEXTURE11 = 33995;

		[Name("TEXTURE12")]
		public const int TEXTURE12 = 33996;

		[Name("TEXTURE13")]
		public const int TEXTURE13 = 33997;

		[Name("TEXTURE14")]
		public const int TEXTURE14 = 33998;

		[Name("TEXTURE15")]
		public const int TEXTURE15 = 33999;

		[Name("TEXTURE16")]
		public const int TEXTURE16 = 34000;

		[Name("TEXTURE17")]
		public const int TEXTURE17 = 34001;

		[Name("TEXTURE18")]
		public const int TEXTURE18 = 34002;

		[Name("TEXTURE19")]
		public const int TEXTURE19 = 34003;

		[Name("TEXTURE2")]
		public const int TEXTURE2 = 33986;

		[Name("TEXTURE20")]
		public const int TEXTURE20 = 34004;

		[Name("TEXTURE21")]
		public const int TEXTURE21 = 34005;

		[Name("TEXTURE22")]
		public const int TEXTURE22 = 34006;

		[Name("TEXTURE23")]
		public const int TEXTURE23 = 34007;

		[Name("TEXTURE24")]
		public const int TEXTURE24 = 34008;

		[Name("TEXTURE25")]
		public const int TEXTURE25 = 34009;

		[Name("TEXTURE26")]
		public const int TEXTURE26 = 34010;

		[Name("TEXTURE27")]
		public const int TEXTURE27 = 34011;

		[Name("TEXTURE28")]
		public const int TEXTURE28 = 34012;

		[Name("TEXTURE29")]
		public const int TEXTURE29 = 34013;

		[Name("TEXTURE3")]
		public const int TEXTURE3 = 33987;

		[Name("TEXTURE30")]
		public const int TEXTURE30 = 34014;

		[Name("TEXTURE31")]
		public const int TEXTURE31 = 34015;

		[Name("TEXTURE4")]
		public const int TEXTURE4 = 33988;

		[Name("TEXTURE5")]
		public const int TEXTURE5 = 33989;

		[Name("TEXTURE6")]
		public const int TEXTURE6 = 33990;

		[Name("TEXTURE7")]
		public const int TEXTURE7 = 33991;

		[Name("TEXTURE8")]
		public const int TEXTURE8 = 33992;

		[Name("TEXTURE9")]
		public const int TEXTURE9 = 33993;

		[Name("TRIANGLE_FAN")]
		public const int TRIANGLE_FAN = 6;

		[Name("TRIANGLE_STRIP")]
		public const int TRIANGLE_STRIP = 5;

		public const int TRIANGLES = 4;

		public extern void Uniform1f(WebGLUniformLocation location, double x);

		public extern void Uniform1fv(WebGLUniformLocation location, double[] v);

		public extern void Uniform1fv(WebGLUniformLocation location, Float32Array v);

		public extern void Uniform1i(WebGLUniformLocation location, int x);

		public extern void Uniform1iv(WebGLUniformLocation location, int[] v);

		public extern void Uniform1iv(WebGLUniformLocation location, Int32Array v);

		public extern void Uniform2f(WebGLUniformLocation location, double x, double y);

		public extern void Uniform2fv(WebGLUniformLocation location, double[] v);

		public extern void Uniform2fv(WebGLUniformLocation location, Float32Array v);

		public extern void Uniform2i(WebGLUniformLocation location, int x, int y);

		public extern void Uniform2iv(WebGLUniformLocation location, int[] v);

		public extern void Uniform2iv(WebGLUniformLocation location, Int32Array v);

		public extern void Uniform3f(WebGLUniformLocation location, double x, double y, double z);

		public extern void Uniform3fv(WebGLUniformLocation location, double[] v);

		public extern void Uniform3fv(WebGLUniformLocation location, Float32Array v);

		public extern void Uniform3i(WebGLUniformLocation location, int x, int y, int z);

		public extern void Uniform3iv(WebGLUniformLocation location, int[] v);

		public extern void Uniform3iv(WebGLUniformLocation location, Int32Array v);

		public extern void Uniform4f(WebGLUniformLocation location, double x, double y, double z, double w);

		public extern void Uniform4fv(WebGLUniformLocation location, double[] v);

		public extern void Uniform4fv(WebGLUniformLocation location, Float32Array v);

		public extern void Uniform4i(WebGLUniformLocation location, int x, int y, int z, int w);

		public extern void Uniform4iv(WebGLUniformLocation location, int[] v);

		public extern void Uniform4iv(WebGLUniformLocation location, Int32Array v);

		public extern void UniformMatrix2fv(WebGLUniformLocation location, bool transpose, double[] value);

		public extern void UniformMatrix2fv(WebGLUniformLocation location, bool transpose, Float32Array value);

		public extern void UniformMatrix3fv(WebGLUniformLocation location, bool transpose, double[] value);

		public extern void UniformMatrix3fv(WebGLUniformLocation location, bool transpose, Float32Array value);

		public extern void UniformMatrix4fv(WebGLUniformLocation location, bool transpose, double[] value);

		public extern void UniformMatrix4fv(WebGLUniformLocation location, bool transpose, Float32Array value);

		[Name("UNPACK_ALIGNMENT")]
		public const int UNPACK_ALIGNMENT = 3317;

		[Name("UNPACK_COLORSPACE_CONVERSION_WEBGL")]
		public const int UNPACK_COLORSPACE_CONVERSION_WEBGL = 37443;

		[Name("UNPACK_FLIP_Y_WEBGL")]
		public const int UNPACK_FLIP_Y_WEBGL = 37440;

		[Name("UNPACK_PREMULTIPLY_ALPHA_WEBGL")]
		public const int UNPACK_PREMULTIPLY_ALPHA_WEBGL = 37441;

		[Name("UNSIGNED_BYTE")]
		public const int UNSIGNED_BYTE = 5121;

		[Name("UNSIGNED_INT")]
		public const int UNSIGNED_INT = 5125;

		[Name("UNSIGNED_SHORT")]
		public const int UNSIGNED_SHORT = 5123;

		[Name("UNSIGNED_SHORT_4_4_4_4")]
		public const int UNSIGNED_SHORT_4_4_4_4 = 32819;

		[Name("UNSIGNED_SHORT_5_5_5_1")]
		public const int UNSIGNED_SHORT_5_5_5_1 = 32820;

		[Name("UNSIGNED_SHORT_5_6_5")]
		public const int UNSIGNED_SHORT_5_6_5 = 33635;

		public extern void UseProgram(WebGLProgram program);

		[Name("VALIDATE_STATUS")]
		public const int VALIDATE_STATUS = 35715;

		public extern void ValidateProgram(WebGLProgram program);

		public const int VENDOR = 7936;

		public const int VERSION = 7938;

		[Name("VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 34975;

		[Name("VERTEX_ATTRIB_ARRAY_ENABLED")]
		public const int VERTEX_ATTRIB_ARRAY_ENABLED = 34338;

		[Name("VERTEX_ATTRIB_ARRAY_NORMALIZED")]
		public const int VERTEX_ATTRIB_ARRAY_NORMALIZED = 34922;

		[Name("VERTEX_ATTRIB_ARRAY_POINTER")]
		public const int VERTEX_ATTRIB_ARRAY_POINTER = 34373;

		[Name("VERTEX_ATTRIB_ARRAY_SIZE")]
		public const int VERTEX_ATTRIB_ARRAY_SIZE = 34339;

		[Name("VERTEX_ATTRIB_ARRAY_STRIDE")]
		public const int VERTEX_ATTRIB_ARRAY_STRIDE = 34340;

		[Name("VERTEX_ATTRIB_ARRAY_TYPE")]
		public const int VERTEX_ATTRIB_ARRAY_TYPE = 34341;

		[Name("VERTEX_SHADER")]
		public const int VERTEX_SHADER = 35633;

		public extern void VertexAttrib1f(int indx, double x);

		public extern void VertexAttrib1fv(int indx, double[] values);

		public extern void VertexAttrib1fv(int indx, Float32Array values);

		public extern void VertexAttrib2f(int indx, double x, double y);

		public extern void VertexAttrib2fv(int indx, double[] values);

		public extern void VertexAttrib2fv(int indx, Float32Array values);

		public extern void VertexAttrib3f(int indx, double x, double y, double z);

		public extern void VertexAttrib3fv(int indx, double[] values);

		public extern void VertexAttrib3fv(int indx, Float32Array values);

		public extern void VertexAttrib4f(int indx, double x, double y, double z, double w);

		public extern void VertexAttrib4fv(int indx, double[] values);

		public extern void VertexAttrib4fv(int indx, Float32Array values);

		public extern void VertexAttribPointer(int indx, int size, int type, bool normalized, int stride, long offset);

		public extern void Viewport(int x, int y, int width, int height);

		public const int VIEWPORT = 2978;

		public const int ZERO = 0;
	}
}
