using UnityEngine;
using UnityEngine.Serialization;

namespace BucketKnight.Flow.Data
{
	[CreateAssetMenu(fileName = "LevelBlueprint", menuName = "GameSDK/LevelBlueprint")]
	public class LevelBlueprint : ALevelBlueprint
	{
		[FormerlySerializedAs("actIndex")]
		[SerializeField]
		private int levelIndex;

		[FormerlySerializedAs("stages")]
		[SerializeField]
		private RoomBlueprint[] rooms;

		public override int _0024a => _0024uIA();

		public override int _0024uIA()
		{
			return 0;
		}

		public override RoomBlueprint _0024UIA(int _1)
		{
			return null;
		}

		private void OnValidate()
		{
		}
	}
}
