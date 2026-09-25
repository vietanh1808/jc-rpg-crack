using System.Collections.Generic;
using JoyCraftSDK;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.SaveSystem;

namespace _0024C
{
	public class _0024ec : _0024Ec
	{
		private bool _0024yh;

		private _0024gc _0024Yh;

		private _0024kc _0024zh;

		private _0024ic _0024Zh;

		private new SavedBattlePassData _0024a => _0024Df();

		private new ABattlePassConfig _0024A => _0024ef();

		public override string _0024b => _0024XcA();

		public override _0024kc _0024B
		{
			protected get
			{
				return _0024ycA();
			}
		}

		public override JSaveData _0024c
		{
			protected get
			{
				return _0024YcA();
			}
		}

		public override bool _0024C => _0024zcA();

		protected override bool _0024d
		{
			public get
			{
				return _0024ZcA();
			}
		}

		protected override int _0024D
		{
			public get
			{
				return _0024aCA();
			}
		}

		protected override int _0024e
		{
			public get
			{
				return _0024ACA();
			}
		}

		protected override bool _0024E
		{
			public get
			{
				return _0024bCA();
			}
		}

		protected override IReadOnlyList<LiveEventMilestoneEntry> _0024f
		{
			public get
			{
				return _0024BCA();
			}
		}

		protected override IReadOnlyList<_0024Ic> _0024F
		{
			public get
			{
				return _0024cCA();
			}
		}

		protected override string _0024g
		{
			public get
			{
				return _0024DCA();
			}
		}

		private SavedBattlePassData _0024Df()
		{
			return null;
		}

		private ABattlePassConfig _0024ef()
		{
			return null;
		}

		public override string _0024XcA()
		{
			return null;
		}

		protected override _0024kc _0024ycA()
		{
			return null;
		}

		protected override JSaveData _0024YcA()
		{
			return null;
		}

		public override bool _0024zcA()
		{
			return false;
		}

		public override bool _0024ZcA()
		{
			return false;
		}

		public override int _0024aCA()
		{
			return 0;
		}

		public override int _0024ACA()
		{
			return 0;
		}

		public override bool _0024bCA()
		{
			return false;
		}

		public override IReadOnlyList<LiveEventMilestoneEntry> _0024BCA()
		{
			return null;
		}

		public override IReadOnlyList<_0024Ic> _0024cCA()
		{
			return null;
		}

		public override _0024fc _0024CCA()
		{
			return default;
		}

		public override bool _0024dCA(int _1)
		{
			return false;
		}

		public override string _0024DCA()
		{
			return null;
		}

		public override void _0024eCA()
		{
		}

		public override void _0024ECA(int _1)
		{
		}

		public override void _0024fCA()
		{
		}

		private bool _0024Ef(string _1)
		{
			return false;
		}

		public override void _0024FCA()
		{
		}

		private void _0024ff(SavedBattlePassData _1)
		{
		}

		private void _0024Ff(ref AEventManager._0024UA _1)
		{
		}

		private void _0024gf(string _1)
		{
		}
	}
	public abstract class _0024Ec : _0024Fc
	{
		public new abstract int _0024a { get; }

		public new abstract int _0024A { get; }

		public new abstract bool _0024b { get; }

		public new abstract IReadOnlyList<LiveEventMilestoneEntry> _0024B { get; }

		public new abstract IReadOnlyList<_0024Ic> _0024c { get; }

		public new abstract string _0024C { get; }

		public abstract int _0024aCA();

		public abstract int _0024ACA();

		public abstract bool _0024bCA();

		public abstract IReadOnlyList<LiveEventMilestoneEntry> _0024BCA();

		public abstract IReadOnlyList<_0024Ic> _0024cCA();

		public abstract _0024fc _0024CCA();

		public abstract bool _0024dCA(int _1);

		public abstract string _0024DCA();

		public abstract void _0024eCA();

		public abstract void _0024ECA(int _1);

		public abstract void _0024fCA();
	}
}
