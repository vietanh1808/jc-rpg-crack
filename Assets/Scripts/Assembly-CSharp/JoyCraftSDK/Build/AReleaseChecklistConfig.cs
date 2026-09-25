using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Build
{
	public abstract class AReleaseChecklistConfig : JScriptableObject
	{
		public new abstract int _0024a { get; set; }

		public new abstract int _0024A { get; set; }

		public new abstract string _0024b { get; }

		public new abstract string _0024B { get; }

		public new abstract List<AfterBuildReminder> _0024c { get; }

		public abstract int _0024piA();

		public abstract void _0024PiA(int _1);

		public abstract int _0024qiA();

		public abstract void _0024QiA(int _1);

		public abstract string _0024riA();

		public abstract string _0024RiA();

		public abstract List<AfterBuildReminder> _0024siA();
	}
}
