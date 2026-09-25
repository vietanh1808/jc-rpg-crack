using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.Utilities;

namespace _0024G
{
	public abstract class _0024dd : _0024YD
	{
		public abstract void _0024Nw();

		public abstract long _0024LjA(string _1);

		public abstract long _0024mjA(string _1);

		public abstract long _0024MjA(string _1);

		public abstract void _0024njA(string _1, long _1, ResourceEarnChannel _1, AnalyticsPlacement _1);

		public abstract bool _0024NjA(string _1, long _1, ResourceSpendChannel _1, AnalyticsPlacement _1);

		public abstract bool _0024ojA(IReadOnlyList<_0024Dd> _1, ResourceSpendChannel _1, AnalyticsPlacement _1);
	}
	public readonly struct _0024Dd
	{
		[CompilerGenerated]
		private readonly string _0024kK;

		[CompilerGenerated]
		private readonly long _0024KK;

		public string _0024a => _0024GI();

		public long _0024A => _0024hI();

		public string _0024GI()
		{
			return null;
		}

		public long _0024hI()
		{
			return 0L;
		}

		public _0024Dd(string currencyId, long amount)
		{
			_0024kK = null;
			_0024KK = 0L;
		}
	}
}
