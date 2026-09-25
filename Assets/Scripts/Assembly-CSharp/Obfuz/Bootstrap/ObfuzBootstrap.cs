using UnityEngine;

namespace Obfuz.Bootstrap
{
	public static class ObfuzBootstrap
	{
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void SetUpStaticSecretKey()
		{
		}
	}
}
