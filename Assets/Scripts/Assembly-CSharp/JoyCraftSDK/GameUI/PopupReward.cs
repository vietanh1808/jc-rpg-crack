using System;
using System.Collections.Generic;
using _0024k;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PopupReward : JUIPanel
	{
		[SerializeField]
		private ARewardVisualConfig _rewardVisualConfig;

		[SerializeField]
		private RewardItemView _rewardItemTemplate;

		[SerializeField]
		private Transform _rewardRowTemplate;

		[SerializeField]
		private Transform _rewardItemContainer;

		[SerializeField]
		private GameObject _claimHideRoot;

		[SerializeField]
		private float _itemPopDuration;

		[SerializeField]
		private float _itemPopStagger;

		[SerializeField]
		private EasingType _itemPopEasing;

		private readonly List<RewardItemView> _0024RN;

		private readonly List<Transform> _0024sN;

		private Action _0024SN;

		private bool _0024tN;

		private int _0024TN;

		public override UIPanelID _0024dgA()
		{
			return UIPanelID.None;
		}

		public void _0024xP(List<_0024kD> _1, Action _1 = null)
		{
		}

		public void _0024XP()
		{
		}

		public override void _0024ngA()
		{
		}

		private void _0024yP()
		{
		}

		private void _0024YP()
		{
		}

		private List<_0024kD> _0024zP(List<_0024kD> _1)
		{
			return null;
		}

		private void _0024ZP()
		{
		}
	}
}
