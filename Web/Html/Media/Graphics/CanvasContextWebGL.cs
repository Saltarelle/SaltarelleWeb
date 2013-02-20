// CanvasContextWebGL.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
// Added by Delta Engine for Web Support - see http://deltaengine.net
//

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Html.Media.Graphics.WebGL;

namespace System.Html.Media.Graphics
{
	[IgnoreNamespace]
	[Imported]
	// ReSharper disable InconsistentNaming
	public sealed class CanvasContextWebGL : CanvasContext
	{
		private CanvasContextWebGL()
		{
		}

		[PreserveCase] public readonly int DEPTH_BUFFER_BIT = 0x00000100;
		[PreserveCase] public readonly int STENCIL_BUFFER_BIT = 0x00000400;
		[PreserveCase] public readonly int COLOR_BUFFER_BIT = 0x00004000;
		[PreserveCase] public readonly int POINTS = 0x0000;
		[PreserveCase] public readonly int LINES = 0x0001;
		[PreserveCase] public readonly int LINE_LOOP = 0x0002;
		[PreserveCase] public readonly int LINE_STRIP = 0x0003;
		[PreserveCase] public readonly int TRIANGLES = 0x0004;
		[PreserveCase] public readonly int TRIANGLE_STRIP = 0x0005;
		[PreserveCase] public readonly int TRIANGLE_FAN = 0x0006;
		[PreserveCase] public readonly int ZERO = 0;
		[PreserveCase] public readonly int ONE = 1;
		[PreserveCase] public readonly int SRC_COLOR = 0x0300;
		[PreserveCase] public readonly int ONE_MINUS_SRC_COLOR = 0x0301;
		[PreserveCase] public readonly int SRC_ALPHA = 0x0302;
		[PreserveCase] public readonly int ONE_MINUS_SRC_ALPHA = 0x0303;
		[PreserveCase] public readonly int DST_ALPHA = 0x0304;
		[PreserveCase] public readonly int ONE_MINUS_DST_ALPHA = 0x0305;
		[PreserveCase] public readonly int DST_COLOR = 0x0306;
		[PreserveCase] public readonly int ONE_MINUS_DST_COLOR = 0x0307;
		[PreserveCase] public readonly int SRC_ALPHA_SATURATE = 0x0308;
		[PreserveCase] public readonly int FUNC_ADD = 0x8006;
		[PreserveCase] public readonly int BLEND_EQUATION = 0x8009;
		[PreserveCase] public readonly int BLEND_EQUATION_RGB = 0x8009 /* same as BLEND_EQUATION */;
		[PreserveCase] public readonly int BLEND_EQUATION_ALPHA = 0x883D;
		[PreserveCase] public readonly int FUNC_SUBTRACT = 0x800A;
		[PreserveCase] public readonly int FUNC_REVERSE_SUBTRACT = 0x800B;
		[PreserveCase] public readonly int BLEND_DST_RGB = 0x80C8;
		[PreserveCase] public readonly int BLEND_SRC_RGB = 0x80C9;
		[PreserveCase] public readonly int BLEND_DST_ALPHA = 0x80CA;
		[PreserveCase] public readonly int BLEND_SRC_ALPHA = 0x80CB;
		[PreserveCase] public readonly int CONSTANT_COLOR = 0x8001;
		[PreserveCase] public readonly int ONE_MINUS_CONSTANT_COLOR = 0x8002;
		[PreserveCase] public readonly int CONSTANT_ALPHA = 0x8003;
		[PreserveCase] public readonly int ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		[PreserveCase] public readonly int BLEND_COLOR = 0x8005;
		[PreserveCase] public readonly int ARRAY_BUFFER = 0x8892;
		[PreserveCase] public readonly int ELEMENT_ARRAY_BUFFER = 0x8893;
		[PreserveCase] public readonly int ARRAY_BUFFER_BINDING = 0x8894;
		[PreserveCase] public readonly int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
		[PreserveCase] public readonly int STREAM_DRAW = 0x88E0;
		[PreserveCase] public readonly int STATIC_DRAW = 0x88E4;
		[PreserveCase] public readonly int DYNAMIC_DRAW = 0x88E8;
		[PreserveCase] public readonly int BUFFER_SIZE = 0x8764;
		[PreserveCase] public readonly int BUFFER_USAGE = 0x8765;
		[PreserveCase] public readonly int CURRENT_VERTEX_ATTRIB = 0x8626;
		[PreserveCase] public readonly int FRONT = 0x0404;
		[PreserveCase] public readonly int BACK = 0x0405;
		[PreserveCase] public readonly int FRONT_AND_BACK = 0x0408;
		[PreserveCase] public readonly int CULL_FACE = 0x0B44;
		[PreserveCase] public readonly int BLEND = 0x0BE2;
		[PreserveCase] public readonly int DITHER = 0x0BD0;
		[PreserveCase] public readonly int STENCIL_TEST = 0x0B90;
		[PreserveCase] public readonly int DEPTH_TEST = 0x0B71;
		[PreserveCase] public readonly int SCISSOR_TEST = 0x0C11;
		[PreserveCase] public readonly int POLYGON_OFFSET_FILL = 0x8037;
		[PreserveCase] public readonly int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		[PreserveCase] public readonly int SAMPLE_COVERAGE = 0x80A0;
		[PreserveCase] public readonly int NO_ERROR = 0;
		[PreserveCase] public readonly int INVALID_ENUM = 0x0500;
		[PreserveCase] public readonly int INVALID_VALUE = 0x0501;
		[PreserveCase] public readonly int INVALID_OPERATION = 0x0502;
		[PreserveCase] public readonly int OUT_OF_MEMORY = 0x0505;
		[PreserveCase] public readonly int CW = 0x0900;
		[PreserveCase] public readonly int CCW = 0x0901;
		[PreserveCase] public readonly int LINE_WIDTH = 0x0B21;
		[PreserveCase] public readonly int ALIASED_POINT_SIZE_RANGE = 0x846D;
		[PreserveCase] public readonly int ALIASED_LINE_WIDTH_RANGE = 0x846E;
		[PreserveCase] public readonly int CULL_FACE_MODE = 0x0B45;
		[PreserveCase] public readonly int FRONT_FACE = 0x0B46;
		[PreserveCase] public readonly int DEPTH_RANGE = 0x0B70;
		[PreserveCase] public readonly int DEPTH_WRITEMASK = 0x0B72;
		[PreserveCase] public readonly int DEPTH_CLEAR_VALUE = 0x0B73;
		[PreserveCase] public readonly int DEPTH_FUNC = 0x0B74;
		[PreserveCase] public readonly int STENCIL_CLEAR_VALUE = 0x0B91;
		[PreserveCase] public readonly int STENCIL_FUNC = 0x0B92;
		[PreserveCase] public readonly int STENCIL_FAIL = 0x0B94;
		[PreserveCase] public readonly int STENCIL_PASS_DEPTH_FAIL = 0x0B95;
		[PreserveCase] public readonly int STENCIL_PASS_DEPTH_PASS = 0x0B96;
		[PreserveCase] public readonly int STENCIL_value = 0x0B97;
		[PreserveCase] public readonly int STENCIL_VALUE_MASK = 0x0B93;
		[PreserveCase] public readonly int STENCIL_WRITEMASK = 0x0B98;
		[PreserveCase] public readonly int STENCIL_BACK_FUNC = 0x8800;
		[PreserveCase] public readonly int STENCIL_BACK_FAIL = 0x8801;
		[PreserveCase] public readonly int STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
		[PreserveCase] public readonly int STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
		[PreserveCase] public readonly int STENCIL_BACK_value = 0x8CA3;
		[PreserveCase] public readonly int STENCIL_BACK_VALUE_MASK = 0x8CA4;
		[PreserveCase] public readonly int STENCIL_BACK_WRITEMASK = 0x8CA5;
		[PreserveCase] public readonly int VIEWPORT = 0x0BA2;
		[PreserveCase] public readonly int SCISSOR_BOX = 0x0C10;
		[PreserveCase] public readonly int COLOR_CLEAR_VALUE = 0x0C22;
		[PreserveCase] public readonly int COLOR_WRITEMASK = 0x0C23;
		[PreserveCase] public readonly int UNPACK_ALIGNMENT = 0x0CF5;
		[PreserveCase] public readonly int PACK_ALIGNMENT = 0x0D05;
		[PreserveCase] public readonly int MAX_TEXTURE_SIZE = 0x0D33;
		[PreserveCase] public readonly int MAX_VIEWPORT_DIMS = 0x0D3A;
		[PreserveCase] public readonly int SUBPIXEL_BITS = 0x0D50;
		[PreserveCase] public readonly int RED_BITS = 0x0D52;
		[PreserveCase] public readonly int GREEN_BITS = 0x0D53;
		[PreserveCase] public readonly int BLUE_BITS = 0x0D54;
		[PreserveCase] public readonly int ALPHA_BITS = 0x0D55;
		[PreserveCase] public readonly int DEPTH_BITS = 0x0D56;
		[PreserveCase] public readonly int STENCIL_BITS = 0x0D57;
		[PreserveCase] public readonly int POLYGON_OFFSET_UNITS = 0x2A00;
		[PreserveCase] public readonly int POLYGON_OFFSET_FACTOR = 0x8038;
		[PreserveCase] public readonly int TEXTURE_BINDING_2D = 0x8069;
		[PreserveCase] public readonly int SAMPLE_BUFFERS = 0x80A8;
		[PreserveCase] public readonly int SAMPLES = 0x80A9;
		[PreserveCase] public readonly int SAMPLE_COVERAGE_VALUE = 0x80AA;
		[PreserveCase] public readonly int SAMPLE_COVERAGE_INVERT = 0x80AB;
		[PreserveCase] public readonly int COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		[PreserveCase] public readonly int DONT_CARE = 0x1100;
		[PreserveCase] public readonly int FASTEST = 0x1101;
		[PreserveCase] public readonly int NICEST = 0x1102;
		[PreserveCase] public readonly int GENERATE_MIPMAP_HINT = 0x8192;
		[PreserveCase] public readonly int BYTE = 0x1400;
		[PreserveCase] public readonly int UNSIGNED_BYTE = 0x1401;
		[PreserveCase] public readonly int SHORT = 0x1402;
		[PreserveCase] public readonly int UNSIGNED_SHORT = 0x1403;
		[PreserveCase] public readonly int INT = 0x1404;
		[PreserveCase] public readonly int UNSIGNED_INT = 0x1405;
		[PreserveCase] public readonly int FLOAT = 0x1406;
		[PreserveCase] public readonly int DEPTH_COMPONENT = 0x1902;
		[PreserveCase] public readonly int ALPHA = 0x1906;
		[PreserveCase] public readonly int RGB = 0x1907;
		[PreserveCase] public readonly int RGBA = 0x1908;
		[PreserveCase] public readonly int LUMINANCE = 0x1909;
		[PreserveCase] public readonly int LUMINANCE_ALPHA = 0x190A;
		[PreserveCase] public readonly int UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		[PreserveCase] public readonly int UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		[PreserveCase] public readonly int UNSIGNED_SHORT_5_6_5 = 0x8363;
		[PreserveCase] public readonly int FRAGMENT_SHADER = 0x8B30;
		[PreserveCase] public readonly int VERTEX_SHADER = 0x8B31;
		[PreserveCase] public readonly int MAX_VERTEX_ATTRIBS = 0x8869;
		[PreserveCase] public readonly int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
		[PreserveCase] public readonly int MAX_VARYING_VECTORS = 0x8DFC;
		[PreserveCase] public readonly int MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
		[PreserveCase] public readonly int MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
		[PreserveCase] public readonly int MAX_TEXTURE_IMAGE_UNITS = 0x8872;
		[PreserveCase] public readonly int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
		[PreserveCase] public readonly int SHADER_TYPE = 0x8B4F;
		[PreserveCase] public readonly int DELETE_STATUS = 0x8B80;
		[PreserveCase] public readonly int LINK_STATUS = 0x8B82;
		[PreserveCase] public readonly int VALIDATE_STATUS = 0x8B83;
		[PreserveCase] public readonly int ATTACHED_SHADERS = 0x8B85;
		[PreserveCase] public readonly int ACTIVE_UNIFORMS = 0x8B86;
		[PreserveCase] public readonly int ACTIVE_ATTRIBUTES = 0x8B89;
		[PreserveCase] public readonly int SHADING_LANGUAGE_VERSION = 0x8B8C;
		[PreserveCase] public readonly int CURRENT_PROGRAM = 0x8B8D;
		[PreserveCase] public readonly int NEVER = 0x0200;
		[PreserveCase] public readonly int LESS = 0x0201;
		[PreserveCase] public readonly int EQUAL = 0x0202;
		[PreserveCase] public readonly int LEQUAL = 0x0203;
		[PreserveCase] public readonly int GREATER = 0x0204;
		[PreserveCase] public readonly int NOTEQUAL = 0x0205;
		[PreserveCase] public readonly int GEQUAL = 0x0206;
		[PreserveCase] public readonly int ALWAYS = 0x0207;
		[PreserveCase] public readonly int KEEP = 0x1E00;
		[PreserveCase] public readonly int REPLACE = 0x1E01;
		[PreserveCase] public readonly int INCR = 0x1E02;
		[PreserveCase] public readonly int DECR = 0x1E03;
		[PreserveCase] public readonly int INVERT = 0x150A;
		[PreserveCase] public readonly int INCR_WRAP = 0x8507;
		[PreserveCase] public readonly int DECR_WRAP = 0x8508;
		[PreserveCase] public readonly int VENDOR = 0x1F00;
		[PreserveCase] public readonly int RENDERER = 0x1F01;
		[PreserveCase] public readonly int VERSION = 0x1F02;
		[PreserveCase] public readonly int NEAREST = 0x2600;
		[PreserveCase] public readonly int LINEAR = 0x2601;
		[PreserveCase] public readonly int NEAREST_MIPMAP_NEAREST = 0x2700;
		[PreserveCase] public readonly int LINEAR_MIPMAP_NEAREST = 0x2701;
		[PreserveCase] public readonly int NEAREST_MIPMAP_LINEAR = 0x2702;
		[PreserveCase] public readonly int LINEAR_MIPMAP_LINEAR = 0x2703;
		[PreserveCase] public readonly int TEXTURE_MAG_FILTER = 0x2800;
		[PreserveCase] public readonly int TEXTURE_MIN_FILTER = 0x2801;
		[PreserveCase] public readonly int TEXTURE_WRAP_S = 0x2802;
		[PreserveCase] public readonly int TEXTURE_WRAP_T = 0x2803;
		[PreserveCase] public readonly int TEXTURE_2D = 0x0DE1;
		[PreserveCase] public readonly int TEXTURE = 0x1702;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP = 0x8513;
		[PreserveCase] public readonly int TEXTURE_BINDING_CUBE_MAP = 0x8514;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		[PreserveCase] public readonly int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		[PreserveCase] public readonly int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		[PreserveCase] public readonly int TEXTURE0 = 0x84C0;
		[PreserveCase] public readonly int TEXTURE1 = 0x84C1;
		[PreserveCase] public readonly int TEXTURE2 = 0x84C2;
		[PreserveCase] public readonly int TEXTURE3 = 0x84C3;
		[PreserveCase] public readonly int TEXTURE4 = 0x84C4;
		[PreserveCase] public readonly int TEXTURE5 = 0x84C5;
		[PreserveCase] public readonly int TEXTURE6 = 0x84C6;
		[PreserveCase] public readonly int TEXTURE7 = 0x84C7;
		[PreserveCase] public readonly int TEXTURE8 = 0x84C8;
		[PreserveCase] public readonly int TEXTURE9 = 0x84C9;
		[PreserveCase] public readonly int TEXTURE10 = 0x84CA;
		[PreserveCase] public readonly int TEXTURE11 = 0x84CB;
		[PreserveCase] public readonly int TEXTURE12 = 0x84CC;
		[PreserveCase] public readonly int TEXTURE13 = 0x84CD;
		[PreserveCase] public readonly int TEXTURE14 = 0x84CE;
		[PreserveCase] public readonly int TEXTURE15 = 0x84CF;
		[PreserveCase] public readonly int TEXTURE16 = 0x84D0;
		[PreserveCase] public readonly int TEXTURE17 = 0x84D1;
		[PreserveCase] public readonly int TEXTURE18 = 0x84D2;
		[PreserveCase] public readonly int TEXTURE19 = 0x84D3;
		[PreserveCase] public readonly int TEXTURE20 = 0x84D4;
		[PreserveCase] public readonly int TEXTURE21 = 0x84D5;
		[PreserveCase] public readonly int TEXTURE22 = 0x84D6;
		[PreserveCase] public readonly int TEXTURE23 = 0x84D7;
		[PreserveCase] public readonly int TEXTURE24 = 0x84D8;
		[PreserveCase] public readonly int TEXTURE25 = 0x84D9;
		[PreserveCase] public readonly int TEXTURE26 = 0x84DA;
		[PreserveCase] public readonly int TEXTURE27 = 0x84DB;
		[PreserveCase] public readonly int TEXTURE28 = 0x84DC;
		[PreserveCase] public readonly int TEXTURE29 = 0x84DD;
		[PreserveCase] public readonly int TEXTURE30 = 0x84DE;
		[PreserveCase] public readonly int TEXTURE31 = 0x84DF;
		[PreserveCase] public readonly int ACTIVE_TEXTURE = 0x84E0;
		[PreserveCase] public readonly int REPEAT = 0x2901;
		[PreserveCase] public readonly int CLAMP_TO_EDGE = 0x812F;
		[PreserveCase] public readonly int MIRRORED_REPEAT = 0x8370;
		[PreserveCase] public readonly int FLOAT_VEC2 = 0x8B50;
		[PreserveCase] public readonly int FLOAT_VEC3 = 0x8B51;
		[PreserveCase] public readonly int FLOAT_VEC4 = 0x8B52;
		[PreserveCase] public readonly int INT_VEC2 = 0x8B53;
		[PreserveCase] public readonly int INT_VEC3 = 0x8B54;
		[PreserveCase] public readonly int INT_VEC4 = 0x8B55;
		[PreserveCase] public readonly int BOOL = 0x8B56;
		[PreserveCase] public readonly int BOOL_VEC2 = 0x8B57;
		[PreserveCase] public readonly int BOOL_VEC3 = 0x8B58;
		[PreserveCase] public readonly int BOOL_VEC4 = 0x8B59;
		[PreserveCase] public readonly int FLOAT_MAT2 = 0x8B5A;
		[PreserveCase] public readonly int FLOAT_MAT3 = 0x8B5B;
		[PreserveCase] public readonly int FLOAT_MAT4 = 0x8B5C;
		[PreserveCase] public readonly int SAMPLER_2D = 0x8B5E;
		[PreserveCase] public readonly int SAMPLER_CUBE = 0x8B60;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
		[PreserveCase] public readonly int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
		[PreserveCase] public readonly int COMPILE_STATUS = 0x8B81;
		[PreserveCase] public readonly int LOW_FLOAT = 0x8DF0;
		[PreserveCase] public readonly int MEDIUM_FLOAT = 0x8DF1;
		[PreserveCase] public readonly int HIGH_FLOAT = 0x8DF2;
		[PreserveCase] public readonly int LOW_INT = 0x8DF3;
		[PreserveCase] public readonly int MEDIUM_INT = 0x8DF4;
		[PreserveCase] public readonly int HIGH_INT = 0x8DF5;
		[PreserveCase] public readonly int FRAMEBUFFER = 0x8D40;
		[PreserveCase] public readonly int RENDERBUFFER = 0x8D41;
		[PreserveCase] public readonly int RGBA4 = 0x8056;
		[PreserveCase] public readonly int RGB5_A1 = 0x8057;
		[PreserveCase] public readonly int RGB565 = 0x8D62;
		[PreserveCase] public readonly int DEPTH_COMPONENT16 = 0x81A5;
		[PreserveCase] public readonly int STENCIL_INDEX = 0x1901;
		[PreserveCase] public readonly int STENCIL_INDEX8 = 0x8D48;
		[PreserveCase] public readonly int DEPTH_STENCIL = 0x84F9;
		[PreserveCase] public readonly int RENDERBUFFER_WIDTH = 0x8D42;
		[PreserveCase] public readonly int RENDERBUFFER_HEIGHT = 0x8D43;
		[PreserveCase] public readonly int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
		[PreserveCase] public readonly int RENDERBUFFER_RED_SIZE = 0x8D50;
		[PreserveCase] public readonly int RENDERBUFFER_GREEN_SIZE = 0x8D51;
		[PreserveCase] public readonly int RENDERBUFFER_BLUE_SIZE = 0x8D52;
		[PreserveCase] public readonly int RENDERBUFFER_ALPHA_SIZE = 0x8D53;
		[PreserveCase] public readonly int RENDERBUFFER_DEPTH_SIZE = 0x8D54;
		[PreserveCase] public readonly int RENDERBUFFER_STENCIL_SIZE = 0x8D55;
		[PreserveCase] public readonly int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
		[PreserveCase] public readonly int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
		[PreserveCase] public readonly int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
		[PreserveCase] public readonly int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
		[PreserveCase] public readonly int COLOR_ATTACHMENT0 = 0x8CE0;
		[PreserveCase] public readonly int DEPTH_ATTACHMENT = 0x8D00;
		[PreserveCase] public readonly int STENCIL_ATTACHMENT = 0x8D20;
		[PreserveCase] public readonly int DEPTH_STENCIL_ATTACHMENT = 0x821A;
		[PreserveCase] public readonly int NONE = 0;
		[PreserveCase] public readonly int FRAMEBUFFER_COMPLETE = 0x8CD5;
		[PreserveCase] public readonly int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
		[PreserveCase] public readonly int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
		[PreserveCase] public readonly int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
		[PreserveCase] public readonly int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
		[PreserveCase] public readonly int FRAMEBUFFER_BINDING = 0x8CA6;
		[PreserveCase] public readonly int RENDERBUFFER_BINDING = 0x8CA7;
		[PreserveCase] public readonly int MAX_RENDERBUFFER_SIZE = 0x84E8;
		[PreserveCase] public readonly int INVALID_FRAMEBUFFER_OPERATION = 0x0506;
		[PreserveCase] public readonly int UNPACK_FLIP_Y_WEBGL = 0x9240;
		[PreserveCase] public readonly int UNPACK_PREMULTIPLY_ALPHA_WEBGL = 0x9241;
		[PreserveCase] public readonly int CONTEXT_LOST_WEBGL = 0x9242;
		[PreserveCase] public readonly int UNPACK_COLORSPACE_CONVERSION_WEBGL = 0x9243;
		[PreserveCase] public readonly int BROWSER_DEFAULT_WEBGL = 0x9244;

