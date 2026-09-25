using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	[CreateAssetMenu(fileName = "ShopContentConfig", menuName = "GameSDK/ShopContentConfig")]
	public class ShopContentConfig : AShopContentConfig
	{
		[SerializeField]
		private List<ShopSection> sections;

		public override IReadOnlyList<ShopSection> Sections => _0024ahA();

		public override IReadOnlyList<ShopSection> _0024ahA()
		{
			return null;
		}
	}
}
