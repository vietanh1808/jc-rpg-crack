using _0024C;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassMilestoneRowView : JCellView
	{
		[SerializeField]
		private BattlePassMilestoneView freeSide;

		[SerializeField]
		private BattlePassMilestoneView premiumSide;

		[Tooltip("Số BẬC của hàng (1..N) — nhãn thứ tự, KHÔNG phải giá key.")]
		[SerializeField]
		private TextMeshProUGUI tierText;

		public void _0024CO(_0024Ic _1, BattlePassRewardPreviewRouter _1)
		{
		}

		public override void RefreshCellView()
		{
		}
	}
}
