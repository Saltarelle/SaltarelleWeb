// AudioListener.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class AudioListener {
		internal AudioListener() {
		}

		[IntrinsicProperty]
		public double DopplerFactor {
			get { return 0; }
			set { }
		}

		public void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp) {
		}

		public void SetPosition(double x, double y, double z) {
		}

		public void SetVelocity(double x, double y, double z) {
		}

		[IntrinsicProperty]
		public double SpeedOfSound {
			get { return 0; }
			set { }
		}
	}
}
