using System;

namespace JoyCraftSDK.SaveSystem
{
	[Serializable]
	public enum CounterScope
	{
		Lifetime = 0,
		Daily = 1,
		Window = 2,
		PerLevel = 3
	}
}
