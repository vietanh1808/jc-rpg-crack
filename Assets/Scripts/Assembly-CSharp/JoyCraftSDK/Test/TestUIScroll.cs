using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class TestUIScroll : AScroll
	{
		[SerializeField]
		private EnhancedScrollerCellView testCVBtn;

		[SerializeField]
		private EnhancedScrollerCellView testCVCanvasImg;

		[SerializeField]
		private EnhancedScrollerCellView testCVSliders;

		[SerializeField]
		private EnhancedScrollerCellView testCVCheckBoxToggle;

		[SerializeField]
		private EnhancedScrollerCellView testInputFieldDropdown;

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

		private EnhancedScrollerCellView _0024ay(EnhancedScroller _1)
		{
			return null;
		}

		private EnhancedScrollerCellView _0024Ay(EnhancedScroller _1)
		{
			return null;
		}

		private EnhancedScrollerCellView _0024by(EnhancedScroller _1)
		{
			return null;
		}

		private EnhancedScrollerCellView _0024By(EnhancedScroller _1)
		{
			return null;
		}

		private EnhancedScrollerCellView _0024cy(EnhancedScroller _1)
		{
			return null;
		}
	}
}
