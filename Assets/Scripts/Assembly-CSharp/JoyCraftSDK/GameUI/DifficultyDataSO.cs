using JoyCraftSDK.Utilities;
using UnityEngine;
using nickeltin.SDF.Runtime;

namespace JoyCraftSDK.GameUI
{
	[CreateAssetMenu(menuName = "GameSDK/DifficultyDataSO", fileName = "DifficultyDataSO")]
	public class DifficultyDataSO : ADifficultyDataSO
	{
		[SerializeField]
		private SpriteDictionary Sprites;

		public override Sprite _0024SGA(UIObjectType _1, int _1 = -1)
		{
			return null;
		}

		public override Sprite _0024tGA(UIObjectType _1, int _1 = -1)
		{
			return null;
		}

		public override SDFSpriteReference _0024TGA(UIObjectType _1, int _1 = -1)
		{
			return default;
		}

		public override SDFSpriteReference _0024uGA(UIObjectType _1, int _1 = -1)
		{
			return default;
		}

		protected virtual ReleaseDifficulty _0024UGA(int _1)
		{
			return (ReleaseDifficulty)0;
		}

		private Sprite _0024BO(ReleaseDifficulty _1, SpriteData _1)
		{
			return null;
		}

		private SDFSpriteReference _0024cO(UIObjectType _1, ReleaseDifficulty _1, SdfSpriteData _1)
		{
			return default;
		}
	}
}
