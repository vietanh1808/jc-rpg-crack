using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.SaveSystem;

namespace _0024d
{
	public class _0024gC : _0024fC
	{
		private readonly int _0024wI;

		private readonly long _0024WI;

		private new long _0024a => _0024ch();

		public _0024gC(RegenResourceType type, int maxCount, int resetValue, int resetIntervalDays, SavedRegenPoint savedRegenPoint)
			: base(RegenResourceType.None, 0, 0, null)
		{
		}

		private long _0024ch()
		{
			return 0L;
		}

		public override void _0024xDA()
		{
		}

		public override float _0024XDA()
		{
			return 0f;
		}
	}
	public class _0024GC : _0024hC
	{
		private readonly Dictionary<RegenResourceType, _0024fC> _0024xI;

		private readonly _0024HC _0024XI;

		private bool _0024yI;

		private new SavedRegenData _0024a => _0024Ch();

		private SavedRegenData _0024Ch()
		{
			return null;
		}

		private void _0024dh()
		{
		}

		public override void _0024ZDA(TimedRegenConfigPoint _1)
		{
		}

		private static int _0024Dh(TimedRegenConfigPoint _1)
		{
			return 0;
		}

		public override int _0024aeA(RegenResourceType _1)
		{
			return 0;
		}

		public override int _0024AeA(RegenResourceType _1)
		{
			return 0;
		}

		public override void _0024beA(RegenResourceType _1, int _1)
		{
		}

		public override bool _0024BeA(RegenResourceType _1, int _1)
		{
			return false;
		}

		public override float _0024ceA(RegenResourceType _1)
		{
			return 0f;
		}

		public override float _0024CeA(RegenResourceType _1)
		{
			return 0f;
		}

		public override void _0024deA(RegenResourceType _1)
		{
		}

		public override void _0024DeA(RegenResourceType _1, int _1, float _1)
		{
		}

		private _0024fC _0024eh(RegenResourceType _1)
		{
			return null;
		}
	}
}
