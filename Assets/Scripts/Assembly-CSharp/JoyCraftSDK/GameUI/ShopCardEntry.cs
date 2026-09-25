using System;
using _0024j;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class ShopCardEntry : _0024YD
	{
		[SerializeField]
		private JShopCV card;

		[_0024BD]
		[SerializeField]
		private string gateProductID;

		[SerializeField]
		private ShopUnlockRule unlockRule;

		public JShopCV Card => _0024vQ();

		public string GateProductID => _0024VQ();

		public ShopUnlockRule UnlockRule => _0024wQ();

		public JShopCV _0024vQ()
		{
			return null;
		}

		public string _0024VQ()
		{
			return null;
		}

		public ShopUnlockRule _0024wQ()
		{
			return ShopUnlockRule.Always;
		}
	}
}
