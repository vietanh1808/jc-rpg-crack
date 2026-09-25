using System;
using System.Collections.Generic;
using _0024l;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	[Serializable]
	public class ShopSection : _0024YD
	{
		[SerializeField]
		private string label;

		[SerializeField]
		private Sprite icon;

		[SerializeField]
		private List<ShopCardEntry> cards;

		public string Label => _0024TQ();

		public Sprite Icon => _0024uQ();

		public IReadOnlyList<ShopCardEntry> Cards => _0024UQ();

		public string _0024TQ()
		{
			return null;
		}

		public Sprite _0024uQ()
		{
			return null;
		}

		public IReadOnlyList<ShopCardEntry> _0024UQ()
		{
			return null;
		}

		public ShopSection()
		{
		}

		public ShopSection(string label, Sprite icon, List<ShopCardEntry> cards)
		{
		}
	}
}