		//[WebGLHandlesContextLoss]
		public WebGLContextAttributes getContextAttributes()
		{
			return null;
		}

		//[WebGLHandlesContextLoss]
		public bool isContextLost()
		{
			return false;
		}

		public string[] getSupportedExtensions()
		{
			return new string[0];
		}

		public object getExtension(string name)
		{
			return null;
		}

		public void activeTexture(int texture)
		{
		}

		public void attachShader(WebGLProgram program, WebGLShader shader)
		{
		}

		public void bindAttribLocation(WebGLProgram program, int index, string name)
		{
		}

		public void bindBuffer(int target, WebGLBuffer buffer)
		{
		}

		public void bindFramebuffer(int target, WebGLFramebuffer framebuffer)
		{
		}

		public void bindRenderbuffer(int target, WebGLRenderbuffer renderbuffer)
		{
		}

		public void bindTexture(int target, WebGLTexture texture)
		{
		}

		public void blendColor(float red, float green, float blue, float alpha)
		{
		}

		public void blendEquation(int mode)
		{
		}

		public void blendEquationSeparate(int modeRGB, int modeAlpha)
		{
		}

		public void blendFunc(int sfactor, int dfactor)
		{
		}

		public void blendFuncSeparate(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
		}

		public void bufferData(int target, int size, int usage)
		{
		}

