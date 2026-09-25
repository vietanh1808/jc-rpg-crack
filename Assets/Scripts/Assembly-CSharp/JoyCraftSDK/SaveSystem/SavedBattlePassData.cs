using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedBattlePassData : JSaveData
	{
		[SerializeField]
		private SavedWalletIntData savedWalletIntData;

		[SerializeField]
		private SavedTrackData savedTrackData;

		public SavedWalletIntData SavedWalletIntData => _0024bK();

		public SavedTrackData SavedTrackData => _0024BK();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public SavedWalletIntData _0024bK()
		{
			return null;
		}

		public SavedTrackData _0024BK()
		{
			return null;
		}
	}
}
