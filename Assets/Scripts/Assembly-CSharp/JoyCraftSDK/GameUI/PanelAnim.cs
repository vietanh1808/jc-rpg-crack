using _0024l;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.GameUI
{
	public class PanelAnim : APanelAnim
	{
		[Space]
		[Header("Others")]
		public bool unscaleTime;

		[SerializeField]
		public RectTransform popup;

		public CanvasGroup rootGraphic;

		private Vector3 _0024Ym;

		private _0024ie _0024zm;

		private CanvasGroup _0024Zm;

		[Header("Anim In")]
		public AnimInType animIn;

		public UnityEvent animInCompletedEvent;

		public float animInTime;

		public float delayAnimIn;

		public float initScale;

		public bool separateAxisAnimIn;

		public EasingType animInEasingType;

		public AnimationCurve animInCurve;

		public EasingType animInXAxisEasingType;

		public AnimationCurve animInXAxisCurve;

		public EasingType animInYAxisEasingType;

		public AnimationCurve animInYAxisCurve;

		[Space]
		[Header("Anim Out")]
		public AnimOutType animOut;

		public UnityEvent animOutCompletedEvent;

		public float animOutTime;

		public float targetScale;

		public bool separateAxisAnimOut;

		public EasingType animOutEasingType;

		public AnimationCurve animOutCurve;

		public EasingType animOutXAxisEasingType;

		public AnimationCurve animOutXAxisCurve;

		public EasingType animOutYAxisEasingType;

		public AnimationCurve animOutYAxisCurve;

		private new bool _0024a => _0024uM();

		private new bool _0024A => _0024wM();

		private new bool _0024b => _0024WM();

		private new bool _0024B => _0024xM();

		private new bool _0024c => _0024XM();

		private new bool _0024C => _0024yM();

		private new bool _0024d => _0024YM();

		private new bool _0024D => _0024zM();

		private new bool _0024e => _0024ZM();

		private new bool _0024E => _0024an();

		private new bool _0024f => _0024An();

		private bool _0024uM()
		{
			return false;
		}

		private void OnValidate()
		{
		}

		public override void _0024IgA(_0024ie _1)
		{
		}

		public override void _0024jgA()
		{
		}

		public override void _0024JgA()
		{
		}

		public override void _0024kgA()
		{
		}

		public override void _0024KgA()
		{
		}

		public override bool _0024lgA()
		{
			return false;
		}

		private void _0024UM()
		{
		}

		private void _0024vM()
		{
		}

		private void _0024VM(Tween _1, bool _1, AnimationCurve _1, Ease _1)
		{
		}

		private bool _0024wM()
		{
			return false;
		}

		private bool _0024WM()
		{
			return false;
		}

		private bool _0024xM()
		{
			return false;
		}

		private bool _0024XM()
		{
			return false;
		}

		private bool _0024yM()
		{
			return false;
		}

		private bool _0024YM()
		{
			return false;
		}

		private bool _0024zM()
		{
			return false;
		}

		private bool _0024ZM()
		{
			return false;
		}

		private bool _0024an()
		{
			return false;
		}

		private bool _0024An()
		{
			return false;
		}
	}
}
