using System;
using System.Collections.Generic;
using _0024h;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class RewardTrackEntry : _0024YD, _0024jd
	{
		[SerializeField]
		private string trackId;

		[SerializeField]
		private List<int> claimedMilestoneIds;

		[SerializeField]
		private bool premiumUnlocked;

		public string TrackId => _0024OK();

		public IReadOnlyList<int> ClaimedMilestoneIds => _0024pK();

		public bool PremiumUnlocked => _0024PK();

		public string _0024OK()
		{
			return null;
		}

		public IReadOnlyList<int> _0024pK()
		{
			return null;
		}

		public bool _0024PK()
		{
			return false;
		}

		internal RewardTrackEntry _0024qK(string _1)
		{
			return null;
		}

		public bool _0024mfA(int _1)
		{
			return false;
		}

		public void _0024MfA(int _1)
		{
		}

		public void _0024QK(bool _1)
		{
		}

		public void _0024rK()
		{
		}
	}
}
