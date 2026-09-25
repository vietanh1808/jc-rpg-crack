using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class HomeTabBtn : JTabBtn
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

		private Sequence _0024gN;

		private Vector2 _0024GN;

		private bool _0024hN;

		protected override void OnDestroy()
		{
		}

		private void _0024iP()
		{
		}

		public override void Awake()
		{
		}

		public override void OnDeselect()
		{
		}

		public override void OnSelect()
		{
		}

		public override void _0024mGA(ATabPage _1)
		{
		}

		private void _0024IP()
		{
		}

		private void _0024jP()
		{
		}
	}
}
