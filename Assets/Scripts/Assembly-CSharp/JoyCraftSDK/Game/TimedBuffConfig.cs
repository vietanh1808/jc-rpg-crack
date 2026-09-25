using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TimedBuffConfig", menuName = "GameSDK/TimedBuffConfig")]
	public class TimedBuffConfig : ATimedBuffConfig
	{
		[SerializeField]
		private List<TimedBuffConfigPoint> configPoints;

		public override IReadOnlyList<TimedBuffConfigPoint> _0024ODA()
		{
			return null;
		}

		public override TimedBuffConfigPoint _0024pDA(BuffType _1)
		{
			return null;
		}
	}
}
