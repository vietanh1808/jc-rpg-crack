using _0024j;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.LiveEvent
{
	public abstract class ABattlePassConfig : ALiveEventConfig
	{
		[Tooltip("SKU premium (Consumable). Rỗng = không bán premium; đổi ID sau khi khai dashboard = lệch mapping.")]
		[_0024BD]
		[SerializeField]
		private string premiumProductID;

		[Tooltip("Key thưởng khi thắng 1 level Normal.")]
		[SerializeField]
		private int keyPerWinNormal;

		[Tooltip("Key thưởng khi thắng 1 level Hard.")]
		[SerializeField]
		private int keyPerWinHard;

		[Tooltip("Key thưởng khi thắng 1 level VeryHard.")]
		[SerializeField]
		private int keyPerWinVeryHard;

		public new string _0024a => _0024Cf();

		public string _0024Cf()
		{
			return null;
		}

		public int _0024df(ReleaseDifficulty _1)
		{
			return 0;
		}
	}
}
