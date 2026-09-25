using System;

namespace JoyCraftSDK.CloudSave
{
	[Serializable]
	public enum BootSyncOutcome
	{
		None = 0,
		AppliedFromCloud = 1,
		LocalKept = 2,
		NoCloudData = 3,
		OfflineSkipped = 4,
		RestoreConflictRequired = 5
	}
}
