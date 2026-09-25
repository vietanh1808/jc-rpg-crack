using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace JoyCraftSDK.Test.Test_Pooling
{
	public class ButtonLoadPrefab : JButton
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024we : IAsyncStateMachine
		{
			public int _0024ur;

			public AsyncVoidMethodBuilder _0024Ur;

			public ButtonLoadPrefab _0024vr;

			private UniTask<GameObject>.Awaiter _0024Vr;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024CKA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $CKA
				this._0024CKA(_1);
			}
		}

		[SerializeField]
		private AssetReference prefabReference;

		[SerializeField]
		private Transform parentTransform;

		[AsyncStateMachine(typeof(_0024we))]
		protected override void _0024CgA()
		{
		}
	}
}
