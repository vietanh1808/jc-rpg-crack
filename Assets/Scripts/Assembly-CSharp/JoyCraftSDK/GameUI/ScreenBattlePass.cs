using _0024C;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ScreenBattlePass : JUIPanel
	{
		[SerializeField]
		private BattlePassTrackScroll trackScroll;

		[Tooltip("Tiến độ MỞ tier kế dạng '{key dư}/{key cần}' — vd '0/3'. Cạnh icon key ở header.")]
		[SerializeField]
		private TextMeshProUGUI keyProgressText;

		[Tooltip("Số BẬC đang mở tới — phải khớp số hiện giữa hàng trên track.")]
		[SerializeField]
		private TextMeshProUGUI nextTierText;

		[Tooltip("DEV-ONLY (CEO chốt 2026-08-10) — 'Tổng mùa: N' = key tích lũy lái tiến độ tier. Bỏ trống = không hiện.")]
		[SerializeField]
		private TextMeshProUGUI keyEarnedText;

		[Tooltip("DEV-ONLY — 'Ví: N' = key còn tiêu được để nhận thưởng (KHÁC tử số header). Bỏ trống = không hiện.")]
		[SerializeField]
		private TextMeshProUGUI keyBalanceText;

		[SerializeField]
		private GameObject premiumOfferRoot;

		private new _0024Ec _0024a => _0024RO();

		private _0024Ec _0024RO()
		{
			return null;
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		protected override void _0024mgA()
		{
		}

		protected override void _0024tgA()
		{
		}

		protected override void _0024TgA()
		{
		}

		private void _0024sO()
		{
		}

		private void _0024SO(ref AEventManager._0024Lb _1)
		{
		}

		private void _0024tO(ref AEventManager._0024lb _1)
		{
		}

		private void _0024TO(ref AEventManager._0024mb _1)
		{
		}

		private void _0024uO(TextMeshProUGUI _1, string _1)
		{
		}

		private void _0024UO(GameObject _1, bool _1)
		{
		}
	}
}
