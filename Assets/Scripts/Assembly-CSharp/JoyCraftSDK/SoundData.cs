using UnityEngine;

namespace JoyCraftSDK
{
	[CreateAssetMenu(fileName = "SoundData", menuName = "GameSDK/SoundData")]
	public class SoundData : ASoundData
	{
		[SerializeField]
		private float delayWinScreen;

		public override float _0024a => _0024JBA();

		public override float _0024JBA()
		{
			return 0f;
		}
	}
}
