using System;
using System.Runtime.CompilerServices;
using _0024l;
using Cysharp.Threading.Tasks;
using JoyCraftSDK;

namespace _0024g
{
	public abstract class _0024TC : _0024YD
	{
		[CompilerGenerated]
		private Action<AuthState> _0024WJ;

		public new abstract string _0024a { get; }

		public new abstract bool _0024A { get; }

		public new abstract AuthState _0024b { get; }

		public new event Action<AuthState> _0024B
		{
			add
			{
				_0024Vh(value);
			}
			remove
			{
				_0024SH(value);
			}
		}

		public abstract string _0024VIA();

		public abstract bool _0024wIA();

		public abstract AuthState _0024WIA();

		public abstract UniTask _0024xIA();

		public virtual UniTask<bool> _0024Sx()
		{
			return default;
		}

		public void _0024Vh(Action<AuthState> _1)
		{
		}

		public void _0024SH(Action<AuthState> _1)
		{
		}

		protected void _0024tH(AuthState _1)
		{
		}
	}
}
