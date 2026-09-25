using System;
using System.Collections.Generic;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	[Serializable]
	public class LiveEventMilestoneEntry
	{
		[Tooltip("Id STABLE của mốc — ghi vào save khi claim; CẤM đổi/reuse sau ship.")]
		[SerializeField]
		private int milestoneId;

		[Tooltip("Mode Spend: GIÁ phải trả (trừ balance). Mode Threshold: NGƯỠNG earned phải đạt (T7 — vì thế không đặt tên cost).")]
		[SerializeField]
		private int gateValue;

		[Tooltip("Các phần thưởng của mốc. Rỗng hoặc có kind=None = entry hỏng — track chặn claim TRƯỚC khi trừ (F3).")]
		[SerializeField]
		private List<LiveEventReward> rewards;

		[Tooltip("Icon hiển thị trong Ô khi mốc có NHIỀU reward — MỖI mốc 1 sprite RIÊNG (CEO chốt 2026-08-17), KHÔNG suy từ reward nào. Mốc 1 reward: bỏ trống, icon tra RewardVisualConfig theo kind.")]
		[SerializeField]
		private Sprite multiRewardIcon;

		[HideInInspector]
		[SerializeField]
		private RewardKind kind;

		[HideInInspector]
		[SerializeField]
		private int amount;

		[HideInInspector]
		[SerializeField]
		private int tier;

		[HideInInspector]
		[SerializeField]
		private bool isPremium;

		[Tooltip("Pacing knob (T4): mốc chỉ mở khi earned CẢ MÙA ≥ giá trị này. Default 0 = TẮT.")]
		[SerializeField]
		private int unlockAtEarned;

		public int MilestoneId => _0024sf();

		public int Tier => _0024Sf();

		public int GateValue => _0024tf();

		public IReadOnlyList<LiveEventReward> Rewards => _0024Tf();

		public Sprite MultiRewardIcon => _0024uf();

		public bool IsPremium => _0024Uf();

		public int UnlockAtEarned => _0024vf();

		public bool IsAuthored => _0024Vf();

		public string SummaryLabel => _0024wf();

		public LiveEventMilestoneEntry()
		{
		}

		public LiveEventMilestoneEntry(int milestoneId, int gateValue, RewardKind kind, int amount, bool isPremium = false, int unlockAtEarned = 0, int tier = 0)
		{
		}

		public LiveEventMilestoneEntry(int milestoneId, int gateValue, List<LiveEventReward> rewards, bool isPremium = false, int unlockAtEarned = 0, int tier = 0)
		{
		}

		public int _0024sf()
		{
			return 0;
		}

		public int _0024Sf()
		{
			return 0;
		}

		public int _0024tf()
		{
			return 0;
		}

		public IReadOnlyList<LiveEventReward> _0024Tf()
		{
			return null;
		}

		public Sprite _0024uf()
		{
			return null;
		}

		public bool _0024Uf()
		{
			return false;
		}

		public int _0024vf()
		{
			return 0;
		}

		public bool _0024Vf()
		{
			return false;
		}

		public string _0024wf()
		{
			return null;
		}

		public bool _0024Wf(int _1, bool _1)
		{
			return false;
		}

		public bool _0024xf()
		{
			return false;
		}

		public bool _0024Xf()
		{
			return false;
		}
	}
}
