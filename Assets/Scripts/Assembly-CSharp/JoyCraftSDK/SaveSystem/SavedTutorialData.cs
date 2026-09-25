using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Game.SaveData;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedTutorialData : JSaveData
	{
		[SerializeField]
		private List<SavedTutorialDataPoint> tutorialDataPoints;

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public bool _0024pl(TutorialType _1)
		{
			return false;
		}

		public void _0024Pl(TutorialType _1, bool _1)
		{
		}
	}
}
