using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedBuffConfig : JScriptableObject
	{
		public abstract IReadOnlyList<TimedBuffConfigPoint> _0024ODA();

		public abstract TimedBuffConfigPoint _0024pDA(BuffType _1);
	}
}
