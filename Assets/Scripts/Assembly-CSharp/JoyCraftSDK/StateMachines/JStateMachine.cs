using System;
using System.Collections.Generic;
using _0024e;
using JoyCraftSDK.Utilities;
using UnityHFSM;

namespace JoyCraftSDK.StateMachines
{
	[Serializable]
	public abstract class JStateMachine<TState> : JMonoBehaviour where TState : struct, Enum
	{
		private sealed class _0024pC
		{
			public TState _0024DJ;

			public JStateMachine<TState> _0024eJ;

			internal void _0024RH(State<TState, string> _1)
			{
			}
		}

		private StateMachine<TState> _0024BJ;

		private TState _0024cJ;

		private List<_0024PC<TState>> _0024CJ;

		private bool _0024dJ;

		protected override string _0024a => _0024aEA();

		public virtual void _0024zeA(TState _1, List<_0024PC<TState>> _1)
		{
		}

		private void _0024NH(TState _1)
		{
		}

		public void _0024oH(TState _1)
		{
		}

		protected abstract void _0024ZeA();

		public TState _0024pH()
		{
			return default;
		}

		public bool _0024PH()
		{
			return false;
		}

		public void _0024qH(_0024PC<TState> _1)
		{
		}

		public bool _0024QH(_0024PC<TState> _1)
		{
			return false;
		}

		private void _0024rH(List<_0024PC<TState>> _1)
		{
		}

		protected override string _0024aEA()
		{
			return null;
		}
	}
}
