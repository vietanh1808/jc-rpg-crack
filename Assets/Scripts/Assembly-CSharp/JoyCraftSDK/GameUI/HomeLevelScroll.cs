using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class HomeLevelScroll : AScroll
	{
		[SerializeField]
		private LevelRoomCellView cellPrefab;

		[SerializeField]
		private float cellSize;

		[SerializeField]
		private int levelCount;

		private new int _0024a => _0024fP();

		private int _0024fP()
		{
			return 0;
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024FP(ref AEventManager._0024tb _1)
		{
		}

		private void _0024gP()
		{
		}

		private void _0024GP()
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