		public void bufferData(int target, ArrayBufferView data, int usage)
		{
		}

		public void bufferData(int target, ArrayBuffer data, int usage)
		{
		}

		public void bufferSubData(int target, int offset, ArrayBufferView data)
		{
		}

		public void bufferSubData(int target, int offset, ArrayBuffer data)
		{
		}

		//[WebGLHandlesContextLoss]
		public int checkFramebufferStatus(int target)
		{
			return 0;
		}

		public void clear(int mask)
		{
		}

		public void clearColor(float red, float green, float blue, float alpha)
		{
		}

		public void clearDepth(float depth)
		{
		}

		public void clearStencil(int s)
		{
		}

		public void colorMask(bool red, bool green, bool blue, bool alpha)
		{
		}

		public void compileShader(WebGLShader shader)
		{
		}

		public void compressedTexImage2D(int target, int level, int internalformat, int width,
		                                 int height, int border, ArrayBufferView data)
		{
		}

		public void compressedTexSubImage2D(int target, int level, int xoffset, int yoffset,
		                                    int width, int height, int format, ArrayBufferView data)
		{
		}

		public void copyTexImage2D(int target, int level, int internalformat, int x, int y, int width,
		                           int height, int border)
		{
		}

		public void copyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y,
		                              int width, int height)
		{
		}

