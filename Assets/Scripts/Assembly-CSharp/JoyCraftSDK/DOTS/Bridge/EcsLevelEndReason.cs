using System;

namespace JoyCraftSDK.DOTS.Bridge
{
	[Serializable]
	public enum EcsLevelEndReason
	{
		LevelCleared = 0,
		PlayerDied = 1,
		QuitToMenu = 2
	}
}
