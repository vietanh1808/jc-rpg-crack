using System;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public enum PushExceptionClassification
	{
		None = 0,
		ConflictWriteLock = 1,
		Offline = 2,
		Retryable = 3,
		Failed = 4
	}
}