		public WebGLBuffer createBuffer()
		{
			return new WebGLBuffer();
		}

		public WebGLFramebuffer createFramebuffer()
		{
			return new WebGLFramebuffer();
		}

		public WebGLProgram createProgram()
		{
			return new WebGLProgram();
		}

		public WebGLRenderbuffer createRenderbuffer()
		{
			return new WebGLRenderbuffer();
		}

		public WebGLShader createShader(int type)
		{
			return new WebGLShader();
		}

		public WebGLTexture createTexture()
		{
			return new WebGLTexture();
		}

		public void cullFace(int mode)
		{
		}

		public void deleteBuffer(WebGLBuffer buffer)
		{
		}

		public void deleteFramebuffer(WebGLFramebuffer framebuffer)
		{
		}

		public void deleteProgram(WebGLProgram program)
		{
		}

		public void deleteRenderbuffer(WebGLRenderbuffer renderbuffer)
		{
		}

		public void deleteShader(WebGLShader shader)
		{
		}

		public void deleteTexture(WebGLTexture texture)
		{
		}

		public void depthFunc(int func)
		{
		}

		public void depthMask(bool flag)
		{
		}

		public void depthRange(float zNear, float zFar)
		{
		}

		public void detachShader(WebGLProgram program, WebGLShader shader)
		{
		}

