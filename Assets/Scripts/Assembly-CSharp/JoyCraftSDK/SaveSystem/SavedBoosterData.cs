using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBoosterData : JSaveData
	{
		[SerializeField]
		private List<SavedBoosterDataPoint> boosterDataPoints;

		[NonSerialized]
		private BoosterEarnReason _0024Gl;

		[NonSerialized]
		private BoosterSpendReason _0024hl;

		[NonSerialized]
		private AnalyticsPlacement _0024Hl;

		public List<SavedBoosterDataPoint> BoosterDataPoint => _0024wk();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public List<SavedBoosterDataPoint> _0024wk()
		{
			return null;
		}

		public int _0024Wk(BoosterType _1)
		{
			return 0;
		}

		public void _0024xk(BoosterType _1, int _1)
		{
		}

		public void _0024Xk(BoosterType _1, int _1, BoosterEarnReason _1, AnalyticsPlacement _1)
		{
		}

		public void _0024yk(BoosterType _1, int _1, BoosterEarnReason _1, AnalyticsPlacement _1)
		{
		}

		public bool _0024Yk(BoosterType _1, int _1, BoosterSpendReason _1, AnalyticsPlacement _1)
		{
			return false;
		}

		public void _0024zk(BoosterType _1)
		{
		}

		public bool _0024Zk(BoosterType _1)
		{
			return false;
		}
	}
}
