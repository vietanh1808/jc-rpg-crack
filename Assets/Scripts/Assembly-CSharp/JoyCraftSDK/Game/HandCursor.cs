using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.Game
{
	public class HandCursor : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform handRect;

		[SerializeField]
		private Image handImage;

		[Header("Click Animation")]
		[SerializeField]
		private float clickScale;

		[SerializeField]
		private float clickDuration;

		private Vector3 _0024YI;

		private Tween _0024zI;

		private bool _0024ZI;

		public override void Awake()
		{
		}

		private void Update()
		{
		}

		private void _0024Eh(bool _1)
		{
		}

		private void _0024fh()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
