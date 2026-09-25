using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	[Serializable]
	[CreateAssetMenu(fileName = "GameAssets", menuName = "JoyCraft/Scriptable Objects/Addressable Assets/Game Assets")]
	public class GameAssets : AGameAssets
	{
		[SerializeField]
		private AssetsDictionary assets;

		[SerializeField]
		private int assetIDDictionaryExactLength;

		public override AssetsDictionary Assets => _0024YAA();

		public override int AssetIDDictionaryExactLength => _0024zAA();

		public override AssetsDictionary _0024YAA()
		{
			return null;
		}

		public override int _0024zAA()
		{
			return 0;
		}
	}
}
