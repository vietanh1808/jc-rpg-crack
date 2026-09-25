using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JPageIndicator : APageIndicator
	{
		[SerializeField]
		private RectTransform indicator;

		[SerializeField]
		private bool followSize;

		[SerializeField]
		private Vector2 sizePadding;

		[SerializeField]
		private Vector2 positionOffset;

		private readonly List<RectTransform> _0024YM;

		public override void _0024lGA(IReadOnlyList<RectTransform> _1)
		{
		}

		public override void _0024LGA(float _1)
		{
		}
	}
}
