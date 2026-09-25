using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK;
using JoyCraftSDK.Utilities;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace _0024B
{
	public class _0024bA : _0024DA
	{
		[StructLayout((LayoutKind)3)]
		private new struct _0024BA : IAsyncStateMachine
		{
			public int _0024DC;

			public AsyncVoidMethodBuilder _0024eC;

			public _0024bA _0024EC;

			public Action _0024fC;

			private UniTask<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>.Awaiter _0024FC;

			private UniTask<bool>.Awaiter _0024gC;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024pJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $pJA
				this._0024pJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private new struct _0024cA : IAsyncStateMachine
		{
			public int _0024GC;

			public AsyncUniTaskMethodBuilder<bool> _0024hC;

			public _0024bA _0024HC;

			private IList<IResourceLocation> _0024oE;

			private UniTask<IList<IResourceLocation>>.Awaiter _0024IC;

			private UniTask<long>.Awaiter _0024jC;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024PJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $PJA
				this._0024PJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private new struct _0024CA<T> : IAsyncStateMachine
		{
			public int _0024JC;

			public AsyncUniTaskMethodBuilder<T> _0024kC;

			public _0024bA _0024KC;

			public AssetReference _0024lC;

			private AsyncOperationHandle<T> _0024OE;

			private UniTask<T>.Awaiter _0024mC;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024qJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $qJA
				this._0024qJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private new struct _0024dA<T> : IAsyncStateMachine
		{
			public int _0024MC;

			public AsyncUniTaskMethodBuilder<T> _0024nC;

			public _0024bA _0024NC;

			public AssetID _0024oC;

			private AssetReference _0024pE;

			private AsyncOperationHandle<T> _0024PE;

			private UniTask<T>.Awaiter _0024PC;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024QJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $QJA
				this._0024QJA(_1);
			}
		}

		private readonly Dictionary<AssetReference, object> _0024cC;

		private new AssetsDictionary _0024a => _0024ac();

		private AssetsDictionary _0024ac()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_0024BA))]
		public override void _0024uAA(Action _1 = null)
		{
		}

		private void _0024Ac(bool _1, bool _1)
		{
		}

		[AsyncStateMachine(typeof(_0024cA))]
		private UniTask<bool> _0024bc()
		{
			return default;
		}

		private bool _0024Bc()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_0024dA<>))]
		public override UniTask<T> _0024UAA<T>(AssetID _1)
		{
			return default;
		}

		public override void _0024vAA<T>(AssetID _1)
		{
		}

		private AssetReference _0024cc(AssetID _1)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_0024CA<>))]
		public override UniTask<T> _0024VAA<T>(AssetReference _1)
		{
			return default;
		}

		public override void _0024wAA<T>(AssetReference _1)
		{
		}
	}
}
