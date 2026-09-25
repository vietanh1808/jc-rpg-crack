using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(menuName = "GameSDK/UnlockFeatureConfig", fileName = "Config")]
	public class UnlockFeatureConfig : AUnlockFeatureConfig
	{
		[FormerlySerializedAs("datas")]
		[SerializeField]
		private List<UnlockData> unlockDatas;

		public override VideoClip _0024ydA(GameFeatureType _1)
		{
			return null;
		}

		public override Sprite _0024YdA(GameFeatureType _1)
		{
			return null;
		}
	}
}
