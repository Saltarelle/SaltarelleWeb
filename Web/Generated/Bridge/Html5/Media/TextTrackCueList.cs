﻿using System.Collections.Generic;

namespace Bridge.Html5.Media
{
	[Namespace("false"), External(ObeysTypeSystem = true)]
	public partial class TextTrackCueList
	{
		internal extern TextTrackCueList();

		[IndexerName("__Item"), FieldProperty]
		public VTTCue this[int index]
		{
			get;
		}

		public extern VTTCue GetCueById(string id);

		[EnumerateAsArray, Template("new {$System.ArrayEnumerator}({this})")]
		public extern IEnumerator<VTTCue> GetEnumerator();

		[FieldProperty]
		public extern int Length
		{
			get;
		}
	}
}
