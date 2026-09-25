using JoyCraftSDK.Game;
using UnityEngine;
using UnityEngine.Serialization;

namespace BucketKnight.Flow.Data
{
	[CreateAssetMenu(fileName = "BucketKnightLevelData", menuName = "GameSDK/BucketKnightLevelData")]
	public class BucketKnightLevelData : LevelData
	{
		[FormerlySerializedAs("actBlueprint")]
		[SerializeField]
		private ALevelBlueprint levelBlueprint;

		public new ALevelBlueprint _0024a => _0024AX();

		public ALevelBlueprint _0024AX()
		{
			return null;
		}
	}
}
