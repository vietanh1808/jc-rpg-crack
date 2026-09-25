using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK;
using JoyCraftSDK.IAP;

namespace _0024k
{
	public class _0024kD : _0024YD
	{
		[CompilerGenerated]
		private readonly RewardKind _0024uN;

		[CompilerGenerated]
		private readonly int _0024UN;

		public new RewardKind _0024a => _0024aq();

		public new int _0024A => _0024Aq();

		public RewardKind _0024aq()
		{
			return RewardKind.None;
		}

		public int _0024Aq()
		{
			return 0;
		}

		public _0024kD(RewardKind kind, int amount)
		{
		}
	}
	public static class _0024KD
	{
		public static bool _0024bq(this RewardKind _1, out EffectType _1)
		{
			_1 = default;
			return false;
		}

		public static string _0024Bq(this RewardKind _1, int _1)
		{
			return null;
		}
	}
}
