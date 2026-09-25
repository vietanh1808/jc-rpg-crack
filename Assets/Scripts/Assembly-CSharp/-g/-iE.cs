using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Progression;

namespace _0024G
{
	public class _0024iE : _0024Fd
	{
		private sealed class _0024nE
		{
			public _0024iE _0024Dl;

			public _0024ne _0024el;

			internal void _0024Qk()
			{
			}
		}

		private readonly Dictionary<StatKey, List<_0024ne>> _0024bl;

		private readonly Dictionary<StatKey, int> _0024Bl;

		private readonly Dictionary<_0024ne, Action> _0024cl;

		private readonly List<_0024gd> _0024Cl;

		[CompilerGenerated]
		private Action<StatKey> _0024dl;

		public override event Action<StatKey> _0024a
		{
			add
			{
				_0024wjA(value);
			}
			remove
			{
				_0024WjA(value);
			}
		}

		public override void _0024wjA(Action<StatKey> _1)
		{
		}

		public override void _0024WjA(Action<StatKey> _1)
		{
		}

		public override int _0024VjA(StatKey _1)
		{
			return 0;
		}

		private void _0024Nk(StatKey _1)
		{
		}

		public override void _0024TjA(_0024ne _1)
		{
		}

		public override void _0024ujA(string _1)
		{
		}

		private void _0024ok(List<_0024ne> _1)
		{
		}

		private bool _0024qk(_0024gd _1)
		{
			return false;
		}

		public override float _0024UjA(StatKey _1, float _1, in _0024Kd _1)
		{
			return 0f;
		}

		public override void _0024vjA(StatKey _1, in _0024Kd _1, out float _1, out float _1)
		{
			_1 = default;
			_1 = default;
		}
	}
}
