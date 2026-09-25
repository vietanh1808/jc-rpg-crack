using _0024J;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class ABtnEvents : JMonoBehaviour, _0024cD
	{
		public Relay OnClick;

		public readonly Relay<bool> OnInteractableChange;

		public abstract void _0024ZgA(bool _1);

		public abstract bool _0024aGA();

		public abstract void _0024agA();

		public abstract bool _0024AgA();

		public abstract void _0024bgA(bool _1);

		public abstract void _0024BgA();

		public abstract int _0024cgA();
	}
}
