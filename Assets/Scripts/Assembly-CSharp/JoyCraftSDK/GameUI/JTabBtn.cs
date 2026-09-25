using System;
using _0024e;
using JoyCraftSDK.StateMachines;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class JTabBtn : ATabBtn, _0024PC<_0024qC>
	{
		[SerializeField]
		protected ATabPage page;

		[SerializeField]
		private ATwoSM stateMachine;

		[SerializeField]
		private Image bg;

		[SerializeField]
		private Sprite activeBg;

		[SerializeField]
		private Sprite inactiveBg;

		private Action<ATabBtn> _0024an;

		private _0024qC _0024An;

		private bool _0024bn;

		private void _0024yN()
		{
		}

		private void _0024YN(_0024qC _1)
		{
		}

		public void _0024YeA(_0024qC _1)
		{
		}

		public override void _0024mGA(ATabPage _1)
		{
		}

		public override void _0024MGA(bool _1)
		{
		}

		public override void OnSelect()
		{
		}

		public override void OnDeselect()
		{
		}

		protected override void _0024CgA()
		{
		}

		public override void _0024nGA(Action<ATabBtn> _1)
		{
		}

		protected override void OnValidate()
		{
		}
	}
}