		public void disable(int cap)
		{
		}

		public void disableVertexAttribArray(int index)
		{
		}

		public void drawArrays(int mode, int first, int count)
		{
		}

		public void drawElements(int mode, int count, int type, int offset)
		{
		}

		public void enable(int cap)
		{
		}

		public void enableVertexAttribArray(int index)
		{
		}

		public void finish()
		{
		}

		public void flush()
		{
		}

		public void framebufferRenderbuffer(int target, int attachment, int renderbuffertarget,
		                                    WebGLRenderbuffer renderbuffer)
		{
		}

		public void framebufferTexture2D(int target, int attachment, int textarget,
		                                 WebGLTexture texture, int level)
		{
		}

		public void frontFace(int mode)
		{
		}

		public void generateMipmap(int target)
		{
		}

		public WebGLActiveInfo getActiveAttrib(WebGLProgram program, int index)
		{
			return new WebGLActiveInfo();
		}

		public WebGLActiveInfo getActiveUniform(WebGLProgram program, int index)
		{
			return new WebGLActiveInfo();
		}

		public WebGLShader[] getAttachedShaders(WebGLProgram program)
		{
			return new WebGLShader[0];
		}

		//[WebGLHandlesContextLoss]
		public int getAttribLocation(WebGLProgram program, string name)
		{
			return 0;
		}

