using System.Runtime.CompilerServices;
using JoyCraftSDK.Progression;

namespace _0024G
{
	public readonly struct _0024AE
	{
		[CompilerGenerated]
		private readonly StatKey _0024zK;

		[CompilerGenerated]
		private readonly StatOp _0024ZK;

		[CompilerGenerated]
		private readonly float _0024al;

		[CompilerGenerated]
		private readonly object _0024Al;

		public StatKey _0024a => _0024jk();

		public StatOp _0024A => _0024Jk();

		public float _0024b => _0024Mk();

		public object _0024B => _0024nk();

		public StatKey _0024jk()
		{
			return StatKey.Atk;
		}

		public StatOp _0024Jk()
		{
			return StatOp.Flat;
		}

		public float _0024Mk()
		{
			return 0f;
		}

		public object _0024nk()
		{
			return null;
		}

		public _0024AE(StatKey key, StatOp op, float value, object source)
		{
			_0024zK = StatKey.Atk;
			_0024ZK = StatOp.Flat;
			_0024al = 0f;
			_0024Al = null;
		}
	}
}
