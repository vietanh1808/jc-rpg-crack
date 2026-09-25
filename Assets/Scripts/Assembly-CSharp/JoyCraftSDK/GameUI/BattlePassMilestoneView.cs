using System.Collections.Generic;
using _0024C;
using JoyCraftSDK.LiveEvent;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassMilestoneView : JMonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Tooltip("Optional — số thứ tự mốc dạng 'MỐC #id', TÁCH khỏi cost (§4b-2). Bỏ trống nếu hàng đã hiện số bậc.")]
		[SerializeField]
		private TextMeshProUGUI milestoneIdText;

		[SerializeField]
		private TextMeshProUGUI gateValueText;

		[SerializeField]
		private TextMeshProUGUI rewardText;

		[SerializeField]
		private BtnClaimMilestone claimButton;

		[SerializeField]
		private GameObject premiumBadge;

		[SerializeField]
		private GameObject claimedMark;

		[SerializeField]
		private GameObject lockedMask;

		[Tooltip("Root bật/tắt khi hàng KHÔNG có mốc ở side này. Bỏ trống = tắt chính GameObject của view.")]
		[SerializeField]
		private GameObject contentRoot;

		[Tooltip("Icon TĨNH của ô — node 'Icon Reward' (KHÔNG phải 'IconReward' template trong RewardContainer). Sprite bơm runtime mỗi SetEntry; thiếu icon = ẩn node.")]
		[SerializeField]
		private Image rewardIcon;

		[Tooltip("Node 'Popupreward' — bảng icon của mốc NHIỀU reward. Bỏ trống = ô giữ text gộp (fallback).")]
		[SerializeField]
		private GameObject rewardPopupRoot;

		[Tooltip("'RewardContainer' (HorizontalLayoutGroup) — cha của các icon clone.")]
		[SerializeField]
		private Transform rewardIconContainer;

		[Tooltip("'IconReward' — TEMPLATE clone theo từng reward. Code tự tắt bản gốc.")]
		[SerializeField]
		private Image rewardIconTemplate;

		[Tooltip("Nguồn icon kind→sprite (RewardVisualConfig.asset, dùng chung với PopupReward).")]
		[SerializeField]
		private ARewardVisualConfig rewardVisualConfig;

		private LiveEventMilestoneEntry _0024Nn;

		private BattlePassRewardPreviewRouter _0024on;

		private bool _0024On;

		private readonly List<Image> _0024pn;

		private new _0024Ec _0024a => _0024dO();

		public new int _0024A => _0024DO();

		private _0024Ec _0024dO()
		{
			return null;
		}

		public int _0024DO()
		{
			return 0;
		}

		public void _0024eO(LiveEventMilestoneEntry _1, BattlePassRewardPreviewRouter _1)
		{
		}

		private void _0024EO(LiveEventMilestoneEntry _1)
		{
		}

		private void _0024fO(LiveEventMilestoneEntry _1)
		{
		}

		private Sprite _0024FO(LiveEventMilestoneEntry _1)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void _0024gO()
		{
		}

		public void _0024GO()
		{
		}

		private void _0024hO(IReadOnlyList<LiveEventReward> _1)
		{
		}

		private void _0024HO()
		{
		}

		private static string _0024iO(LiveEventMilestoneEntry _1)
		{
			return null;
		}

		public void _0024IO()
		{
		}

		private BattlePassMilestoneState _0024jO()
		{
			return BattlePassMilestoneState.Locked;
		}

		private void _0024JO(bool _1)
		{
		}

		private void _0024kO(GameObject _1, bool _1)
		{
		}
	}
}
