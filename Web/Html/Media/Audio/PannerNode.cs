// PannerNode.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	/// <summary>
	/// This interface represents a processing node which positions / spatializes an incoming 
	/// audio stream in three-dimensional space. The spatialization is in relation to the 
	/// AudioContext's AudioListener (listener attribute).
	/// </summary>
	/// <reference>http://www.w3.org/TR/2012/WD-webaudio-20121213/#PannerNode</reference>
	[IgnoreNamespace, Imported]
	public class PannerNode : AudioNode {
		private PannerNode() {
		}

		/// <summary>
		/// A parameter for directional audio sources, this is an angle, inside of which there
		/// will be no volume reduction. The default value is 360.
		/// </summary>
		[IntrinsicProperty]
		public float ConeInnerAngle { get; set; }

		/// <summary>
		/// A parameter for directional audio sources, this is an angle, outside of which the 
		/// volume will be reduced to a constant value of coneOuterGain. The default value is 360.
		/// </summary>
		[IntrinsicProperty]
		public float ConeOuterAngle { get; set; }

		/// <summary>
		/// A parameter for directional audio sources, this is the amount of volume reduction 
		/// outside of the coneOuterAngle. The default value is 0.
		/// </summary>
		[IntrinsicProperty]
		public float ConeOuterGain { get; set; }

		/// <summary>
		/// Determines which algorithm will be used to reduce the volume of an audio source 
		/// as it moves away from the listener. The default is DistanceModelType.Inverse.
		/// </summary>
		[IntrinsicProperty]
		public DistanceModelType DistanceModel { get; set; }

		/// <summary>
		/// The maximum distance between source and listener, after which the volume will not 
		/// be reduced any further. The default value is 10000.
		/// </summary>
		[IntrinsicProperty]
		public float MaxDistance { get; set; }

		/// <summary>
		/// Determines which spatialization algorithm will be used to position the audio in 
		/// 3D space. The default is PanningModelType.HRTF.
		/// </summary>
		[IntrinsicProperty]
		public PanningModelType PanningModel { get; set; }

		/// <summary>
		/// A reference distance for reducing volume as source move further from the listener. 
		/// The default value is 1.
		/// </summary>
		[IntrinsicProperty]
		public float RefDistance { get; set; }

		/// <summary>
		/// Describes how quickly the volume is reduced as source moves away from listener. 
		/// The default value is 1.
		/// </summary>
		[IntrinsicProperty]
		public float RolloffFactor { get; set; }

		/// <summary>
		/// Describes which direction the audio source is pointing in the 3D cartesian 
		/// coordinate space. Depending on how directional the sound is (controlled by the 
		/// cone attributes), a sound pointing away from the listener can be very quiet or 
		/// completely silent.
		/// </summary>
		/// <param name="x">The x parameter represents the X component of a direction vector in 3D space.</param>
		/// <param name="y">The y parameter represents the Y component of a direction vector in 3D space.</param>
		/// <param name="z">The z parameter represents the Z component of a direction vector in 3D space.</param>
		public void SetOrientation(float x, float y, float z) {
		}

		/// <summary>
		/// Sets the position of the audio source relative to the listener attribute. A 3D 
		/// cartesian coordinate system is used.
		/// </summary>
		/// <param name="x">The x parameter represents the X coordinate in 3D space.</param>
		/// <param name="y">The y parameter represents the Y coordinate in 3D space.</param>
		/// <param name="z">The z parameter represents the Z coordinate in 3D space.</param>
		public void SetPosition(float x, float y, float z) {
		}

		/// <summary>
		/// Sets the velocity vector of the audio source. This vector controls both the direction 
		/// of travel and the speed in 3D space. This velocity relative to the listener's velocity 
		/// is used to determine how much doppler shift (pitch change) to apply. The units used for 
		/// this vector is meters / second and is independent of the units used for position 
		/// and orientation vectors.
		/// </summary>
		/// <param name="x">The x parameter describes the X component of a direction vector indicating 
		/// direction of travel and intensity.</param>
		/// <param name="y">The y parameter describes the Y component of a direction vector indicating 
		/// direction of travel and intensity.</param>
		/// <param name="z">The z parameter describes the Z component of a direction vector indicating 
		/// direction of travel and intensity.</param>
		public void SetVelocity(float x, float y, float z) {
		}
	}
}