using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "LockShakeData", menuName = "GameSDK/LockShakeData")]
	public class LockShakeData : ALockShakeData
	{
		[SerializeField]
		public float duration;

		[SerializeField]
		public float angle;

		[SerializeField]
		public int swings;

		[SerializeField]
		public float decay;

		[SerializeField]
		public bool unscaledTime;
	}
}
