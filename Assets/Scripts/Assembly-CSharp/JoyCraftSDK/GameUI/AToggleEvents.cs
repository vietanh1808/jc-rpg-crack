using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class AToggleEvents : JMonoBehaviour
	{
		public Relay<bool> OnValueChange;

		public abstract void _0024OGA(bool _1);

		public abstract bool _0024pGA();
	}
}
