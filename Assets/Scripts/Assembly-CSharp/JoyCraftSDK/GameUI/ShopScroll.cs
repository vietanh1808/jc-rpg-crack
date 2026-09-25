using System.Collections.Generic;
using _0024k;
using EnhancedUI.EnhancedScroller;

namespace JoyCraftSDK.GameUI
{
	public class ShopScroll : AScroll
	{
		private List<_0024rD> _0024LO;

		private float[] _0024mO;

		public void _0024SQ(List<_0024rD> _1)
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
