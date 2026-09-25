using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class PulseEffect : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform visualTF;

		[SerializeField]
		private float pulseRate;

		[SerializeField]
		private float minScale;

		[SerializeField]
		private float speed;

		private Sequence _0024EM;

		private Vector3 _0024fM;

		private bool _0024FM;

		private new float _0024a => _0024Ln();

		private float _0024Ln()
		{
			return 0f;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024mn()
		{
		}
	}
}