		public object getBufferParameter(int target, int pname)
		{
			return null;
		}

		public object getParameter(int pname)
		{
			return null;
		}

		//[WebGLHandlesContextLoss]
		public int getError()
		{
			return 0;
		}

		public object getFramebufferAttachmentParameter(int target, int attachment, int pname)
		{
			return null;
		}

		public object getProgramParameter(WebGLProgram program, int pname)
		{
			return null;
		}

		public string getProgramInfoLog(WebGLProgram program)
		{
			return "";
		}

		public object getRenderbufferParameter(int target, int pname)
		{
			return null;
		}

		public object getShaderParameter(WebGLShader shader, int pname)
		{
			return null;
		}

		public WebGLShaderPrecisionFormat getShaderPrecisionFormat(int shadertype, int precisiontype)
		{
			return new WebGLShaderPrecisionFormat();
		}

		public string getShaderInfoLog(WebGLShader shader)
		{
			return "";
		}

		public string getShaderSource(WebGLShader shader)
		{
			return "";
		}

		public object getTexParameter(int target, int pname)
		{
			return null;
		}

		public object getUniform(WebGLProgram program, WebGLUniformLocation location)
		{
			return null;
		}

		public WebGLUniformLocation getUniformLocation(WebGLProgram program, string name)
		{
			return new WebGLUniformLocation();
		}

