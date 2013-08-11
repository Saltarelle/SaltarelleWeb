using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.CSharp {
	[Flags]
	public enum MemberModifiers {
		None,
		Static = 1,
		New    = 2,
		Const  = 4,
	}
}
