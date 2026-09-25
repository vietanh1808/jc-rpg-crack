using System;
using System.Collections.Generic;
using JoyCraftSDK.IAP;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(fileName = "RewardVisualConfig", menuName = "GameSDK/RewardVisualConfig")]
	public class RewardVisualConfig : ARewardVisualConfig
	{
		[Serializable]
		public struct RewardVisualEntry
		{
			public RewardKind kind;

			public Sprite icon;

			public RewardFlyEffect flyEffectOverride;
		}

		[SerializeField]
		private List<RewardVisualEntry> entries;

		[SerializeField]
		private RewardFlyEffect defaultFlyEffect;

		[SerializeField]
		private List<RewardKind> allBoosterDisplayKinds;

		public override IReadOnlyList<RewardKind> _0024a => _0024wGA();

		public override IReadOnlyList<RewardKind> _0024wGA()
		{
			return null;
		}

		public override Sprite _0024vGA(RewardKind _1)
		{
			return null;
		}

		public override RewardFlyEffect _0024VGA(RewardKind _1)
		{
			return null;
		}
	}
}
