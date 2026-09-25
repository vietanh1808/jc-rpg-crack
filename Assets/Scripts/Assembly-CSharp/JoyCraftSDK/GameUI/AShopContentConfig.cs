using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class AShopContentConfig : JScriptableObject
	{
		public new abstract IReadOnlyList<ShopSection> _0024a { get; }

		public abstract IReadOnlyList<ShopSection> _0024ahA();
	}
}
