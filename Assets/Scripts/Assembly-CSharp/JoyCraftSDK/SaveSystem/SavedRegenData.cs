using System;
using System.Collections.Generic;
using _0024h;
using JoyCraftSDK.Game;
using JoyCraftSDK.Game.SaveData;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedRegenData : JSaveData
	{
		[SerializeField]
		private List<SavedRegenPoint> regenPoints;

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public SavedRegenPoint _0024ol(RegenResourceType _1)
		{
			return null;
		}

		public bool _0024Ol(RegenResourceType _1)
		{
			return false;
		}
	}
}
