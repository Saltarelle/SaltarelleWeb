using System.Runtime.CompilerServices;

namespace System.Html.Media.Audio {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class PannerNode : AudioNode {
		internal PannerNode() {
		}

		[IntrinsicProperty]
		public double ConeInnerAngle {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double ConeOuterAngle {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double ConeOuterGain {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public DistanceModelType DistanceModel {
			get { return default(DistanceModelType); }
			set { }
		}

		public const ushort EQUALPOWER = 0;

		[ScriptName("EXPONENTIAL_DISTANCE")]
		public const ushort EXPONENTIAL_DISTANCE = 2;

		public const ushort HRTF = 1;

		[ScriptName("INVERSE_DISTANCE")]
		public const ushort INVERSE_DISTANCE = 1;

		[ScriptName("LINEAR_DISTANCE")]
		public const ushort LINEAR_DISTANCE = 0;

		[IntrinsicProperty]
		public double MaxDistance {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public PanningModelType PanningModel {
			get { return default(PanningModelType); }
			set { }
		}

		[IntrinsicProperty]
		public double RefDistance {
			get { return 0; }
			set { }
		}

		[IntrinsicProperty]
		public double RolloffFactor {
			get { return 0; }
			set { }
		}

		public void SetOrientation(double x, double y, double z) {
		}

		public void SetPosition(double x, double y, double z) {
		}

		public void SetVelocity(double x, double y, double z) {
		}
	}
}
