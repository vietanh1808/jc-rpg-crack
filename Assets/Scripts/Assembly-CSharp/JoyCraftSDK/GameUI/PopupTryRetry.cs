using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupTryRetry : JUIPanel
	{
		[SerializeField]
		private RectTransform brokenHeartRect;

		[SerializeField]
		private RectTransform btnRect;

		[SerializeField]
		private GameObject retryBtn;

		[SerializeField]
		private GameObject quitBtn;

		[SerializeField]
		private GameObject restartBtn;

		[SerializeField]
		private TMP_Text titleTxt;

		public TMP_Text levelTxt;

		public TMP_Text description;

		private RetryState _0024So;

		private GameObject _0024to;

		public void _0024Wq(RetryState _1)
		{
		}

		public bool _0024xq()
		{
			return false;
		}

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		protected override void _0024mgA()
		{
		}

		public override void _0024MgA()
		{
		}
	}
}
