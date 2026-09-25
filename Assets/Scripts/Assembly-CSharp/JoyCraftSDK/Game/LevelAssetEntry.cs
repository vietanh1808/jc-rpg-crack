using System;
using _0024l;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Game
{
	[Serializable]
	public class LevelAssetEntry : _0024YD
	{
		[Tooltip("Addressable ref tới ALevelData asset (dựng qua BuildFromFolder — mark Addressable + guid).")]
		[SerializeField]
		private AssetReference levelRef;

		[Tooltip("Difficulty MIRROR từ LevelData (resident — hỏi KHÔNG cần load asset nặng). Re-sync bằng BuildFromFolder.")]
		[SerializeField]
		private ReleaseDifficulty difficulty;

		public AssetReference LevelRef => _0024Xg();

		public ReleaseDifficulty Difficulty => _0024yg();

		public AssetReference _0024Xg()
		{
			return null;
		}

		public ReleaseDifficulty _0024yg()
		{
			return (ReleaseDifficulty)0;
		}

		public LevelAssetEntry()
		{
		}

		public LevelAssetEntry(AssetReference levelRef, ReleaseDifficulty difficulty)
		{
		}
	}
}
