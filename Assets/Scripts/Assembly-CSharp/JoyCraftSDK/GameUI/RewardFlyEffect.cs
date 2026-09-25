using System;
using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class RewardFlyEffect : JMonoBehaviour
	{
		private sealed class _0024lD
		{
			public RewardFlyEffect _0024xN;

			public Transform _0024XN;

			public int _0024yN;

			public Action _0024YN;
		}

		private sealed class _0024LD
		{
			public Image _0024zN;

			public _0024lD _0024ZN;

			internal void _0024Dq()
			{
			}
		}

		[SerializeField]
		private Image _iconTemplate;

		[SerializeField]
		private int _iconCount;

		[SerializeField]
		private float _scatterRadius;

		[SerializeField]
		private float _scatterDuration;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private float _flyInterval;

		[SerializeField]
		private EasingType _scatterEasing;

		[SerializeField]
		private EasingType _flyEasing;

		[SerializeField]
		private float _flyCurveOffset;

		[SerializeField]
		private float _spinDegrees;

		[SerializeField]
		private float _scatterScale;

		[SerializeField]
		private float _landScale;

		[SerializeField]
		private float _punchStrength;

		[SerializeField]
		private float _punchDuration;

		private readonly List<Image> _0024wN;

		private bool _0024WN;

		public void _0024cq(Sprite _1, Vector3 _1, Transform _1, Action _1)
		{
		}

		private void _0024Cq(Transform _1)
		{
		}

		protected override void OnDisable()
		{
		}

		private void _0024dq(Action _1)
		{
		}
	}
}
