using System;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public enum CloudApplyResult
	{
		None = 0,
		Applied = 1,
		SkippedExcluded = 2,
		SkippedNewerSchema = 3,
		SkippedInvalidStamp = 4,
		SkippedUnknownDomain = 5
	}
}
