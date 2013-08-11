// AudioListener.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This interface represents the position and orientation of the person listening to the 
	/// audio scene. All PannerNode objects spatialize in relation to the AudioContext's listener.
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#AudioListener</reference>
	[IgnoreNamespace, Imported]
	public class AudioListener {
		private AudioListener() {
		}

		/// <summary>
		/// A constant used to determine the amount of pitch shift to use when rendering a doppler 
		/// effect. The default value is 1.
		/// </summary>
		[IntrinsicProperty]
		public float DopplerFactor { get; set; }

		/// <summary>
		/// Describes which direction the listener is pointing in the 3D cartesian coordinate 
		/// space. Both a front vector and an up vector are provided. In simple human terms, 
		/// the front vector represents which direction the person's nose is pointing. The up 
		/// vector represents the direction the top of a person's head is pointing. These values 
		/// are expected to be linearly independent (at right angles to each other).
		/// </summary>
		/// <param name="x">The x parameter represents the X component of a front direction vector 
		/// in 3D space, with the default value being 0.</param>
		/// <param name="y">The y parameter represents the Y component of a front direction vector 
		/// in 3D space, with the default value being 0.</param>
		/// <param name="z">The z parameter represents the Z component of a front direction vector 
		/// in 3D space, with the default value being -1.</param>
		/// <param name="xUp">The xUp parameter represents the X component of an up direction 
		/// vector in 3D space, with the default value being 0.</param>
		/// <param name="yUp">The yUp parameter represents the Y component of an up direction 
		/// vector in 3D space, with the default value being 1.</param>
		/// <param name="zUp">The zUp parameter represents the Z component of an up direction 
		/// vector in 3D space, with the default value being 0.</param>
		public void SetOrientation(float x, float y, float z, float xUp, float yUp, float zUp) {
		}

		/// <summary>
		/// Sets the position of the listener in a 3D cartesian coordinate space. PannerNode 
		/// objects use this position relative to individual audio sources for spatialization.
		/// </summary>
		/// <param name="x">The x parameter represents the X coordinate in 3D space.</param>
		/// <param name="y">The y parameter represents the Y coordinate in 3D space.</param>
		/// <param name="z">The z parameter represents the Z coordinate in 3D space.</param>
		public void SetPosition(float x, float y, float z) {
		}

		/// <summary>
		/// Sets the velocity vector of the listener. This vector controls both the direction of 
		/// travel and the speed in 3D space. This velocity relative to an audio source's velocity 
		/// is used to determine how much doppler shift (pitch change) to apply. The units used for 
		/// this vector is meters / second and is independent of the units used for position 
		/// and orientation vectors.
		/// </summary>
		/// <param name="x">The x parameter describe the X component of a direction vector 
		/// indicating direction of travel and intensity.</param>
		/// <param name="y">The y parameter describe the Y component of a direction vector 
		/// indicating direction of travel and intensity.</param>
		/// <param name="z">The z parameter describe the Z component of a direction vector 
		/// indicating direction of travel and intensity.</param>
		public void SetVelocity(float x, float y, float z) {
		}

		/// <summary>
		/// The speed of sound used for calculating doppler shift. The default value is 
		/// 343.3 meters / second.
		/// </summary>
		[IntrinsicProperty]
		public float SpeedOfSound { get; set; }
	}
}