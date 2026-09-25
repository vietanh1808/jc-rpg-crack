using System.Collections.Generic;
using _0024C;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class BattlePassTrackScroll : AScroll
	{
		[SerializeField]
		private BattlePassMilestoneRowView rowPrefab;

		[Tooltip("Chiều cao 1 hàng — đo lại theo prefab hàng.")]
		[SerializeField]
		private float cellSize;

		[Tooltip("Node blocker của màn (BattlePassRewardPreviewRouter). Bỏ trống = mốc nhiều reward KHÔNG bấm xem được.")]
		[SerializeField]
		private BattlePassRewardPreviewRouter previewRouter;

		private IReadOnlyList<_0024Ic> _0024qn;

		private new _0024Ec _0024a => _0024MO();

		private _0024Ec _0024MO()
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		public void _0024nO()
		{
		}

		public void _0024NO()
		{
		}

		public override int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public override float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		public override EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
