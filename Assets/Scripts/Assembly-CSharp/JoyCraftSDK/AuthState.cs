using System;

namespace JoyCraftSDK
{
	[Serializable]
	public enum AuthState
	{
		NotInitialized = 0,
		SigningIn = 1,
		SignedInAnonymous = 2,
		Offline = 3,
		Linked = 4
	}
}
