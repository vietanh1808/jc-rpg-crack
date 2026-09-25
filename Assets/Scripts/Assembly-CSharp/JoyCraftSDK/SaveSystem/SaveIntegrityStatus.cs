using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public enum SaveIntegrityStatus
	{
		Unknown = 0,
		Valid = 1,
		Missing = 2,
		VersionMismatch = 3,
		Mismatch = 4,
		Error = 5,
		MissingAfterSigned = 6,
		Replayed = 7
	}
}
