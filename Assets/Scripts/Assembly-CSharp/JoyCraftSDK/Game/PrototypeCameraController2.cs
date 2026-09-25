using DG.Tweening;
using JoyCraftSDK.GameUI;
using Unity.Cinemachine;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class PrototypeCameraController2 : ALevelCameraController
	{
		public struct _0024oc
		{
			public bool _0024XH;

			public float _0024yH;

			public Vector3 _0024YH;

			public Quaternion _0024zH;

			public string _0024ZH;
		}

		[SerializeField]
		private CinemachineVirtualCamera virtualCamera;

		[Tooltip("Offset bổ sung từ tâm level (dùng để điều chỉnh vị trí camera)")]
		[SerializeField]
		private Vector3 offset;

		[SerializeField]
		private float cameraRotationX;

		[Tooltip("Khoảng cách camera từ target (tránh clip plane)")]
		[SerializeField]
		private float cameraDistance;

		[Tooltip("Duration cho tween animation. 0 = instant.")]
		[SerializeField]
		private float defaultTweenDuration;

		[SerializeField]
		private Ease defaultEase;

		[SerializeField]
		private SafeAreaData safeAreaData;

		[Tooltip("Bù cho visual extent của border models theo chiều Z (camera 65°)")]
		private float _0024vH;

		[Tooltip("Bù cho visual extent theo chiều X")]
		private float _0024VH;

		[SerializeField]
		private bool showDebugGizmo;

		[SerializeField]
		private Color gizmoColor;

		private Vector3 _0024wH;

		private Vector3 _0024WH;

		private bool _0024xH;

		private new string _0024a => _0024MF();

		private new Vector2 _0024A => _0024nF();

		private new Vector2 _0024b => _0024NF();

		private new Vector2 _0024B => _0024oF();

		private string _0024MF()
		{
			return null;
		}

		private Vector2 _0024nF()
		{
			return default;
		}

		private Vector2 _0024NF()
		{
			return default;
		}

		private Vector2 _0024oF()
		{
			return default;
		}

		public override void _0024ZCA(Vector3 _1, Vector3 _1)
		{
		}

		public void _0024OF(Vector3 _1, Vector3 _1)
		{
		}

		public _0024oc _0024pF(Vector3 _1, Vector3 _1)
		{
			return default;
		}

		public void _0024PF(_0024oc _1, bool _1 = false)
		{
		}

		private void _0024qF(_0024oc _1)
		{
		}

		private void _0024QF(_0024oc _1)
		{
		}

		private Vector3 _0024rF(float _1, float _1)
		{
			return default;
		}
	}
}
