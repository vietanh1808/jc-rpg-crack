using System.Runtime.CompilerServices;
using _0024S;
using _0024t;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JoyCraftSDK.GameUI
{
	[RequireComponent(typeof(JoystickEvents))]
	public class JJoystick : JMonoBehaviour, _0024yf
	{
		[SerializeField]
		private JoystickEvents _joystickEvents;

		[SerializeField]
		private RectTransform _base;

		[SerializeField]
		private RectTransform _handle;

		[Tooltip("Cung chỉ hướng, cho phép null -> bỏ qua mọi xử lý cung.")]
		[SerializeField]
		private RectTransform _direction;

		[Tooltip("CanvasGroup đặt trên node Base — cho phép null -> tắt toàn bộ fade.")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private float _radius;

		[Range(0f, 0.9f)]
		[SerializeField]
		private float _deadZonePercent;

		[SerializeField]
		private float _idleDelay;

		[SerializeField]
		private float _fadeDuration;

		[Range(0f, 1f)]
		[SerializeField]
		private float _idleAlpha;

		private _0024zf _0024cn;

		private _0024Yf _0024fn;

		private Tween _0024Gn;

		private RectTransform _0024hn;

		private Canvas _0024Ln;

		private Camera _0024Tn;

		private Vector2 _0024zn;

		private Vector2 _0024bN;

		private bool _0024JN;

		[CompilerGenerated]
		private Vector2 _0024KN;

		public new Vector2 _0024a
		{
			get
			{
				return _0024zkA();
			}
			private set
			{
				_0024Jy(value);
			}
		}

		public Vector2 _0024zkA()
		{
			return default;
		}

		private void _0024Jy(Vector2 _1)
		{
		}

		public override void Awake()
		{
		}

		private void _0024ky()
		{
		}

		private void OnValidate()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		private void _0024Ky(PointerEventData _1)
		{
		}

		private void _0024ly(PointerEventData _1)
		{
		}

		private void _0024Ly()
		{
		}

		private void _0024my()
		{
		}

		private bool _0024My(PointerEventData _1, out Vector2 _1)
		{
			_1 = default;
			return false;
		}

		private void _0024ny(ref AEventManager._0024yb _1)
		{
		}

		private void _0024Ny(JoystickFadeRequest _1)
		{
		}
	}
}
