using System;
using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.Progression;

namespace _0024G
{
	public class _0024ne : _0024YD
	{
		[CompilerGenerated]
		private readonly string _0024wK;

		[CompilerGenerated]
		private readonly StatKey _0024WK;

		[CompilerGenerated]
		private readonly StatOp _0024xK;

		[CompilerGenerated]
		private readonly _0024gd _0024XK;

		[CompilerGenerated]
		private readonly int _0024yK;

		[CompilerGenerated]
		private readonly bool _0024YK;

		public new string _0024a => _0024lj();

		public new StatKey _0024A => _0024Lj();

		public new StatOp _0024b => _0024mj();

		public new _0024gd _0024B => _0024EJ();

		public new int _0024c => _0024sJ();

		public new bool _0024C => _0024SJ();

		public string _0024lj()
		{
			return null;
		}

		public StatKey _0024Lj()
		{
			return StatKey.Atk;
		}

		public StatOp _0024mj()
		{
			return StatOp.Flat;
		}

		public _0024gd _0024EJ()
		{
			return null;
		}

		public int _0024sJ()
		{
			return 0;
		}

		public bool _0024SJ()
		{
			return false;
		}

		public _0024ne(string layerId, StatKey statKey, StatOp op, _0024gd source, int order, bool ownsSource = false)
		{
		}
	}
	public class _0024NE : _0024YD, _0024gd, IDisposable
	{
		private readonly _0024Fd _0024El;

		private readonly float _0024fl;

		private readonly _0024Kd _0024Fl;

		private bool _0024gl;

		[CompilerGenerated]
		private readonly StatKey _0024il;

		[CompilerGenerated]
		private Action _0024Il;

		public new StatKey _0024a => _0024rk();

		public new int _0024A => _0024XjA();

		public new event Action _0024b
		{
			add
			{
				_0024yjA(value);
			}
			remove
			{
				_0024YjA(value);
			}
		}

		public StatKey _0024rk()
		{
			return StatKey.Atk;
		}

		public _0024NE(_0024Fd profile, StatKey refKey, float refBaseValue, _0024Kd ctx)
		{
		}

		public float _0024xjA()
		{
			return 0f;
		}

		public int _0024XjA()
		{
			return 0;
		}

		public void _0024yjA(Action _1)
		{
		}

		public void _0024YjA(Action _1)
		{
		}

		private void _0024JK(StatKey _1)
		{
		}

		public void Dispose()
		{
		}
	}
}