		public object getVertexAttrib(int index, int pname)
		{
			return null;
		}

		//[WebGLHandlesContextLoss]
		public int getVertexAttribOffset(int index, int pname)
		{
			return 0;
		}

		public void hint(int target, int mode)
		{
		}

		//[WebGLHandlesContextLoss]
		public bool isBuffer(WebGLBuffer buffer)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isEnabled(int cap)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isFramebuffer(WebGLFramebuffer framebuffer)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isProgram(WebGLProgram program)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isRenderbuffer(WebGLRenderbuffer renderbuffer)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isShader(WebGLShader shader)
		{
			return false;
		}

		//[WebGLHandlesContextLoss]
		public bool isTexture(WebGLTexture texture)
		{
			return false;
		}

		public void lineWidth(float width)
		{
		}

		public void linkProgram(WebGLProgram program)
		{
		}

		public void pixelStorei(int pname, int param)
		{
		}

		public void polygonOffset(float factor, float units)
		{
		}

		public void readPixels(int x, int y, int width, int height, int format, int type,
		                       ArrayBufferView pixels)
		{
		}

		public void renderbufferStorage(int target, int internalformat, int width, int height)
		{
		}

		public void sampleCoverage(float value, bool invert)
		{
		}

		public void scissor(int x, int y, int width, int height)
		{
		}

		public void shaderSource(WebGLShader shader, string source)
		{
		}

		public void stencilFunc(int func, int value, int mask)
		{
		}

		public void stencilFuncSeparate(int face, int func, int value, int mask)
		{
		}

		public void stencilMask(int mask)
		{
		}

		public void stencilMaskSeparate(int face, int mask)
		{
		}

		public void stencilOp(int fail, int zfail, int zpass)
		{
		}

		public void stencilOpSeparate(int face, int fail, int zfail, int zpass)
		{
		}

		public void texImage2D(int target, int level, int internalformat, int width, int height,
		                       int border, int format, int type, ArrayBufferView pixels)
		{
		}

		public void texImage2D(int target, int level, int internalformat, int format, int type,
		                       ImageData pixels)
		{
		}

		public void texImage2D(int target, int level, int internalformat, int format, int type,
		                       ImageElement image)
		{
		}

		// May throw DOMException
		public void texImage2D(int target, int level, int internalformat, int format, int type,
		                       CanvasElement canvas)
		{
		}

		// TODO
		//// May throw DOMException
		//public void texImage2D(int target, int level, int internalformat, int format, int type,
		//	VideoElement video) { }

		// May throw DOMException

		public void texParameterf(int target, int pname, float param)
		{
		}

		public void texParameteri(int target, int pname, int param)
		{
		}

		public void texSubImage2D(int target, int level, int xoffset, int yoffset, int width,
		                          int height, int format, int type, ArrayBufferView pixels)
		{
		}

