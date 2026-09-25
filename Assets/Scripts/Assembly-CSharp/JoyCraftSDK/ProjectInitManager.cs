using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _0024C;
using _0024P;
using _0024R;
using _0024d;
using _0024i;
using _0024s;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.GameUI;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK
{
	public class ProjectInitManager : AProjectInitManager
	{
		private sealed class _0024Ab
		{
			public ProjectInitManager _0024rE;

			public PopupRestoreConflict _0024SE;

			public UniTaskCompletionSource _0024tE;

			internal void _0024hy()
			{
			}

			internal void _0024Hy()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024bb : IAsyncStateMachine
		{
			public int _0024TE;

			public AsyncUniTaskVoidMethodBuilder _0024uE;

			public ProjectInitManager _0024UE;

			public PopupRestoreConflict _0024vE;

			public UniTaskCompletionSource _0024VE;

			private UniTask<JoyCraftSDK.CloudSave.CloudPushResult>.Awaiter _0024wE;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024rJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $rJA
				this._0024rJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024gB : IAsyncStateMachine
		{
			public int _0024WE;

			public AsyncUniTaskMethodBuilder<bool> _0024XE;

			public ProjectInitManager _0024yE;

			private CancellationTokenSource _0024YE;

			private UniTask<(bool hasResultLeft, bool result)>.Awaiter _0024zE;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024RJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $RJA
				this._0024RJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024YB : IAsyncStateMachine
		{
			public int _0024ZE;

			public AsyncUniTaskMethodBuilder<bool> _0024af;

			public ProjectInitManager _0024Af;

			public CancellationToken _0024NF;

			private UniTask<bool>.Awaiter _0024oF;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024sJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $sJA
				this._0024sJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024oC : IAsyncStateMachine
		{
			public int _0024SF;

			public AsyncUniTaskMethodBuilder _0024Rg;

			public ProjectInitManager _0024sg;

			private UniTask.Awaiter _0024Sg;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024SJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $SJA
				this._0024SJA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Ue : IAsyncStateMachine
		{
			public int _0024Tg;

			public AsyncUniTaskVoidMethodBuilder _0024ug;

			public ProjectInitManager _0024Wg;

			private UniTask.Awaiter _0024PG;

			private UniTask<bool>.Awaiter _0024ah;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024tJA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $tJA
				this._0024tJA(_1);
			}
		}

		[SerializeField]
		private bool LoadTestScene;

		private _0024Tf _0024qC;

		private _0024Vf _0024qE;

		private _0024uf _0024QE;

		[SerializeField]
		private bool _internetManagerInited;

		[SerializeField]
		private bool _backendManagerInited;

		[SerializeField]
		private bool _gameDataManagerInited;

		[SerializeField]
		private bool _addressableManagerInited;

		[SerializeField]
		private bool _inputManagerInited;

		[SerializeField]
		private bool _frameRateInited;

		[SerializeField]
		private bool _factoryInited;

		[SerializeField]
		private bool _pushNotiInited;

		[SerializeField]
		private bool _gameServicesInited;

		[SerializeField]
		private bool _consentTrackingInited;

		[SerializeField]
		private bool _authInited;

		[SerializeField]
		private bool _blockEffectManagerInited;

		[SerializeField]
		private bool _iosTrackingInited;

		private new _0024Od _0024a => _0024dc();

		private new _0024Ec _0024A => _0024Dc();

		private new _0024Wc _0024b => _0024ec();

		private new _0024Df _0024B => _0024ic();

		private new _0024If _0024c => _0024Ic();

		private _0024Od _0024dc()
		{
			return null;
		}

		private _0024Ec _0024Dc()
		{
			return null;
		}

		private _0024Wc _0024ec()
		{
			return null;
		}

		private _0024Df _0024ic()
		{
			return null;
		}

		private _0024If _0024Ic()
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		private void _0024Ec()
		{
		}

		private void _0024fc()
		{
		}

		private bool _0024Fc()
		{
			return false;
		}

		private bool _0024gc()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_0024Ue))]
		private UniTaskVoid _0024jc()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024gB))]
		private UniTask<bool> _0024Jc()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024YB))]
		private UniTask<bool> _0024kc(CancellationToken _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024oC))]
		private UniTask _0024Kc()
		{
			return default;
		}

		private void _0024lc(PopupRestoreConflict _1, UniTaskCompletionSource _1)
		{
		}

		[AsyncStateMachine(typeof(_0024bb))]
		private UniTaskVoid _0024Lc(PopupRestoreConflict _1, UniTaskCompletionSource _1)
		{
			return default;
		}

		private void _0024mc()
		{
		}

		private void _0024Mc()
		{
		}

		private void _0024Gc()
		{
		}

		private SceneIndex _0024hc()
		{
			return SceneIndex.Logo;
		}

		private void _0024Hc()
		{
		}
	}
}
