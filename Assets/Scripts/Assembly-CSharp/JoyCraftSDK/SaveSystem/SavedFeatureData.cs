using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedFeatureData : JSaveData
	{
		[SerializeField]
		private List<SavedFeatureDataPoint> featureDataPoints;

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public void _0024aK(GameFeatureType _1)
		{
		}

		public bool _0024AK(GameFeatureType _1)
		{
			return false;
		}
	}
}
