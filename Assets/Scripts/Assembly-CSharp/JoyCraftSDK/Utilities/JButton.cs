using _0024J;
using JoyCraftSDK.GameUI;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[RequireComponent(typeof(ABtnEvents))]
	[RequireComponent(typeof(AButtonAnimController))]
	public abstract class JButton : AButton
	{
		private float _0024tp;

		private bool _0024Tp;

		private new float _0024a => _0024bu();

		protected new virtual bool _0024A => _0024PGA();

		private float _0024bu()
		{
			return 0f;
		}

		protected virtual bool _0024PGA()
		{
			return false;
		}

		private void _0024Bu()
		{
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		public override _0024cD _0024UhA()
		{
			return null;
		}
	}
}
