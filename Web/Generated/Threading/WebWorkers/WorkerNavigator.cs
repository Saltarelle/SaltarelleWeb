// WorkerNavigator.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
// 

using System.Runtime.CompilerServices;

namespace System.Threading.WebWorkers {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WorkerNavigator {
		internal WorkerNavigator() {
		}

		[IntrinsicProperty]
		public string AppName {
			get { return null; }
		}

		[IntrinsicProperty]
		public string AppVersion {
			get { return null; }
		}

		[IntrinsicProperty]
		public string Platform {
			get { return null; }
		}

		[IntrinsicProperty]
		public string UserAgent {
			get { return null; }
		}
	}
}
