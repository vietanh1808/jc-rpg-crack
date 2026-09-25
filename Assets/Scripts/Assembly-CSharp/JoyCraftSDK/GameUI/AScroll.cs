using EnhancedUI.EnhancedScroller;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class AScroll : JMonoBehaviour, IEnhancedScrollerDelegate
	{
		[SerializeField]
		protected EnhancedScroller scroller;

		protected void OnValidate()
		{
		}

		protected virtual void Start()
		{
		}

		public abstract int GetNumberOfCells(EnhancedScroller scroller);

		public abstract float GetCellViewSize(EnhancedScroller scroller, int dataIndex);

		public abstract EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex);

		protected virtual void _0024fGA()
		{
		}

		public virtual void _0024FGA(int _1, bool _1 = false, bool _1 = true)
		{
		}
	}
}
