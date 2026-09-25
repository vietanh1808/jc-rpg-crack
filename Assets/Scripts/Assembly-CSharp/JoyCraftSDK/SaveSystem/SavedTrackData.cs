using System;
using System.Collections.Generic;
using _0024h;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public class SavedTrackData : JSaveData, _0024Id, _0024jd
	{
		[SerializeField]
		private List<int> claimedMilestoneIds;

		[SerializeField]
		private bool premiumUnlocked;

		public IReadOnlyList<int> ClaimedMilestoneIds => _0024cK();

		public bool PremiumUnlocked => _0024CK();

		public override int _0024SEA()
		{
			return 0;
		}

		public override List<_0024Gd> _0024tEA()
		{
			return null;
		}

		public IReadOnlyList<int> _0024cK()
		{
			return null;
		}

		public bool _0024CK()
		{
			return false;
		}

		public bool _0024mfA(int _1)
		{
			return false;
		}

		public void _0024MfA(int _1)
		{
		}

		public void _0024dK()
		{
		}

		public void _0024DK(bool _1)
		{
		}

		public void _0024LfA()
		{
		}
	}
}
