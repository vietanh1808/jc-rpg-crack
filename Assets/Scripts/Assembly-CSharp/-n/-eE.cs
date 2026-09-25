using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace _0024N
{
	public readonly struct _0024eE
	{
		public readonly string _0024yR;

		public readonly string _0024YR;

		public readonly int _0024zR;

		public readonly float _0024ZR;

		public readonly int _0024as;

		public readonly int _0024As;

		public readonly int _0024bs;

		public readonly float _0024Bs;

		public readonly float _0024cs;

		public readonly LevelPlayType _0024Cs;

		public readonly int _0024ds;

		public readonly int _0024Ds;

		public readonly LevelFinishReason _0024es;

		public readonly LevelFailReason _0024Es;

		private readonly Dictionary<BoosterType, int> _0024fs;

		private readonly List<int> _0024Fs;

		public string _0024a => _0024lZ();

		public _0024eE(string gameMode, string sessionId, int levelId, float timeSpent, int attempts, Dictionary<BoosterType, int> boostersUsage, List<int> moveSequence, int loseIndex, int exitIndex, float durationTotalStart, float durationTotalEnd, LevelPlayType playType, int itemsTotal, int itemsCleared, LevelFinishReason reason, LevelFailReason failReason)
		{
			_0024yR = null;
			_0024YR = null;
			_0024zR = 0;
			_0024ZR = 0f;
			_0024as = 0;
			_0024As = 0;
			_0024bs = 0;
			_0024Bs = 0f;
			_0024cs = 0f;
			_0024Cs = LevelPlayType.Home;
			_0024ds = 0;
			_0024Ds = 0;
			_0024es = LevelFinishReason.None;
			_0024Es = LevelFailReason.None;
			_0024fs = null;
			_0024Fs = null;
		}

		public static _0024eE _0024kZ(string _1, string _1, int _1, float _1, int _1, int _1, int _1, float _1, LevelPlayType _1, int _1, int _1)
		{
			return default;
		}

		public int _0024KZ(BoosterType _1)
		{
			return 0;
		}

		public string _0024lZ()
		{
			return null;
		}
	}
	public readonly struct _0024EE
	{
		public readonly int _0024gs;

		public readonly int _0024Gs;

		public readonly string _0024hs;

		public readonly string _0024Hs;

		private _0024EE(int context, int levelAbandoned, string result, string loseCause)
		{
			_0024gs = 0;
			_0024Gs = 0;
			_0024hs = null;
			_0024Hs = null;
		}

		public static _0024EE _0024LZ(LevelFinishReason _1, LevelFailReason _1)
		{
			return default;
		}
	}
}
