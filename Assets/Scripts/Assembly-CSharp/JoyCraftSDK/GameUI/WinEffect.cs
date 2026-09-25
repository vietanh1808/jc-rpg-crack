using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class WinEffect : AWinEffect
	{
		private sealed class _0024vD
		{
			public Action _0024Fp;

			internal void _0024Sr()
			{
			}
		}

		private sealed class _0024VD
		{
			public RectTransform _0024gp;

			internal void _0024tr()
			{
			}
		}

		[SerializeField]
		private List<RectTransform> iconList;

		[SerializeField]
		private Transform targetPoint;

		[SerializeField]
		private Vector2 startPoint;

		[SerializeField]
		private float minDist;

		[SerializeField]
		private float maxDist;

		[SerializeField]
		private float scatterDuration;

		[SerializeField]
		private float gatherDuration;

		[SerializeField]
		private float delayBetweenIcons;

		private Vector3 _0024fp;

		public override void _0024bhA(Action _1 = null)
		{
		}

		public override void _0024BhA(Vector3 _1, Action _1 = null)
		{
		}

		public override void _0024chA(Transform _1, Action _1 = null)
		{
		}

		private Vector2 _0024sr()
		{
			return default;
		}
	}
}
