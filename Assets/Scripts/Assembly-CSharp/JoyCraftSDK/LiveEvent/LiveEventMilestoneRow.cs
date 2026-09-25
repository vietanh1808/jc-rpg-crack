using System;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	[Serializable]
	public class LiveEventMilestoneRow
	{
		[Tooltip("Bậc trên track — hàng render tăng dần theo số này (KHÔNG theo thứ tự trong list). Phải > 0 và không trùng hàng khác.")]
		[SerializeField]
		private int tier;

		[Tooltip("Ô cột FREE của bậc này. Để milestoneId = 0 nghĩa là bậc KHÔNG có mốc free (hợp lệ).")]
		[SerializeField]
		private LiveEventMilestoneEntry freeEntry;

		[Tooltip("Ô cột PREMIUM của bậc này. Để milestoneId = 0 nghĩa là bậc KHÔNG có mốc premium (hợp lệ).")]
		[SerializeField]
		private LiveEventMilestoneEntry premiumEntry;

		public int Tier => _0024yf();

		public LiveEventMilestoneEntry FreeEntry => _0024Yf();

		public LiveEventMilestoneEntry PremiumEntry => _0024zf();

		public string RowLabel => _0024Zf();

		public LiveEventMilestoneRow()
		{
		}

		public LiveEventMilestoneRow(int tier)
		{
		}

		public int _0024yf()
		{
			return 0;
		}

		public LiveEventMilestoneEntry _0024Yf()
		{
			return null;
		}

		public LiveEventMilestoneEntry _0024zf()
		{
			return null;
		}

		public string _0024Zf()
		{
			return null;
		}

		public bool _0024aF()
		{
			return false;
		}

		public bool _0024AF(LiveEventMilestoneEntry _1)
		{
			return false;
		}

		private static string _0024bF(LiveEventMilestoneEntry _1)
		{
			return null;
		}
	}
}
