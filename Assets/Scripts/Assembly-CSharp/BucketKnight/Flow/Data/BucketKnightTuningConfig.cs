using JoyCraftSDK.Utilities;
using UnityEngine;

namespace BucketKnight.Flow.Data
{
	[CreateAssetMenu(fileName = "BucketKnightTuningConfig", menuName = "GameSDK/BucketKnightTuningConfig")]
	public class BucketKnightTuningConfig : JScriptableObject
	{
		[SerializeField]
		private bool batchFloorUsesBatchMin;

		[SerializeField]
		private float tickInterval;

		[SerializeField]
		private float pressureRadius;

		[SerializeField]
		private float spawnBehindChance;

		public new bool _0024a => _0024bX();

		public new float _0024A => _0024BX();

		public new float _0024b => _0024cX();

		public new float _0024B => _0024CX();

		public bool _0024bX()
		{
			return false;
		}

		public float _0024BX()
		{
			return 0f;
		}

		public float _0024cX()
		{
			return 0f;
		}

		public float _0024CX()
		{
			return 0f;
		}
	}
}
