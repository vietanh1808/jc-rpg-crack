using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedRegenConfig : JScriptableObject
	{
		public abstract IReadOnlyList<TimedRegenConfigPoint> _0024wDA();

		public abstract TimedRegenConfigPoint _0024WDA(RegenResourceType _1);
	}
}
