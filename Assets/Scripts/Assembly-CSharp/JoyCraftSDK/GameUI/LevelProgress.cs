using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class LevelProgress : ALevelProgress
	{
		[SerializeField]
		private JSlider levelProgress;

		[SerializeField]
		private TextMeshProUGUI levelTxt;

		[SerializeField]
		private LevelProgressConfig config;

		[SerializeField]
		private RectTransform deadIcon;

		[SerializeField]
		private RectTransform normalIcon;

		private Tween _0024xn;

		private float _0024Xn;

		private new Slider _0024a => _0024ip();

		private Slider _0024ip()
		{
			return null;
		}

		private void _0024Ip(ref AEventManager._0024tA _1)
		{
		}

		private void _0024jp(ref AEventManager._0024UA _1)
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024Jp()
		{
		}

		protected override void OnEnable()
		{
		}

		private void OnValidate()
		{
		}
	}
}
