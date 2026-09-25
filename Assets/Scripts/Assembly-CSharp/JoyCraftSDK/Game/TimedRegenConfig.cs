using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TimedRegenConfig", menuName = "GameSDK/TimedRegenConfig")]
	public class TimedRegenConfig : ATimedRegenConfig
	{
		[SerializeField]
		private List<TimedRegenConfigPoint> configPoints;

		public override IReadOnlyList<TimedRegenConfigPoint> _0024wDA()
		{
			return null;
		}

		public override TimedRegenConfigPoint _0024WDA(RegenResourceType _1)
		{
			return null;
		}
	}
}
