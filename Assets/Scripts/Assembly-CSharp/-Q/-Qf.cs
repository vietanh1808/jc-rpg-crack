using System.Runtime.CompilerServices;
using _0024l;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace _0024q
{
	public sealed class _0024Qf : _0024YD
	{
		[CompilerGenerated]
		private readonly RegenResourceType _0024eS;

		[CompilerGenerated]
		private readonly AnalyticsResource _0024ES;

		public new RegenResourceType _0024a => _0024kIA();

		public new AnalyticsResource _0024A => _0024KIA();

		public RegenResourceType _0024kIA()
		{
			return RegenResourceType.None;
		}

		public AnalyticsResource _0024KIA()
		{
			return AnalyticsResource.Coin;
		}

		public _0024Qf(RegenResourceType type, AnalyticsResource resource)
		{
		}
	}
}
