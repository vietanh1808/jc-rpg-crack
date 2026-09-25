using System;

namespace JoyCraftSDK
{
	[Serializable]
	public enum AdsFlowReason
	{
		None = 0,
		InterShown = 1,
		InterNoFill = 2,
		RewardedShown = 3,
		RewardedNoFill = 4,
		SkippedNoAds = 5
	}
}
