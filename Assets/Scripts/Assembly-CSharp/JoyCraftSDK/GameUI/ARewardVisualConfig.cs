using System.Collections.Generic;
using JoyCraftSDK.IAP;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public abstract class ARewardVisualConfig : JScriptableObject
	{
		public new abstract IReadOnlyList<RewardKind> _0024a { get; }

		public abstract Sprite _0024vGA(RewardKind _1);

		public abstract RewardFlyEffect _0024VGA(RewardKind _1);

		public abstract IReadOnlyList<RewardKind> _0024wGA();
	}
}
