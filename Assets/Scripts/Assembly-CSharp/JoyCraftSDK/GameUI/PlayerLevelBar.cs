using DG.Tweening;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PlayerLevelBar : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform barFill;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private float fullWidth;

		[SerializeField]
		private int stepsPerLevel;

		[SerializeField]
		private float tweenDuration;

		private int _0024rp;

		private Tween _0024Rp;

		private new int _0024a => _0024LBA();

		private new int _0024A => _0024xhA();

		private new bool _0024b => _0024XhA();

		private new float _0024B => _0024yhA();

		private int _0024LBA()
		{
			return 0;
		}

		private int _0024xhA()
		{
			return 0;
		}

		private bool _0024XhA()
		{
			return false;
		}

		private float _0024yhA()
		{
			return 0f;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void _0024YhA(int _1)
		{
		}

		private void _0024zhA(bool _1)
		{
		}

		private void _0024ZhA(float _1)
		{
		}

		private void OnValidate()
		{
		}
	}
}
