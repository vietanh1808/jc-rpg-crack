using System.Runtime.CompilerServices;
using _0024k;
using DG.Tweening;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class RewardItemView : JMonoBehaviour
	{
		private sealed class _0024mD
		{
			public RewardItemView _0024Co;

			public RewardKind _0024do;

			internal void _0024Hq(int _1)
			{
			}
		}

		[SerializeField]
		private Image _imgIcon;

		[SerializeField]
		private TextMeshProUGUI _txtAmount;

		[SerializeField]
		private CanvasGroup _flashOverlay;

		[SerializeField]
		private float _countUpDuration;

		[SerializeField]
		private float _landPunchStrength;

		[SerializeField]
		private float _landPunchDuration;

		[SerializeField]
		private float _breatheScale;

		[SerializeField]
		private float _breatheDuration;

		[CompilerGenerated]
		private _0024kD _0024bo;

		public new _0024kD _0024a
		{
			get
			{
				return _0024eq();
			}
			private set
			{
				_0024Eq(value);
			}
		}

		public new Transform _0024A => _0024fq();

		public _0024kD _0024eq()
		{
			return null;
		}

		private void _0024Eq(_0024kD _1)
		{
		}

		public Transform _0024fq()
		{
			return null;
		}

		public void _0024Fq(_0024kD _1, Sprite _1)
		{
		}

		public void _0024gq(float _1, float _1, Ease _1)
		{
		}

		private void _0024Gq()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
