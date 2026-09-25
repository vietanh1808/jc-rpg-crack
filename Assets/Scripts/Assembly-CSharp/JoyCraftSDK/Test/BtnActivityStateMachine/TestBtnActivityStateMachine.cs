using _0024e;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.StateMachines;
using UnityEngine;

namespace JoyCraftSDK.Test.BtnActivityStateMachine
{
	[RequireComponent(typeof(ATwoSM))]
	[RequireComponent(typeof(ABtnEvents))]
	public class TestBtnActivityStateMachine : ATestBtnActivityStateMachine
	{
		[SerializeField]
		private ABtnEvents button;

		[SerializeField]
		private ATwoSM stateMachine;

		[SerializeField]
		private bool setupActive;

		private _0024qC _0024Xr;

		protected override void OnEnable()
		{
		}

		private void _0024zy()
		{
		}

		public void _0024Zy()
		{
		}

		public void _0024aY()
		{
		}

		private void OnValidate()
		{
		}
	}
}
