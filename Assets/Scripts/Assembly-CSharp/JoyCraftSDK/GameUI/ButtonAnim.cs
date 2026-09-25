using System;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(Button), typeof(CanvasGroup))]
	public class ButtonAnim : AButtonAnim
	{
		[Serializable]
		public enum ShowAnimType
		{
			None = 0,
			FadeIn = 1,
			FromScale = 2
		}

		[Serializable]
		public enum PressAnimType
		{
			None = 0,
			Scale = 1,
			FaceScale = 2
		}

		[Serializable]
		public enum HideAnimType
		{
			None = 0,
			FadeOut = 1,
			ToScale = 2
		}

		private sealed class _0024HD
		{
			public Action _0024lM;

			internal void _0024Yn()
			{
			}

			internal void _0024zn()
			{
			}

			internal void _0024Zn()
			{
			}
		}

		private sealed class _0024iD
		{
			public Action _0024LM;

			internal void _0024aN()
			{
			}

			internal void _0024AN()
			{
			}

			internal void _0024bN()
			{
			}
		}

		[SerializeField]
		private bool unscaleTime;

		[SerializeField]
		private ShowAnimType showAnimType;

		[SerializeField]
		private float showAnimTime;

		[SerializeField]
		private float initScale;

		[SerializeField]
		private bool separateAxisShowAnim;

		public EasingType showAnimEasingType;

		public AnimationCurve showAnimCurve;

		public EasingType showAnimXAxisEasingType;

		public AnimationCurve showAnimXAxisCurve;

		public EasingType showAnimYAxisEasingType;

		public AnimationCurve showAnimYAxisCurve;

		[SerializeField]
		private PressAnimType pressAnimType;

		[SerializeField]
		private float pressAnimTime;

		[SerializeField]
		private float releaseAnimTime;

		[SerializeField]
		private Vector2 pressedTargetScale;

		[SerializeField]
		private RectTransform _face;

		[SerializeField]
		private Image _faceImage;

		[SerializeField]
		private Color _pressedTint;

		[SerializeField]
		private EasingType pressAnimEasingType;

		[SerializeField]
		private AnimationCurve pressAnimCurve;

		[SerializeField]
		private EasingType releaseAnimEasingType;

		[SerializeField]
		private AnimationCurve releaseAnimCurve;

		[SerializeField]
		private HideAnimType hideAnimType;

		[SerializeField]
		private float hideAnimTime;

		public float targetScale;

		public bool separateAxisHideAnim;

		public EasingType hideAnimEasingType;

		public AnimationCurve hideAnimCurve;

		public EasingType hideAnimXAxisEasingType;

		public AnimationCurve hideAnimXAxisCurve;

		public EasingType hideAnimYAxisEasingType;

		public AnimationCurve hideAnimYAxisCurve;

		private Button _0024jM;

		private CanvasGroup _0024JM;

		private Vector3 _0024kM;

		private Color _0024KM;

		private new bool _0024a => _0024Qn();

		private new bool _0024A => _0024rn();

		private new bool _0024b => _0024Rn();

		private new bool _0024B => _0024sn();

		private new bool _0024c => _0024Sn();

		private new bool _0024C => _0024tn();

		private new bool _0024d => _0024Tn();

		private new bool _0024D => _0024un();

		private new bool _0024e => _0024Un();

		private new bool _0024E => _0024vn();

		private new bool _0024f => _0024Vn();

		private new bool _0024F => _0024wn();

		private new bool _0024g => _0024Wn();

		private new bool _0024G => _0024xn();

		private bool _0024Qn()
		{
			return false;
		}

		private bool _0024rn()
		{
			return false;
		}

		private bool _0024Rn()
		{
			return false;
		}

		private bool _0024sn()
		{
			return false;
		}

		private bool _0024Sn()
		{
			return false;
		}

		private bool _0024tn()
		{
			return false;
		}

		private bool _0024Tn()
		{
			return false;
		}

		private bool _0024un()
		{
			return false;
		}

		private bool _0024Un()
		{
			return false;
		}

		private bool _0024vn()
		{
			return false;
		}

		private bool _0024Vn()
		{
			return false;
		}

		private bool _0024wn()
		{
			return false;
		}

		private bool _0024Wn()
		{
			return false;
		}

		private bool _0024xn()
		{
			return false;
		}

		private void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void _0024AGA(Action _1 = null)
		{
		}

		public override void _0024bGA(Action _1 = null)
		{
		}

		private void _0024Xn()
		{
		}

		private void _0024yn()
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
