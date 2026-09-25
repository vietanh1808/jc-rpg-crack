using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0024B;
using _0024c;
using _0024l;
using GenericEventBus;
using JoyCraftSDK;
using JoyCraftSDK.Progression;

namespace _0024G
{
	public class _0024kd : _0024YD, _0024gd, IDisposable
	{
		private readonly _0024cc _0024rK;

		private readonly string _0024RK;

		private readonly IReadOnlyList<LadderLevelEntry> _0024sK;

		private readonly GenericEventBus<_0024dB> _0024SK;

		private int _0024tK;

		[CompilerGenerated]
		private Action _0024TK;

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

		public _0024kd(_0024cc ladder, string ladderId, IReadOnlyList<LadderLevelEntry> levels, GenericEventBus<_0024dB> eventBus)
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

		private void _0024Hj(ref AEventManager._0024rb _1)
		{
		}

		public void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	public readonly struct _0024Kd
	{
		public static readonly _0024Kd _0024uK;
	}
}
