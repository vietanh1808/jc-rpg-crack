using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ScreenWin : JUIPanel
	{
		[SerializeField]
		private Animator winAnim;

		[SerializeField]
		private float delayWinAnim;

		[SerializeField]
		private RectTransform[] rects;

		[SerializeField]
		private GameObject[] vfx;

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		public void _0024qr()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
