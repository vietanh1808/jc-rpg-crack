using System;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public enum CloudPushResult
	{
		None = 0,
		Success = 1,
		ConflictWriteLock = 2,
		TooLarge = 3,
		Offline = 4,
		Failed = 5
	}
}
