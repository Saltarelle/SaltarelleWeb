﻿namespace Bridge.Html5.Media.Graphics.WebGL
{
	[Namespace("false"), External(ObeysTypeSystem = true), Name("Object")]
	public partial class WebGLExtensionVertexArray
	{
		internal extern WebGLExtensionVertexArray();

		public extern void BindVertexArrayOES(WebGLVertexArray arrayObject);

		public extern WebGLVertexArray CreateVertexArrayOES();

		public extern void DeleteVertexArrayOES(WebGLVertexArray arrayObject);

		public extern bool IsVertexArrayOES(WebGLVertexArray arrayObject);

		[FieldProperty, Name("VERTEX_ARRAY_BINDING_OES")]
		public extern int VERTEX_ARRAY_BINDING_OES
		{
			get;
		}
	}
}
