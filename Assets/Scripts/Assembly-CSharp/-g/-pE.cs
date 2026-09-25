using System;
using System.Runtime.CompilerServices;
using _0024B;
using _0024d;
using _0024l;
using GenericEventBus;
using JoyCraftSDK;
using JoyCraftSDK.Game;

namespace _0024G
{
	public class _0024pE : _0024YD, _0024gd, IDisposable
	{
		private readonly _0024DC _0024ml;

		private readonly BuffType _0024Ml;

		private readonly GenericEventBus<_0024dB> _0024nl;

		private int _0024Nl;

		[CompilerGenerated]
		private Action _0024ol;

		public new int _0024a => _0024XjA();

		public new event Action _0024A
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

		public _0024pE(_0024DC buffs, BuffType type, GenericEventBus<_0024dB> eventBus)
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

		private void _0024wK(ref AEventManager._0024cb _1)
		{
		}

		private void _0024WK(ref AEventManager._0024Cb _1)
		{
		}

		public void Dispose()
		{
		}
	}
}
