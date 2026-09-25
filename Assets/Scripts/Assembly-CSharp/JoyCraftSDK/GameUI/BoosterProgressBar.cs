using System;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class BoosterProgressBar : JMonoBehaviour
	{
		private sealed class _0024tD
		{
			public BoosterProgressBar _0024wO;

			public float _0024WO;

			public int _0024xO;

			public int _0024XO;

			internal void _0024Ir()
			{
			}
		}

		private sealed class _0024TD
		{
			public BoosterProgressBar _0024yO;

			public Action _0024YO;

			internal float _0024jr()
			{
				return 0f;
			}

			internal void _0024Jr(float _1)
			{
			}

			internal void _0024kr()
			{
			}
		}

		[SerializeField]
		private TMP_Text progressTxt;

		[SerializeField]
		private Image bgImg;

		[SerializeField]
		private Image fillImg;

		[SerializeField]
		private RectTransform punchRect;

		[SerializeField]
		private ParticleSystem unlockBoosterFx;

		[SerializeField]
		private float playTime;

		[SerializeField]
		private float delayTime;

		[SerializeField]
		private float punchScale;

		[SerializeField]
		private float punchTime;

		private UnlockEntry _0024VO;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024gr()
		{
		}

		public void _0024Gr()
		{
		}

		private void _0024hr(BoosterType _1)
		{
		}

		private void _0024Hr(float _1, Action _1)
		{
		}

		private void _0024ir(float _1)
		{
		}
	}
}
