using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _0024l;
using _0024s;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JoyCraftSDK.CloudSave;
using JoyCraftSDK.SaveSystem;

namespace _0024P
{
	public class _0024ef : _0024YD
	{
		[StructLayout((LayoutKind)3)]
		private struct _0024Ef : IAsyncStateMachine
		{
			public int _0024Tj;

			public AsyncUniTaskVoidMethodBuilder _0024uj;

			public _0024ef _0024aJ;

			public SavedGameData _0024AJ;

			public long _0024bJ;

			public CancellationToken _0024FJ;

			private UniTask<CloudPushResult>.Awaiter _0024gJ;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024pkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $pkA
				this._0024pkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024ff : IAsyncStateMachine
		{
			public int _0024GJ;

			public AsyncUniTaskMethodBuilder<bool> _0024RJ;

			public _0024ef _0024UJ;

			public CancellationToken _0024wJ;

			private bool _0024bk;

			private SavedGameData _0024Bk;

			private long _0024ck;

			private BootSyncOutcome _0024Ck;

			private bool _0024dk;

			private UniTask<BootSyncOutcome>.Awaiter _0024Dk;

			private UniTask<CloudPushResult>.Awaiter _0024ek;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024PkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $PkA
				this._0024PkA(_1);
			}
		}

		[StructLayout((LayoutKind)3)]
		private struct _0024Ff : IAsyncStateMachine
		{
			public int _0024Ek;

			public AsyncUniTaskMethodBuilder<bool> _0024fk;

			public UniTask _0024Fk;

			public Func<UniTask<bool>> _0024gk;

			private UniTask.Awaiter _0024Gk;

			private UniTask<bool>.Awaiter _0024hk;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void _0024qkA(IAsyncStateMachine _1)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _1)
			{
				//ILSpy generated this explicit interface implementation from .override directive in $qkA
				this._0024qkA(_1);
			}
		}

		private readonly _0024If _0024vp;

		private readonly AGameDataManager _0024Vp;

		private readonly Func<long> _0024Wp;

		private readonly _0024Vf _0024Sj;

		private readonly _0024uf _0024tj;

		public _0024ef(_0024If envelopeSyncController, AGameDataManager gameDataManager, Func<long> nowUtcProvider, _0024Vf telemetry = null, _0024uf breadcrumb = null)
		{
		}

		[AsyncStateMachine(typeof(_0024Ff))]
		public static UniTask<bool> _0024gz(UniTask _1, Func<UniTask<bool>> _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024ff))]
		public UniTask<bool> _0024Gz(CancellationToken _1)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_0024Ef))]
		private UniTaskVoid _0024hz(SavedGameData _1, long _1, CancellationToken _1)
		{
			return default;
		}
	}
}
