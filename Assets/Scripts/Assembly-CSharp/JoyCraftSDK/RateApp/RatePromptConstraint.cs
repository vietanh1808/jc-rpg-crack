using System;
using UnityEngine;

namespace JoyCraftSDK.RateApp
{
	[Serializable]
	public class RatePromptConstraint
	{
		[Tooltip("Số win (kể từ lần hỏi trước) tối thiểu trước khi được phép hiện prompt.")]
		[SerializeField]
		private int minWins;

		[Tooltip("Số GIỜ tối thiểu kể từ lần hỏi trước. Lần đầu (chưa hỏi) coi như đã đủ.")]
		[SerializeField]
		private float minHours;

		public int MinWins => _0024tl();

		public float MinHours => _0024Tl();

		public RatePromptConstraint()
		{
		}

		public RatePromptConstraint(int minWins, float minHours)
		{
		}

		public int _0024tl()
		{
			return 0;
		}

		public float _0024Tl()
		{
			return 0f;
		}
	}
}
