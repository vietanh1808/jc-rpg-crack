using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public abstract class ABaseGameSceneManager : AGameSceneManager
	{
		[StructLayout((LayoutKind)3)]
		private new struct _0024fA : IAsyncStateMachine
		{
			public int _0024aD;

			public AsyncVoidMethodBuilder _0024AD;

			public ABaseGameSceneManager _0024bD;

			private UniTask.Awaiter _0024BD;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024TJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $TJA
				this._0024TJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private new struct _0024FA : IAsyncStateMachine
		{
			public int _0024cD;

			public AsyncVoidMethodBuilder _0024CD;

			public ABaseGameSceneManager _0024dD;

			private UniTask.Awaiter _0024DD;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024uJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $uJA
				this._0024uJA(_1);
			}
		}

		[SerializeField]
		protected bool startPlayOnSetupFinish;

		public override SceneIndex _0024a => _0024GbA();

		public override SceneIndex _0024GbA()
		{
			return SceneIndex.Logo;
		}

		protected override void _0024hbA()
		{
		}

		protected override void _0024HbA()
		{
		}

		public override void _0024ibA(ref AEventManager._0024wb _1)
		{
		}

		[AsyncStateMachine(typeof(_0024fA))]
		private void _0024eD()
		{
		}

		[AsyncStateMachine(typeof(_0024FA))]
		public override void _0024IbA()
		{
		}
	}
}
