using System;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class FeatureProgressBar : JMonoBehaviour
	{
		private sealed class _0024uD
		{
			public FeatureProgressBar _0024bp;

			public float _0024Bp;

			public int _0024cp;

			public int _0024Cp;

			internal void _0024or()
			{
			}
		}

		private sealed class _0024UD
		{
			public FeatureProgressBar _0024dp;

			public Action _0024Dp;

			internal float _0024Or()
			{
				return 0f;
			}

			internal void _0024pr(float _1)
			{
			}

			internal void _0024Pr()
			{
			}
		}

		[Header("Components")]
		public TMP_Text progressTxt;

		public Image iconImg;

		public Image fillImg;

		public RectTransform punchRect;

		public ParticleSystem unlockFeatureFx;

		[Header("Animation")]
		public float playTime;

		public float delayTime;

		public float punchScale;

		public float punchTime;

		private UnlockEntry _0024Ap;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024mr()
		{
		}

		public void _0024Mr()
		{
		}

		private void _0024nr(float _1, Action _1)
		{
		}

		private void _0024Nr(float _1)
		{
		}
	}
}
