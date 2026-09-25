using System;
using System.Collections.Generic;
using _0024l;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Analytics
{
	[Serializable]
	public class LevelStatsData : _0024YD
	{
		public string SessionId;

		public Dictionary<BoosterType, int> BoostersUsage;

		public List<int> MoveSequence;

		public void _0024jZ()
		{
		}
	}
}
