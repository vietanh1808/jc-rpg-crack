using System;
using _0024l;
using JoyCraftSDK.Progression;
using JoyCraftSDK.SaveSystem;

namespace _0024G
{
	public class _0024fd : _0024Ed
	{
		protected virtual SavedCycleData _0024SjA()
		{
			return null;
		}

		protected virtual DateTime _0024tjA()
		{
			return default;
		}

		private CycleEntry _0024HI(string _1, CycleSpec _1, out bool _1)
		{
			_1 = default;
			return null;
		}

		public override bool _0024qjA(string _1, CycleSpec _1, int _1 = 1)
		{
			return false;
		}

		public override int _0024QjA(string _1, CycleSpec _1)
		{
			return 0;
		}

		public override int _0024rjA(string _1, CycleSpec _1)
		{
			return 0;
		}

		public override bool _0024RjA(string _1, CycleSpec _1)
		{
			return false;
		}

		public override DateTime _0024sjA(string _1, CycleSpec _1)
		{
			return default;
		}
	}
	public abstract class _0024Fd : _0024YD
	{
		public new abstract event Action<StatKey> _0024a;

		public abstract void _0024TjA(_0024ne _1);

		public abstract void _0024ujA(string _1);

		public abstract float _0024UjA(StatKey _1, float _1, in _0024Kd _1);

		public abstract void _0024vjA(StatKey _1, in _0024Kd _1, out float _1, out float _1);

		public abstract int _0024VjA(StatKey _1);

		public abstract void _0024wjA(Action<StatKey> _1);

		public abstract void _0024WjA(Action<StatKey> _1);
	}
}
