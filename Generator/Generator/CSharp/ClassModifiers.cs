using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.CSharp {
	[Flags]
	public enum ClassModifiers {
		None = 0,
		Static = 1,
		Partial = 2,
	}
}
