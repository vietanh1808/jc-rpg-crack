using EnhancedUI.EnhancedScroller;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JPagesScrollVertical : JPagesScrollBase
	{
		protected override EnhancedScroller.ScrollDirectionEnum _0024a => _0024HGA();

		protected override EnhancedScroller.ScrollDirectionEnum _0024HGA()
		{
			return EnhancedScroller.ScrollDirectionEnum.Vertical;
		}

		protected override float _0024iGA(Vector2 _1)
		{
			return 0f;
		}

		protected override int _0024IGA(float _1)
		{
			return 0;
		}
	}
}
