using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedProgressionData : JSaveData
	{
		[SerializeField]
		private SavedCounterData savedCounterData;

		[SerializeField]
		private SavedRewardTrackData savedRewardTrackData;

		[SerializeField]
		private SavedLadderData savedLadderData;

		[SerializeField]
		private SavedCurrencyData savedCurrencyData;

		[SerializeField]
		private SavedUnlockGateData savedUnlockGateData;

		[SerializeField]
		private SavedCycleData savedCycleData;

		[SerializeField]
		private SavedBadgeData savedBadgeData;

		[SerializeField]
		private SavedIntegrityData savedIntegrityData;

		public SavedCounterData SavedCounterData => _0024cl();

		public SavedRewardTrackData SavedRewardTrackData => _0024Cl();

		public SavedLadderData SavedLadderData => _0024dl();

		public SavedCurrencyData SavedCurrencyData => _0024Dl();

		public SavedUnlockGateData SavedUnlockGateData => _0024el();

		public SavedCycleData SavedCycleData => _0024El();

		public SavedBadgeData SavedBadgeData => _0024fl();

		public SavedIntegrityData SavedIntegrityData => _0024Fl();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public SavedCounterData _0024cl()
		{
			return null;
		}

		public SavedRewardTrackData _0024Cl()
		{
			return null;
		}

		public SavedLadderData _0024dl()
		{
			return null;
		}

		public SavedCurrencyData _0024Dl()
		{
			return null;
		}

		public SavedUnlockGateData _0024el()
		{
			return null;
		}

		public SavedCycleData _0024El()
		{
			return null;
		}

		public SavedBadgeData _0024fl()
		{
			return null;
		}

		public SavedIntegrityData _0024Fl()
		{
			return null;
		}
	}
}