		public void texSubImage2D(int target, int level, int xoffset, int yoffset, int format,
		                          int type, ImageData pixels)
		{
		}

		public void texSubImage2D(int target, int level, int xoffset, int yoffset, int format,
		                          int type, ImageElement image)
		{
		}

		// May throw DOMException
		public void texSubImage2D(int target, int level, int xoffset, int yoffset, int format,
		                          int type, CanvasElement canvas)
		{
		}

		// TODO
		//// May throw DOMException
		//public void texSubImage2D(int target, int level, int xoffset, int yoffset, int format,
		//	int type, VideoElement video) { }

		// May throw DOMException

		public void uniform1f(WebGLUniformLocation location, float x)
		{
		}

		public void uniform1fv(WebGLUniformLocation location, Float32Array v)
		{
		}

		public void uniform1fv(WebGLUniformLocation location, float[] v)
		{
		}

		public void uniform1i(WebGLUniformLocation location, int x)
		{
		}

		public void uniform1iv(WebGLUniformLocation location, Int32Array v)
		{
		}

		public void uniform1iv(WebGLUniformLocation location, int[] v)
		{
		}

		public void uniform2f(WebGLUniformLocation location, float x, float y)
		{
		}

		public void uniform2fv(WebGLUniformLocation location, Float32Array v)
		{
		}

		public void uniform2fv(WebGLUniformLocation location, float[] v)
		{
		}

		public void uniform2i(WebGLUniformLocation location, int x, int y)
		{
		}

		public void uniform2iv(WebGLUniformLocation location, Int32Array v)
		{
		}

		public void uniform2iv(WebGLUniformLocation location, int[] v)
		{
		}

		public void uniform3f(WebGLUniformLocation location, float x, float y, float z)
		{
		}

		public void uniform3fv(WebGLUniformLocation location, Float32Array v)
		{
		}

		public void uniform3fv(WebGLUniformLocation location, float[] v)
		{
		}

		public void uniform3i(WebGLUniformLocation location, int x, int y, int z)
		{
		}

		public void uniform3iv(WebGLUniformLocation location, Int32Array v)
		{
		}

		public void uniform3iv(WebGLUniformLocation location, int[] v)
		{
		}

		public void uniform4f(WebGLUniformLocation location, float x, float y, float z, float w)
		{
		}

		public void uniform4fv(WebGLUniformLocation location, Float32Array v)
		{
		}

		public void uniform4fv(WebGLUniformLocation location, float[] v)
		{
		}

		public void uniform4i(WebGLUniformLocation location, int x, int y, int z, int w)
		{
		}

		public void uniform4iv(WebGLUniformLocation location, Int32Array v)
		{
		}

		public void uniform4iv(WebGLUniformLocation location, int[] v)
		{
		}

		public void uniformMatrix2fv(WebGLUniformLocation location, bool transpose,
		                             Float32Array value)
		{
		}

		public void uniformMatrix2fv(WebGLUniformLocation location, bool transpose, float[] value)
		{
		}

		public void uniformMatrix3fv(WebGLUniformLocation location, bool transpose,
		                             Float32Array value)
		{
		}

		public void uniformMatrix3fv(WebGLUniformLocation location, bool transpose, float[] value)
		{
		}

		public void uniformMatrix4fv(WebGLUniformLocation location, bool transpose,
		                             Float32Array value)
		{
		}

		public void uniformMatrix4fv(WebGLUniformLocation location, bool transpose, float[] value)
		{
		}

		public void useProgram(WebGLProgram program)
		{
		}

		public void validateProgram(WebGLProgram program)
		{
		}

		public void vertexAttrib1f(int indx, float x)
		{
		}

		public void vertexAttrib1fv(int indx, Float32Array values)
		{
		}

		public void vertexAttrib1fv(int indx, float[] values)
		{
		}

		public void vertexAttrib2f(int indx, float x, float y)
		{
		}

		public void vertexAttrib2fv(int indx, Float32Array values)
		{
		}

		public void vertexAttrib2fv(int indx, float[] values)
		{
		}

		public void vertexAttrib3f(int indx, float x, float y, float z)
		{
		}

		public void vertexAttrib3fv(int indx, Float32Array values)
		{
		}

		public void vertexAttrib3fv(int indx, float[] values)
		{
		}

		public void vertexAttrib4f(int indx, float x, float y, float z, float w)
		{
		}

		public void vertexAttrib4fv(int indx, Float32Array values)
		{
		}

		public void vertexAttrib4fv(int indx, float[] values)
		{
		}

		public void vertexAttribPointer(int indx, int size, int type, bool normalized, int stride,
		                                int offset)
		{
		}

		public void viewport(int x, int y, int width, int height)
		{
		}
	}
}
