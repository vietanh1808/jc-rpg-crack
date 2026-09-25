using System;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class ScreenLose : JUIPanel
	{
		[Serializable]
		private enum LoseSubView
		{
			Offer = 0,
			LoseWarning = 1
		}

		[SerializeField]
		private RectTransform offerView;

		[SerializeField]
		private RectTransform loseWarningView;

		[SerializeField]
		private CanvasGroup shellGroup;

		[SerializeField]
		private GameObject warningLifeLine;

		[SerializeField]
		private AButton closeButton;

		private LoseSubView _0024LN;

		private bool _0024mN;

		[SerializeField]
		private GameObject bundleOffer;

		[SerializeField]
		private BtnBuyLoseSkipLevel bundleBuyButton;

		[SerializeField]
		private TextMeshProUGUI playOnPrice;

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		public void _0024oP()
		{
		}

		private void _0024OP()
		{
		}

		private void _0024pP()
		{
		}

		public void _0024PP(bool _1)
		{
		}

		private void _0024qP()
		{
		}

		private void _0024QP(bool _1)
		{
		}

		private float _0024rP()
		{
			return 0f;
		}

		private void _0024RP()
		{
		}

		protected override void _0024mgA()
		{
		}

		protected override void OnEnable()
		{
		}
	}
}
