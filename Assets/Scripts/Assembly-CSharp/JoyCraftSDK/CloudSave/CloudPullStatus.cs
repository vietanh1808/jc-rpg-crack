using System;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public enum CloudPullStatus
	{
		None = 0,
		Success = 1,
		Empty = 2,
		Offline = 3,
		Failed = 4
	}
}
