using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public abstract class ATabBtn : JButton
	{
		public abstract void _0024mGA(ATabPage _1);

		public abstract void _0024MGA(bool _1);

		public abstract void _0024nGA(Action<ATabBtn> _1);

		public abstract void OnSelect();

		public abstract void OnDeselect();
	}
}
