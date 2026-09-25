using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK
{
	public class JPageButtonSetup : APageButtonSetup
	{
		[SerializeField]
		private Image iconImg;

		[SerializeField]
		private Image bgImg;

		[SerializeField]
		private TMP_Text titleTxt;

		[SerializeField]
		private float animTime;

		[Range(0f, 1f)]
		[SerializeField]
		private float clickIconScalePercent;

		[SerializeField]
		private float selectedIconOffsetY;

		[SerializeField]
		private LayoutElement rootLayout;

		[SerializeField]
		private float selectedExtraFlexWidth;

		[SerializeField]
		private AnimationCurve progressCurve;

		private Sequence _0024Ph;

		private Vector2 _0024qh;

		private Vector2 _0024Qh;

		private bool _0024rh;

		private bool _0024Rh;

		private float _0024sh;

		protected override void OnDestroy()
		{
		}

		public override void _0024PcA()
		{
		}

		public override void Awake()
		{
		}

		public override void _0024qcA(float _1)
		{
		}

		public override void OnDeselect()
		{
		}

		public override void OnSelect()
		{
		}

		private void _0024yE(float _1)
		{
		}

		private void _0024YE()
		{
		}

		private void _0024vH()
		{
		}

		private void _0024zE()
		{
		}

		private void _0024ZE()
		{
		}
	}
}
